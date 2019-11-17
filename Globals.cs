using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPax
{
    public class Globals
    {
        private static Globals instance;

        public string connection { get; set; }
        public string ftp { get; set; }
        public string Carrier { get; set; }
        public string user { get; set; }
        public string session { get; set; }

        public AppRegistry registry { get; set; }

        public int splashDuration = 10000;

        private Globals() { }
        public static Globals getInstance()
        {
            if (instance == null)
            {
                instance = new Globals();
            }
            return instance;
        }
    }
}
