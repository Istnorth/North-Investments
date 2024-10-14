using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace North_Investments
{
    public class MarketSimulator
    {
        private static readonly Random random = new Random();

        public static void UpdateMarket()
        {
            using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-S1LVDJS\SQLEXPRESS;Initial Catalog=NorthVest;Integrated Security=True"))
            {
                con.Open();
                List<Asset> assets = GetAssets(con);
                UpdateAssetPrices(assets, con);
                List<int> portfolioIds = GetPortfolioIds(con);
                SavePortfolioValueHistory(portfolioIds, con);
            }
        }

        private static List<Asset> GetAssets(SqlConnection con)
        {
            SqlCommand cmd = new SqlCommand("SELECT AssetId, Price FROM Assets", con);
            SqlDataReader reader = cmd.ExecuteReader();

            List<Asset> assets = new List<Asset>();

            while (reader.Read())
            {
                int assetId = reader.GetInt32(0);
                decimal currentPrice = reader.GetDecimal(1);
                assets.Add(new Asset { AssetId = assetId, CurrentPrice = currentPrice });
            }
            reader.Close();

            return assets;
        }

        private static void UpdateAssetPrices(List<Asset> assets, SqlConnection con)
        {
            foreach (var asset in assets)
            {
                decimal priceChange = (decimal)(random.NextDouble() * 200 - 100);
                decimal newPrice = asset.CurrentPrice + priceChange;
                if (newPrice < 0) newPrice = 1;

                SqlCommand updateCmd = new SqlCommand("UPDATE Assets SET Price = @NewPrice WHERE AssetId = @AssetId", con);
                updateCmd.Parameters.AddWithValue("@NewPrice", newPrice);
                updateCmd.Parameters.AddWithValue("@AssetId", asset.AssetId);
                updateCmd.ExecuteNonQuery();

                SqlCommand insertCmd = new SqlCommand("INSERT INTO AssetPriceHistory (AssetId, Price) VALUES (@AssetId, @Price)", con);
                insertCmd.Parameters.AddWithValue("@AssetId", asset.AssetId);
                insertCmd.Parameters.AddWithValue("@Price", newPrice);
                insertCmd.ExecuteNonQuery();
            }
        }

        private static List<int> GetPortfolioIds(SqlConnection con)
        {
            SqlCommand cmd = new SqlCommand("SELECT PortfolioId FROM Portfolios", con);
            SqlDataReader reader = cmd.ExecuteReader();

            List<int> portfolioIds = new List<int>();

            while (reader.Read())
            {
                int portfolioId = reader.GetInt32(0);
                portfolioIds.Add(portfolioId);
            }
            reader.Close();

            return portfolioIds;
        }

        private static decimal CalculatePortfolioValue(int portfolioId, SqlConnection con)
        {
            decimal totalValue = 0;

            SqlCommand cmd = new SqlCommand("SELECT AssetId, Quantity FROM PortfolioDetails WHERE PortfolioId = @PortfolioId", con);
            cmd.Parameters.AddWithValue("@PortfolioId", portfolioId);
            SqlDataReader reader = cmd.ExecuteReader();

            List<PortfolioAsset> portfolioAssets = new List<PortfolioAsset>();

            while (reader.Read())
            {
                int assetId = reader.GetInt32(0);
                int quantity = reader.GetInt32(1);
                portfolioAssets.Add(new PortfolioAsset { AssetId = assetId, Quantity = quantity });
            }
            reader.Close();

            foreach (var portfolioAsset in portfolioAssets)
            {
                SqlCommand priceCmd = new SqlCommand("SELECT Price FROM Assets WHERE AssetId = @AssetId", con);
                priceCmd.Parameters.AddWithValue("@AssetId", portfolioAsset.AssetId);
                decimal currentPrice = (decimal)priceCmd.ExecuteScalar();
                totalValue += portfolioAsset.Quantity * currentPrice;
            }

            return totalValue;
        }

        private static void SavePortfolioValueHistory(List<int> portfolioIds, SqlConnection con)
        {
            foreach (var portfolioId in portfolioIds)
            {
                decimal currentValue = CalculatePortfolioValue(portfolioId, con);

                SqlCommand insertCmd = new SqlCommand("INSERT INTO PortfolioValueHistory (PortfolioId, Value) VALUES (@PortfolioId, @Value)", con);
                insertCmd.Parameters.AddWithValue("@PortfolioId", portfolioId);
                insertCmd.Parameters.AddWithValue("@Value", currentValue);
                insertCmd.ExecuteNonQuery();
            }
        }

        private class Asset
        {
            public int AssetId { get; set; }
            public decimal CurrentPrice { get; set; }
        }

        private class PortfolioAsset
        {
            public int AssetId { get; set; }
            public int Quantity { get; set; }
        }
    }
}
