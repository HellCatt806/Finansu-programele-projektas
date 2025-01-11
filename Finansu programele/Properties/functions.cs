using System.Globalization;
using Finansu_programele;

public class Functions
{
    private MainForm mainForm;
    public Functions(MainForm form) {
        mainForm = form;
    }
    public Functions()
    {

    }
    public void setMonthUI(int currentMonthNumber)
    {
        string monthName = getMonthNameLt(currentMonthNumber);
        mainForm.changeMonthNameLabel(monthName);
        mainForm.clearIncomeExpensePanel();

    }
    public static string getMonthNameLt(int currentMonthNumber)
    {
        switch(currentMonthNumber){
            case 1:
                return "Sausis";
            case 2:
                return "Vasaris";
            case 3:
                return "Kovas";
            case 4:
                return "Balandis";
            case 5:
                return "Gegužė";
            case 6:
                return "Birželis";
            case 7:
                return "Liepa";
            case 8:
                return "Rugpjūtis";
            case 9:
                return "Rugsėjis";
            case 10:
                return "Spalis";
            case 11:
                return "Lapkritis";
            case 12:
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
                return 1;
            case "Vasaris":
                return 2;
            case "Kovas":
                return 3;
            case "Balandis":
                return 4;
            case "Gegužė":
                return 5;
            case "Birželis":
                return 6;
            case "Liepa":
                return 7;
            case "Rugpjūtis":
                return 8;
            case "Rugsėjis":
                return 9;
            case "Spalis":
                return 10;
            case "Lapkritis":
                return 11;
            case "Gruodis":
                return 12;
            default:
                return -1;
        }
    }
    public static int getExpensesTypeIdByText(string expenseTypeText)
    {
        switch (expenseTypeText)
        {
            case "Maistas":
                return 1;
            case "Transportas":
                return 2;
            case "Taupymas":
                return 3;
            case "Skolos":
                return 4;
            case "Mokesčiai":
                return 5;
            case "Buitinės išlaidos":
                return 6;
            case "Švietimas (mokslai)":
                return 7;
            case "Kita":
                return 8;
            default:
                return -1;

        }
    }
}