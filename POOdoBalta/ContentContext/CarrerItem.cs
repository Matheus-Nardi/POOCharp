using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOdoBalta.ContentContext
{
    public class CarrerItem
    {
        public CarrerItem(int order, string title, string description, Courses course)
        {
            Order = order;
            Title = title;
            Description = description;
            Course = course;
        }

        public int Order { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public Courses Course { get; set; }

    }
}
