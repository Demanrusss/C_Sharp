using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Http;
using GeneralLibraryPrj;

namespace RemotingServer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Application is launched");

            HttpChannel channel = new HttpChannel(32121);
            ChannelServices.RegisterChannel(channel, false);

            RemotingConfiguration.RegisterWellKnownServiceType(
                typeof(GeneralRemoteClass),
                "OurFirstSoapProject.soap",
                WellKnownObjectMode.Singleton);
            Console.ReadLine();         
        }
    }
}
