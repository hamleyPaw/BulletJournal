using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace HamleyPaw.BulletJournal.Services
{
    public class ConnectionProvider : IConnectionProvider
    {
        private string _CurrentConnectionString;
        public ConnectionProvider(string currentConnectionString)
        {
            _CurrentConnectionString = currentConnectionString;
        }

        public string GetCurrentConnectionString()
        {
            return _CurrentConnectionString;
        }
    }
}
