
namespace InterfaceProject
{
    interface IPurse
    {
        int Sum
        {
            get;
            set;
        }

        void AddMoney(int sum);
        int DecMoney(int sum);
    }
}
