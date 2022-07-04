using System.IO;
using System.Text;

namespace MusDecoder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.Cancel)
                return;

            string filename = ofd.FileName;

            byte[] bufer = new byte[1024];
            ASCIIEncoding ascii = new ASCIIEncoding();
//            UnicodeEncoding unicode = new UnicodeEncoding();

            FileStream fs = File.OpenRead(filename);
            int readed = fs.Read(bufer, 0, 1024);

            while (readed > 0)
            {
                richTextBox1.AppendText(ascii.GetString(bufer, 0, readed));
                readed = fs.Read(bufer, 0, 1024);
            }
        }

        private void encodingToOggToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();

            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.Cancel)
                return;

            string filename = ofd.FileName;

            int hash = ofd.GetHashCode();

            ASCIIEncoding ascii = new ASCIIEncoding();
            //            UnicodeEncoding unicode = new UnicodeEncoding();

            FileStream fs = File.OpenRead(filename);
            int b = fs.ReadByte();

            using (FileStream fsMus = new FileStream(filename + ".mus", FileMode.OpenOrCreate))
            {
                MessageBox.Show(b.ToString());

                do
                {
                    b = fs.ReadByte();
                    byte b2 = (byte)(b ^ hash >> 8);
                    hash = hash * 498729871 + 85731 * b;
                    fsMus.WriteByte(b2);
                } while (b != -1);
            }
        }
    }
}