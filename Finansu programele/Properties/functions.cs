using System.Globalization;
using Finansu_programele;
using Finansu_programele.Properties;

public class Functions
{
    private MainForm mainForm;
    public Functions(MainForm form) {
        mainForm = form;
    }
    public Functions()
    {

    }
    //Starter month
    public void setMonthUIOnStart(int currentMonthNumber)
    {
        string monthName = getMonthNameLt(currentMonthNumber);
        mainForm.changeMonthNameLabel(monthName);
        mainForm.clearIncomeExpensePanel();
        mainForm.disableCartesianChart1();
        if ((currentMonthNumber - 1) < 0){
            mainForm.disablePreviousMonthButton();
        }else if((currentMonthNumber + 1) > 11){
            mainForm.disableNextMonthButton();
        }
    }
    public static string getMonthNameLt(int currentMonthNumber)
    {
        switch(currentMonthNumber){
            case 0:
                return "Sausis";
            case 1:
                return "Vasaris";
            case 2:
                return "Kovas";
            case 3:
                return "Balandis";
            case 4:
                return "Gegužė";
            case 5:
                return "Birželis";
            case 6:
                return "Liepa";
            case 7:
                return "Rugpjūtis";
            case 8:
                return "Rugsėjis";
            case 9:
                return "Spalis";
            case 10:
                return "Lapkritis";
            case 11:
                return "Gruodis";
            default:
                return "Error";
        }
    }
    public static int getMonthIdByName(string monthName)
    {
        switch (monthName)
        {
            case "Sausis":
                return 0;
            case "Vasaris":
                return 1;
            case "Kovas":
                return 2;
            case "Balandis":
                return 3;
            case "Gegužė":
                return 4;
            case "Birželis":
                return 5;
            case "Liepa":
                return 6;
            case "Rugpjūtis":
                return 7;
            case "Rugsėjis":
                return 8;
            case "Spalis":
                return 9;
            case "Lapkritis":
                return 10;
            case "Gruodis":
                return 11;
            default:
                return -1;
        }
    }
    public static int getExpensesTypeIdByText(string expenseTypeText)
    {
        switch (expenseTypeText)
        {
            case "Maistas":
                return 0;
            case "Transportas":
                return 1;
            case "Taupymas":
                return 2;
            case "Skolos":
                return 3;
            case "Mokesčiai":
                return 4;
            case "Buitinės išlaidos":
                return 5;
            case "Švietimas (mokslai)":
                return 6;
            case "Kita":
                return 7;
            default:
                return -1;

        }
    }
    public void changeMonth(int monthNumber)
    {
        string monthName = getMonthNameLt(monthNumber);
        mainForm.changeMonthNameLabel(monthName);
        mainForm.clearIncomeExpensePanel();

        int expenseCount = Data.months[monthNumber].expenseName.Count;
        int incomeCount = Data.months[monthNumber].incomeName.Count;

        if (expenseCount > 0)
        {
            for (int i = 0; i < expenseCount; i++)
            {
                mainForm.addExpense(Data.months[monthNumber].expenseName[i], Data.months[monthNumber].expensePrice[i], i);
            }
            mainForm.updateExpensesIncomeTotal(monthNumber);

            mainForm.enableCartesianChart1();
        }
        if(incomeCount > 0)
        {
            for (int a = 0; a < incomeCount; a++)
            {
                mainForm.addIncome(Data.months[monthNumber].incomeName[a], Data.months[monthNumber].incomeAmount[a], a);
            }
            mainForm.updateExpensesIncomeTotal(monthNumber);

            mainForm.enableCartesianChart1();
        }
        if(expenseCount == 0 && incomeCount == 0){
            mainForm.disableCartesianChart1();
        }
    }
}