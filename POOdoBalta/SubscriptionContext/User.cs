using POOdoBalta.SharedContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOdoBalta.SubscriptionContext
{
    public class User : Base
    {
        public string Username { get; set; }
        public string Passowrd { get; set; }
    }
}
