using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asdasd.Class.BaseClass
{
    public abstract class Сar
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="nummber1"></param>
        /// <param name="nummber2"></param>
        /// <returns></returns>
         public double sum(int nummber1, int nummber2)
        {
            return nummber1 + nummber2;
        }
        public double sum(int nummber1, int nummber2, int nummber3)
        {
            return nummber1 + nummber2 + nummber3;
        }
        public double sum(double nummber1, double nummber2)
        {
            return nummber1 + nummber2;
        }

    }
}

