using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Inversion;

internal class EmailService : IMessageService
{
    public string EmailAddress { get; set; }
    public void Send()
    {
        Console.WriteLine($"send email to {EmailAddress}");
    }
}
