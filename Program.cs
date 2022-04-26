using System;

namespace NorthwindDatabaseApplication
{
    class Program
    {
        private static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();
        
        static void Main(string[] args)
        {
            Logger.Info("Program Started");
        }
    }
}