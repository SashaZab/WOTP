using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Email_service
{
    public interface IEmailSender
    {
        Task SendMessage(string emailTo, string messageBody, string messageSubject);
    }
}
