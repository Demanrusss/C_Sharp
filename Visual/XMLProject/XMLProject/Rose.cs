using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Xml;

namespace XMLProject
{
    internal class Rose
    {
        const int DEFAULT_WIDTH = 50;
        const int DEFAULT_HEIGHT = 46;
        Image roseImage = Properties.Resources.Roze;

        // Constructor of the class
        public Rose(string name, int x, int y)
        {
            this.Name = name;
            this.X = x;
            this.Y = y;
            this.Width = DEFAULT_WIDTH;
            this.Height = DEFAULT_HEIGHT;
        }

        #region Properties
        public string Name { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public Size Size
        {
            get { return new Size(Width, Height); } 
        }

        public Point Location
        {
            get { return new Point(X, Y); }
        }
        #endregion

        #region Opened methods

        public void Draw(Graphics g)
        {
            g.DrawImage(roseImage, X, Y, Width, Height);
            g.DrawString(Name, SystemFonts.DefaultFont, SystemBrushes.WindowText,
                new Point(X, Y + Height));
        }

        public void SaveToFile(XmlTextWriter xmlOut)
        {
            xmlOut.WriteStartElement("Rose");
            xmlOut.WriteAttributeString("Name", Name);
            xmlOut.WriteAttributeString("X", X.ToString());
            xmlOut.WriteAttributeString("Y", Y.ToString());
            xmlOut.WriteAttributeString("Width", Width.ToString());
            xmlOut.WriteAttributeString("Height", Height.ToString());
            xmlOut.WriteEndElement();
        }

        public void LoadFromFile(XmlTextReader xmlIn)
        {
            try
            {
                Name = xmlIn.GetAttribute("Name");
                X = Convert.ToInt32(xmlIn.GetAttribute("X"));
                Y = Convert.ToInt32(xmlIn.GetAttribute("Y"));
                Width = Convert.ToInt32(xmlIn.GetAttribute("Width"));
                Height = Convert.ToInt32(xmlIn.GetAttribute("Height"));
            }
            catch (Exception)
            {
                // Empty
            }
        }

        #endregion
    }
}
