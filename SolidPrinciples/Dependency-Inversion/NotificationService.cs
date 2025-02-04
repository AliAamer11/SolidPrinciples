using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Inversion
{
    internal class NotificationService
    {
        private readonly List<IMessageService> _messageService;
        public NotificationService(List<IMessageService> messageServices)
        {
            _messageService = messageServices;
        }

        public void Notify()
        {
            foreach (var service in _messageService)
            {
                service.Send();
            }
        }
    }
}
