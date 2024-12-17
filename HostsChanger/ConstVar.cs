using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostsChanger
{
    internal class ConstVar
    {
        public static readonly string PROGRAM_DATA_PATH = @"C:\ProgramData\HostsChanger";
        public static readonly string HOME_HOSTS_CONFIG_PATH = PROGRAM_DATA_PATH + @"\home.txt";
        public static readonly string HOSTS_PATH = @"C:\windows\system32\drivers\etc\hosts";
    }
}
