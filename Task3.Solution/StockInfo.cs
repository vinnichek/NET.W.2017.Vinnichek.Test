using System;
namespace Task3.Solution
{
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
}
