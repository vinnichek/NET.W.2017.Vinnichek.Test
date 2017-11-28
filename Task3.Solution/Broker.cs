using System;
namespace Task3.Solution
{
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
}
