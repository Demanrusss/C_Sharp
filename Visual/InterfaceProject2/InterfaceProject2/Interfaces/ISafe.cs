
namespace InterfaceProject2.Interfaces
{
    internal interface ISafe : IPurse
    {
        bool Locked
        {
            get;
        }

        void Lock();
        void Unlock();
    }
}
