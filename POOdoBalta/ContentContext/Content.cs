using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POOdoBalta.SharedContext;

namespace POOdoBalta.ContentContext
{
    public abstract class Content : Base
    {
        public Content(string title , string url)
        {
            
            Title = title;
            Url = url;
        }
        
        public string Title { get; set; }
        public string Url { get; set; }
    }
}
