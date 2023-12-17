using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TAG.Networking.Agent.Client;

namespace WalletExample
{
    internal class GlobalConfig
    {
        public static Configuration instance = new() { BasePath = "http://localhost" };
    }
}
