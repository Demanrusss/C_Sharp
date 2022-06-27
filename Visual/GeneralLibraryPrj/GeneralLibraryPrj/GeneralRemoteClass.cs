using System;

namespace GeneralLibraryPrj
{
    public class GeneralRemoteClass : MarshalByRefObject
    {
        public GeneralRemoteClass()
        {

        }

        public void SendToSraver(string message)
        {
            Console.WriteLine(message);
        }

        public string ReplyFromSraver()
        {
            return "this message";
        }
    }
}
