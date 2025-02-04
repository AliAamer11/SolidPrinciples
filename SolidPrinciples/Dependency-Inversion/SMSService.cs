using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Inversion
{
    internal class SMSService : IMessageService
    {
        public string PhoneNumber { get; set; }
        public void Send()
        {
            Console.WriteLine($"send sms text to {PhoneNumber}");
        }
    }
}
