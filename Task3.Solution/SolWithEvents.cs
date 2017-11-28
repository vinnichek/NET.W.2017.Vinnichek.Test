using System;
namespace Task3.Solution
{
    /*
    public sealed class StockEventArgs : EventArgs
    {
        public int USD { get; set; }
        public int Euro { get; set; }

        public StockEventArgs(int usd, int euro)
        {
            USD = usd;
            Euro = euro;
        }
    }

    public class StockInfo
    {
        public event EventHandler<StockEventArgs> NewStock;

        protected virtual void OnNewStock(StockEventArgs args)
        {
            NewStock?.Invoke(this, args);
        }

        public void StockStarter(int usd, int euro)
        {
            OnNewStock(new StockEventArgs(usd, euro));
        }
    }

    public class Broker
    {
        public string Name { get; set; }

        public void BrokerStockStarter(StockInfo information)
        {
            information.NewStock += BrokerStock;
        }

        public void BrokerStock(object sender, StockEventArgs stockInformation)
        {
            if (stockInformation.USD > 30)
                Console.WriteLine("Брокер {0} продает доллары;  Курс доллара: {1}", this.Name, stockInformation.USD);
            else
                Console.WriteLine("Брокер {0} покупает доллары;  Курс доллара: {1}", this.Name, stockInformation.USD);

        }

        public void BrokerStockStop(StockInfo information)
        {
            information.NewStock -= BrokerStock;
        }
    }

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
    */
}
