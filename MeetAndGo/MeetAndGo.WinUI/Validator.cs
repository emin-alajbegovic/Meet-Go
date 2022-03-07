using System.ComponentModel;
using System.Windows.Forms;

namespace MeetAndGo.WinUI
{
    public class Validator
    {
        public static void RequiredFieldTxt(TextBox textBox, CancelEventArgs e, ErrorProvider err, string message)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                err.SetError(textBox, message);
                e.Cancel = true;
            }
            else
                err.SetError(textBox, null);
        }

        public static void RequiredFieldLength(TextBox txtBox, CancelEventArgs e, ErrorProvider err, string message)
        {
            if (txtBox.Text.Length > 255)
            {
                err.SetError(txtBox, message);
                e.Cancel = true;
            }
            else
                err.SetError(txtBox, null);
        }

        public static bool RequiredFieldText(TextBox txtBox, ErrorProvider err, string message)
        {
            if (string.IsNullOrWhiteSpace(txtBox.Text))
            {
                err.SetError(txtBox, message);
                return false;
            }
            else
                err.SetError(txtBox, null);
            return true;
        }

        public static bool RequiredCombo(ComboBox cmb, ErrorProvider err, string message)
        {
            if (string.IsNullOrWhiteSpace(cmb.Text))
            {
                err.SetError(cmb, message);
                return false;
            }
            else
                err.SetError(cmb, null);
            return true;
        }

        public static void RequiredFieldComboBox(ComboBox cmb, CancelEventArgs e, ErrorProvider err, string message)
        {
            if (cmb.SelectedIndex == 0)
            {
                err.SetError(cmb, message);
                e.Cancel = true;
            }
            else
                err.SetError(cmb, null);
        }
        public static void RequiredFieldCheckListBox(CheckedListBox clb, CancelEventArgs e, ErrorProvider err, string message)
        {
            if (clb.CheckedItems.Count == 0)
            {
                err.SetError(clb, message);
                e.Cancel = true;
            }
            else
                err.SetError(clb, null);
        }

        public static bool RequiredFieldPicture(TextBox txtBox, ErrorProvider err, string message)
        {
            if (string.IsNullOrWhiteSpace(txtBox.Text))
            {
                err.SetError(txtBox, message);
                return false;
            }
            else
                err.SetError(txtBox, null);
            return true;
        }
    }
}
