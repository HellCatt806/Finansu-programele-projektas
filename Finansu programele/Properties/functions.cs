using System.Globalization;
using Finansu_programele;

public class Functions
{
    private MainForm mainForm;
    public Functions(MainForm form) {
        mainForm = form;
    }
    public void setMonthUI(int currentMonthNumber)
    {
        string monthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(currentMonthNumber);
        mainForm.changeMonthNameLabel(monthName);
        mainForm.clearIncomeExpensePanel();

    }
}