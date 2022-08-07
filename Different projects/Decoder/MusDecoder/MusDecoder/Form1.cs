using System.IO;
using System.Text;

namespace MusDecoder
{
    public partial class Form1 : Form
    {
        private string _openedFileName = "";

        public Form1()
        {
            InitializeComponent();
        }

        public void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.Cancel)
                return;

            string filename = ofd.FileName;
            _openedFileName = filename;

            byte[] bufer = new byte[1024];
            ASCIIEncoding ascii = new ASCIIEncoding();

            FileStream fs = File.OpenRead(filename);
            int readed = fs.Read(bufer, 0, 1024);

            while (readed > 0)
            {
                beforeDecodingRichTextBox.AppendText(ascii.GetString(bufer, 0, readed));
                readed = fs.Read(bufer, 0, 1024);
            }

            fs.Close();
        }

        public void decodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(_openedFileName, FileMode.Open);

            MusCoder.Transcode(fs);

 /*           int hash = filename.GetHashCode();

            ASCIIEncoding ascii = new ASCIIEncoding();
 //           UnicodeEncoding unicode = new UnicodeEncoding();

            FileStream fs = File.OpenRead(filename);
            int b = fs.ReadByte();

            using (FileStream fsMus = new FileStream(
                Path.Combine(
                    Path.GetFileNameWithoutExtension(filename), ".mus"),
                FileMode.OpenOrCreate))
            {
                MessageBox.Show(b.ToString());

                do
                {
                    b = fs.ReadByte();
                    byte b2 = (byte)(b ^ hash >> 8);
                    hash = hash * 498729871 + 85731 * b;
                    fsMus.WriteByte(b2);
                } while (b != -1);

                byte[] bufer = new byte[1024];
                int readed = fs.Read(bufer, 0, 1024);

                while (readed > 0)
                {
                    afterDecodingRichTextBox.AppendText(ascii.GetString(bufer, 0, readed));
                    readed = fs.Read(bufer, 0, 1024);
                }
            }*/
        }
    }
}