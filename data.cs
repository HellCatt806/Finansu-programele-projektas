using System;
using System.Collections.Generic;

namespace Finansu_programele.Properties
{
    public static class Data
    {
        public static List<month> months = new List<month>();

        public class month
        {
            public string monthName { get; set; }

            
            public List<string> expenseName { get; set; }
            public List<float> expensePrice { get; set; }
            public List<int> expenseType { get; set; }

            
            public List<string> incomeName { get; set; }
            public List<float> incomeAmount { get; set; }

           
            public month(string monthName)
            {
                this.monthName = monthName;

               
                expenseName = new List<string>();
                expensePrice = new List<float>();
                expenseType = new List<int>();

                incomeName = new List<string>();
                incomeAmount = new List<float>();
            }
        }

        
        public class DataItem
        {
            public string Label { get; set; }
            public double Value { get; set; }
        }
    }
}