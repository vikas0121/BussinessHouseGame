using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessGame
{
    public class Bank
    {
        private int _totalMoney = 5000;

        //public int TotalMoney
        //{
        //    get { return this._totalMoney; }
        //    set
        //    {
        //        this._totalMoney = value;
        //    }
        //}

        //private static Bank _instance = null;
        //private static readonly object Padlock = new object();

        //private Bank()
        //{
        //}

        //public static Bank Instance
        //{
        //    get
        //    {
        //        if (_instance == null)
        //        {
        //            lock (Padlock)
        //            {
        //                if (_instance == null)
        //                {
        //                    _instance = new Bank();
        //                }
        //            }
        //        }
        //        return _instance;
        //    }
        //}

        internal void AddMoneyEarned(int p)
        {
            _totalMoney += p;
        }
    }
}
