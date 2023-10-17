using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOdoBalta.NotificationContext
{
    public abstract class Notifiable
    {
        public List<Notification> Notifications { get; set; }
        public Notifiable()
        {
            Notifications = new List<Notification>();
        }

        public void AddNotification(Notification notification)
        {
            Notifications.Add(notification);
        }
        public void AddNotifications(IEnumerable<Notification> notification)
        {
            Notifications.AddRange(notification);
        }

        public bool IsInalid => Notifications.Any();
    }
}
