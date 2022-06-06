using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;

namespace XMLProject
{
    public partial class Form1 : Form
    {
        List<Rose> roses = new List<Rose>(); // massive of roses
        Rose selectedRose = null;            // selected rose
        Boolean dragging;                    // dragging mode
        Point startDragPoint;                // start point before dragging
        string filename = "garden";

        public Form1()
        {
            InitializeComponent();
        }

        void OpenProject(string newFileName)
        {
            // Clean current document
            //newToolStripMenuItem_Click(null, null);

            // Initialization classes for reading
            FileStream fs = new FileStream(newFileName, FileMode.Open);
            XmlTextReader xmlIn = new XmlTextReader(fs);
            xmlIn.WhitespaceHandling = WhitespaceHandling.None;

            // Move to the very beginning of the file
            xmlIn.MoveToContent();

            // Check first tag of the document
            if (xmlIn.Name != "RosesPlant")
                throw new ArgumentException("Incorrect file format.");

            string version = xmlIn.GetAttribute(0);

            // Loop of reading tags
            do
            {
                // Can we read first tag?
                if (!xmlIn.Read())
                    throw new ArgumentException("There is a mistake.");

                // Check type of a tag
                if ((xmlIn.NodeType == XmlNodeType.EndElement) &&
                    (xmlIn.Name == "RosesPlant"))
                    break;

                // If it is the ending element, no need to check
                if (xmlIn.NodeType == XmlNodeType.EndElement)
                    continue;

                // If it is rose, let's read parameters
                if (xmlIn.Name == "Rose")
                {
                    Rose newItem = new Rose("", 0, 0);
                    roses.Add(newItem);
                    newItem.LoadFromFile(xmlIn);
                }
            } while (!xmlIn.EOF);

            // Close classes
            xmlIn.Close();
            fs.Close();

            filename = newFileName;
            designerPanel.Invalidate();
        }

        void SaveProject()
        {
            // Create an object and a stream of XML-document
            FileStream fs = new FileStream(filename, FileMode.Create);
            XmlTextWriter xmlOut = new XmlTextWriter(fs, Encoding.Unicode);

            xmlOut.Formatting = Formatting.Indented;

            // Start of beginnig document
            xmlOut.WriteStartDocument();
            xmlOut.WriteComment("This file was created as an example");
            xmlOut.WriteComment("Автор: Михаил Фленов (www.flenov.info)");

            // Create a root element
            xmlOut.WriteStartElement("RosesPlant");
            xmlOut.WriteAttributeString("Version", "1");

            // Loop of every rose and save it
            foreach (Rose item in roses)
                item.SaveToFile(xmlOut);

            // Close root tag and the document
            xmlOut.WriteEndElement();
            xmlOut.WriteEndDocument();

            // Close objects of saving
            xmlOut.Close();
            fs.Close();
        }

        private void addARoseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rose rose = new Rose("Rose" + roses.Count.ToString(), 0, 0);
            roses.Add(rose);
            designerPanel.Invalidate();
        }

        private void designerPanel_Paint(object sender, PaintEventArgs e)
        {
            foreach (Rose rose in roses)
                rose.Draw(e.Graphics);
        }

        private void designerPanel_MouseDown(object sender, MouseEventArgs e)
        {
            Rose rose = GetItemAt(e.X, e.Y);

            if (rose != null)
            {
                selectedRose = rose;
                dragging = true;
                startDragPoint = e.Location;
                DrawDraggingShape();
            }
        }

        private Rose GetItemAt(int x, int y)
        {
            foreach (Rose currRose in roses)
            {
                if (currRose.X < x && currRose.X + currRose.Width > x &&
                    currRose.Y < y && currRose.Y + currRose.Height > y)
                    return currRose;
            }

            return null;
        }

        private void DrawDraggingShape()
        {
            Point point = designerPanel.PointToScreen(selectedRose.Location);
            ControlPaint.DrawReversibleFrame(new Rectangle(point, selectedRose.Size),
                SystemColors.ButtonFace, FrameStyle.Dashed);
        }

        private void designerPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                DrawDraggingShape();
                selectedRose.X = selectedRose.Location.X + 
                    (e.Location.X - startDragPoint.X);
                selectedRose.Y = selectedRose.Location.Y +
                    (e.Location.Y - startDragPoint.Y);
                DrawDraggingShape();
                startDragPoint = e.Location;
            }
        }

        private void openAFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Show choice window
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "XML Files|*.xml";

            if (ofd.ShowDialog() != DialogResult.OK)
                return;

            OpenProject(ofd.FileName);
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "XML Files|*.xml";

            SaveProject();
        }
    }
}
