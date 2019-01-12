using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Services.Abstract
{
    public interface IEmailService
    {
        Task SendPlainEmail(string to, string title, string text);
    }
}
