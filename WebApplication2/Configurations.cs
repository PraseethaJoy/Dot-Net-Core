using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2
{
    public class Configurations
    {
        public Address Address { get; set; }
    }
    public class Address
    {
        public string DigitalEOFUI { get; set; }

        public string JournalConfigurationAPI { get; set; }

        public string JournalUsersAPI { get; set; }

        public string AccessDeniedPage { get; set; }
    }

}
