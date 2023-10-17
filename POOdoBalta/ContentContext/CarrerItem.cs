using POOdoBalta.NotificationContext;
using POOdoBalta.SharedContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOdoBalta.ContentContext
{
    public class CarrerItem : Base
    {
        public CarrerItem(int order, string title, string description, Courses course)
        {
            Order = order;
            Title = title;
            Description = description;
            Course = course;
            if (course == null)
                AddNotification(new Notification("Curse" , "Curso inválido"));
            
        }

        public int Order { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public Courses Course { get; set; }

    }
}
