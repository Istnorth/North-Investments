# North Investments

North Investments is a Windows Forms application developed in C# that simulates investment portfolio management. This application is designed for users to manage various investment portfolios, track financial assets, and evaluate market performance using simulated data.

## Features

- **Portfolio Management**: Create and manage multiple investment portfolios.
- **Transaction Tracking**: Add, edit, and remove transactions (buy/sell) for assets.
- **Market Simulation**: Simulate market conditions and analyze their impact on your portfolio's performance.
- **User Authentication**: Log in and register new users to manage individual portfolios securely.
- **Performance Monitoring**: Track the growth of your investments over time and visualize key performance indicators.
- **User-friendly Interface**: Intuitive and easy-to-navigate graphical interface built with Windows Forms.

## Getting Started

### Prerequisites

- **.NET Framework 4.7.2** or higher.
- **Visual Studio 2022** (or compatible version) for building and running the project.

### Installation

1. Clone this repository to your local machine:
    ```bash
    git clone https://github.com/Istnorth/North-Investments.git
    ```

2. Open the solution file `North Investments.sln` in Visual Studio.

3. Restore NuGet packages and build the solution:
    - Right-click on the solution in the **Solution Explorer**.
    - Select **Restore NuGet Packages**.
    - After that, build the project by clicking **Build** > **Build Solution**.

4. Run the project by clicking the green **Start** button in Visual Studio or pressing `F5`.

### How to Use

1. **User Authentication**:
    - Register a new account or log in with an existing account to access your portfolios.

2. **Create a Portfolio**:
    - Once logged in, you can create a new investment portfolio by navigating to the portfolio management section.

3. **Add Transactions**:
    - Add buy/sell transactions to track your investments in stocks, bonds, or other assets.

4. **Simulate Market Conditions**:
    - Use the market simulator to see how different market scenarios affect your portfolio's value.

5. **Monitor Performance**:
    - View detailed reports and graphs showing the performance of your investments over time.

## Folder Structure

- **Forms**: Contains the Windows Forms used for the user interface, such as login, portfolio management, and market simulation.
- **MarketSimulator.cs**: Handles the simulation of market conditions and their impact on the portfolio.
- **Transaction.cs**: Manages the logic related to investment transactions.
- **Images**: Stores any images used within the application, such as logos or icons.
