using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Finansu_programele.Properties.Data;

namespace Finansu_programele.Properties
{
    public static class Data
    {
        public static List<Data.month> months = new List<Data.month>();
        public struct month
        {
            public string monthName;

            //Expenses
            public List<string> expenseName;
            public List<float> expensePrice;
            public List<int> expenseType;

            //Income
            public List<string> incomeName;
            public List<float> incomeAmount;

            public month(string monthName)
            {
                this.monthName = monthName;

                expenseName = null;
                expensePrice = null;
                expenseType = null;

                incomeName = null;
                incomeAmount = null;
            }
            //Butina paleisti sita funkcija, kad veiktu struct
            public void InitializeValues()
            {
                if (expenseName == null) { expenseName = new List<string>(); }
                if (expensePrice == null) { expensePrice = new List<float>(); }
                if (expenseType == null) { expenseType = new List<int>(); }

                if (incomeName == null) { incomeName = new List<string>(); }
                if (incomeAmount == null) { incomeAmount = new List<float>(); }
            }
        }


    }
    public class DataItem
    {
        public string Label { get; set; }
        public double Value { get; set; }
    }
}
