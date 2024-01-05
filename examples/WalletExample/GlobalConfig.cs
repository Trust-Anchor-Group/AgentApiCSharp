using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Neuron.Agent.Client;

namespace WalletExample
{
    internal class GlobalConfig
    {
        public static Configuration instance = new() { BasePath = "https://neuron.saunter.tech" };
    }
}
