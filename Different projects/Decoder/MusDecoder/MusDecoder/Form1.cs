using System.IO;
using System.Text;

namespace MusDecoder
{
    public partial class Form1 : Form
    {
        private string _openedFilePath = String.Empty;

        public Form1()
        {
            InitializeComponent();
        }

        public void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.Cancel)
                return;

            _openedFilePath = ofd.FileName;
            
            printOut(_openedFilePath);
        }

        private void printOut(string filePath)
        {
            using (FileStream fs = File.OpenRead(filePath))
            {
                beforeDecodingRichTextBox.Clear();

                byte[] bufer = new byte[1024];
                int readed = fs.Read(bufer, 0, 1024);

                ASCIIEncoding ascii = new ASCIIEncoding();

                while (readed > 0)
                {
                    beforeDecodingRichTextBox.AppendText(ascii.GetString(bufer, 0, readed));
                    readed = fs.Read(bufer, 0, 1024);
                }

            }
        }

        public void decodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                MusCoder.Transcode(_openedFilePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("You didn't open a file.\n", ex.Message);
            }
        }

        private void openAfterDecodingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FileStream fs = File.OpenRead(MusCoder.outFilePath))
            {
                afterDecodingRichTextBox.Clear();

                byte[] bufer = new byte[1024];
                int readed = fs.Read(bufer, 0, 1024);

                ASCIIEncoding ascii = new ASCIIEncoding();

                while (readed > 0)
                {
                    afterDecodingRichTextBox.AppendText(ascii.GetString(bufer, 0, readed));
                    readed = fs.Read(bufer, 0, 1024);
                }
            }
        }
    }
}