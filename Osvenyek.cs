using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTarsas
{
    internal class Osvenyek
    {
        string osveny;
        public Osvenyek(string sor) 
        {
            this.osveny = sor;
        }

        public string Osveny { get => osveny; }
    }
}
