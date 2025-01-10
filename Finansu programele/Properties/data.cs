﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finansu_programele.Properties
{
    internal class data
    {
        struct month
        {
            string monthName;

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
            public void InitializeValues()
            {
                if (expenseName == null){expenseName = new List<string>();}
                if (expensePrice == null) { expensePrice = new List<float>(); }
                if (expenseType == null) { expenseType = new List<int>(); }

                if (incomeName == null) { incomeName = new List<string>(); }
                if (incomeAmount == null) { incomeAmount = new List<float>(); }
            }
        }
    }
}