namespace Dependency_Inversion
{
    public class Program
    {
        public static void Main(string[] args)
        {

            var customers = Repository.Customers;
            foreach (var customer in customers)
            {
                var messageServices = new List<IMessageService>()
                 {
                     new EmailService {EmailAddress  =  customer .EmailAddress},
                     new SMSService {PhoneNumber = customer.PhoneNumber }
                 };
                NotificationService notificationService = new NotificationService(messageServices);
                notificationService.Notify();
            }

            Console.ReadKey();
        }
    }
}
