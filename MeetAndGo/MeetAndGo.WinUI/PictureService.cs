using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace MeetAndGo.WinUI
{
    public class PictureService
    {
        public PictureService()
        {
        }

        static public Image FromByteToImage(byte[] image)
        {
            return Image.FromStream(new MemoryStream(image));
        }

        static public byte[] FromImageToByte(TextBox text)
        {
            var file = File.ReadAllBytes(text.Text);
            return file;
        }
    }
}
