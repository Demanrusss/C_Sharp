
namespace InterfaceProject2.Interfaces
{
    interface ITriplePurse
    {
        int Sum { get; set; }

        void AddMoney(int amount);
        void DecMoney(int amount);
    }
}
