using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX2
{
    public class Computer
    {
        private string _name;
        private string _ipAddress;
        private int[] _services;

        //Constructor
        //need to use params to accept more than one service
        public Computer(string name, string ipAddress, params int[] services)
        {
            _name = name;
            _ipAddress = ipAddress;
            _services = services;
        }

        public string Name
        {
            get { return _name; }
          
        }
        public string IpAddress
        {
            get { return _ipAddress; }

        }
        public int[] Services
        {
            get { return _services; }
         
        }
    }
}
