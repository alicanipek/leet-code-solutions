
using System.Text;

public class ExcelColumnTitle {
    public string ConvertToTitle(int columnNumber) {
        StringBuilder columnTitle = new();
        int n;
        while(columnNumber > 0) {
            columnNumber--;
            n = columnNumber % 26;
            columnTitle.Insert(0, Convert.ToChar(65 + n));
            columnNumber /= 26;

        }

        return columnTitle.ToString();

    }
}
