using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties_HW
{
    class Quotation
    {
        public string CustomerName { get; private set; }
        public double[] SumLines { get; set; }
        public double DocSum
        {
            get
            {
                double sumOfAll = 0;
                for (int i = 0; i < SumLines.Length; i++)
                {
                    sumOfAll += SumLines[i];
                }
                return sumOfAll;
            }
        }

        public DateTime ValidUntil { get; private set; }

        public Quotation(string customerName, double[] numOfLines, DateTime validUntil)
        {
            CustomerName = customerName;
            SumLines = new double[numOfLines.Length];
            for (int i = 0; i < numOfLines.Length; i++)
            {
                SumLines[i] = numOfLines[i];
            }
            ValidUntil = validUntil;
        }

        public void ChangeMainDetails(string newCustomer, DateTime newDate)
        {
            CustomerName = newCustomer;
            ValidUntil = newDate;
        }
    }
}
