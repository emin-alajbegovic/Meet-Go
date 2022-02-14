using System.Windows.Forms;

namespace MeetAndGo.WinUI
{
    public class LoadDataHelper
    {
        static public void LoadDataInComboBox<T>(ComboBox combo, T data, string columnId)
        {
            combo.DataSource = data;
            combo.ValueMember = columnId;
            combo.DisplayMember = "Name";
        }

        static public void LoadDataInCheckedListBox<T>(CheckedListBox combo, T data, string columnId)
        {
            combo.DataSource = data;
            combo.ValueMember = columnId;
            combo.DisplayMember = "Name";
        }
    }
}
