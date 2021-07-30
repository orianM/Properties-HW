using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties_HW
{
    class Program
    {
        static void Main(string[] args)
        {
            #region question 1

            /*Using properties is useful because: it helps make our code more easy to read, 
                                                  saves lines of code and also is more flexible for access levels.*/

            #endregion

            #region question 2

            /*If a variable is not specifically declare for the property, the property will create a backing_field,
              property_backing_field.*/

            #endregion


            #region question 3

            /*It's possible to create a property with only a Getter.*/

            #endregion

            #region question 4

            /*It's possible to set different access modifiers to either the Getter or the Setter. */

            #endregion

            #region question 5

            /*A property can be declared as static.*/

            #endregion

            #region question 6

            string nameOfCustomer = "Johnny";
            double[] sumOfLines = { 3, 9, 3, 5 };
            DateTime dateOfValidation = DateTime.Now.AddDays(7);
            Quotation myQuo = new Quotation(nameOfCustomer, sumOfLines, dateOfValidation);
            myQuo.SumLines[2] = 30;
            myQuo.ChangeMainDetails("Not johnny", DateTime.Now.AddDays(4));

            #endregion
        }
    }
}
