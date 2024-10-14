using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace North_Investments
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            MarketSimulator.UpdateMarket();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm(500, 200, 800, 450));
        }
        public static void CloseAllForms()
        {
            List<Form> openForms = new List<Form>(Application.OpenForms.Cast<Form>());
            foreach (Form form in openForms)
            {
                form.Close();
            }
        }
    }
}
