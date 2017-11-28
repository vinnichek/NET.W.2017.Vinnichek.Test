using System;
namespace Task3.Solution
{
    public class Bank
    {
        public string Name { get; set; }

        public void BankStockStarter(StockInfo information)
        {
            information.NewStock += BankStock;
        }

        public void BankStock(object sender, StockEventArgs stockInfo)
        {
            if (stockInfo.Euro > 40)
                Console.WriteLine("Банк {0} продает евро;  Курс евро: {1}", this.Name, stockInfo.Euro);
            else
                Console.WriteLine("Банк {0} покупает евро;  Курс евро: {1}", this.Name, stockInfo.Euro);

        }

        public void BankStockStop(StockInfo information)
        {
            information.NewStock -= BankStock;
        }
    }
}
