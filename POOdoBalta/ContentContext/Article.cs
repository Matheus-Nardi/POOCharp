using POOdoBalta.NotificationContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace POOdoBalta.ContentContext
{
    public class Article : Content 
    {
        public Article(string title , string url) : base(title , url) { }
      
    }
}
