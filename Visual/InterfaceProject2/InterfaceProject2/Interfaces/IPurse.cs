
namespace InterfaceProject2.Interfaces
{
    interface IPurse
    {
        int Sum { get; set; }

        void AddMoney(int amount);
        void DecMoney(int amount);
    }
}
