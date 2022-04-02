using System;

namespace NestedClass2
{
    public class Window
    {
        // Здесь идут свойства и методы класса Window

        public void ShutWindow()
        {
            // Код метода
        }
    }

    public class Shed
    {
        // Здесь идут свойства и методы класса Shed

        Window window = new Window();

        public Window FrontWindow
        {
            get { return window; }
            set { window = value; }
        }
    }
}
