using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPax
{
    public class AppRegistry
    {
        private static string registryLocation= @"SOFTWARE\SmartPax";
        private static AppRegistry instance;
        private AppRegistry() { }
        public static AppRegistry getInstance()
        {
            if (instance == null)
            {
                instance = new AppRegistry();
            }
            return instance;
        }

        public string getDataBaseConnection()
        {
            string connection = "";
            RegistryKey key = Registry.CurrentUser.CreateSubKey(registryLocation);

            if (key.GetValue("ActiveConnection") == null)
            {
                key.SetValue("ActiveConnection", @"Data Source=197.242.146.71;Initial Catalog=Smartpax;Integrated Security=True");
            }

            connection = key.GetValue("ActiveConnection").ToString();
            
            key.Close();

            return connection;
        }

        public void setDataBaseConnection(string connectionstring)
        {
            RegistryKey key = Registry.CurrentUser.CreateSubKey(registryLocation);

            key.SetValue("ActiveConnection", connectionstring);

            key.Close();
        }

        public string getcarrier()
        {
            string carrier = "";
            RegistryKey key = Registry.CurrentUser.CreateSubKey(registryLocation);

            if (key.GetValue("ActiveCarrier") == null)
            {
                carrier = "";
            }

            carrier = key.GetValue("ActiveCarrier").ToString();

            key.Close();

            return carrier;
        }
        
        public void setCarrier(string carrier)
        {
            RegistryKey key = Registry.CurrentUser.CreateSubKey(registryLocation);

            key.SetValue("ActiveCarrier", carrier);

            key.Close();
        }
    }
}
