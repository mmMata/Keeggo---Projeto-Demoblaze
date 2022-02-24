using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Demoblaze
{
    public static class Helper
    {
        public static string Executavel => Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

    }
}
