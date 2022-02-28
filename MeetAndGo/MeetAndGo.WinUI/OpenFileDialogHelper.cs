using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace MeetAndGo.WinUI
{
    public class OpenFileDialogHelper
    {
        static public void LoadPicture(OpenFileDialog ofg, PictureBox pictureBox, TextBox textBox)
        {
            var file = File.ReadAllBytes(ofg.FileName);
            textBox.Text = ofg.FileName;
            pictureBox.Image = Image.FromFile(ofg.FileName);
        }
    }
}
