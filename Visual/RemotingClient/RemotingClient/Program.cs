using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Http;
using GeneralLibraryPrj;


namespace RemotingClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HttpChannel channel = new HttpChannel();
            ChannelServices.RegisterChannel(channel, false);

            GeneralRemoteClass remote = 
                (GeneralRemoteClass)Activator.GetObject(
                    typeof(GeneralRemoteClass),
                    "http://localhost:32121/OurFirstSoapProject.soap");

            remote.SendToSraver("Hello!");
            Console.WriteLine(remote.ReplyFromSraver());
            Console.ReadLine();
        }
    }
}
