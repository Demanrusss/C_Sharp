using System;

namespace NestedClass
{
    public class Shed
    {
        // Здесь идут свойства и методы класса Shed

        public class Window
        {
            // Здесь идут свойства и методы класса Windows

            public void ShutWindow()
            {
                // Код метода
            }
        }

        // Объявляем переменную типа окна
        Window window = new Window();

        // Превращаем переменную в свойство
        public Window FrontWindow
        {
            get { return window; }
            set { window = value; }
        }
    }
}
