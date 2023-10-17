using POOdoBalta.NotificationContext;
using POOdoBalta.SharedContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOdoBalta.SubscriptionContext
{
    public class Student : Base
    {
        public Student()
        {
            Subscriptions = new List<Subscription>();
        }
        public User User { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public IList<Subscription> Subscriptions { get; set; }

        public bool IsPremium => Subscriptions.Any(x => !x.IsInctive);
        public void CreateSubscription(Subscription subscription)
        {
            if(IsPremium)
            {
                AddNotification(new Notification("Premium" , "O aluno já tem uma assnatura"));
                return;
            }

            Subscriptions.Add(subscription);
        }
    }
}
