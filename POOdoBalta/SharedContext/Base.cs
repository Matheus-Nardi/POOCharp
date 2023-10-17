using POOdoBalta.NotificationContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOdoBalta.SharedContext
{
    public abstract class Base : Notifiable
    {
        public Base()
        {

            Id = Guid.NewGuid();

        }
        public Guid Id { get; set; }
    }
}
