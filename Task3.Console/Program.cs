using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task3.Solution;

namespace Task3.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank();
            Broker broker = new Broker();

            int usd = 20;
            int euro = 10;

            StockInfo info = new StockInfo();

            broker.BrokerStockStarter(info);
            bank.BankStockStarter(info);

            info.StockStarter(usd, euro);

            broker.BrokerStockStop(info);
            bank.BankStockStop(info);

            usd = 25;
            euro = 35;

            info.StockStarter(usd, euro);
        }
    }
}
