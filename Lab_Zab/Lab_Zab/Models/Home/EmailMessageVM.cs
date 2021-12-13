using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab_Zab.Models.Home
{
    public class EmailMessageVM
    {
        public string EmailTo { get; set; }
        public string MessageBody { get; set; }
        public string Subject { get; set; }
    }
}
