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
        public Form1()
        {
            InitializeComponent();
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
    }
}
