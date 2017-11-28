using System;
namespace Task3.Solution
{
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
}
