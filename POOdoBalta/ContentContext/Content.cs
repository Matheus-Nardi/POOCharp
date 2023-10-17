using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOdoBalta.ContentContext
{
    public abstract class Content
    {
        public Content(string title , string url)
        {
            Id = Guid.NewGuid();
            Title = title;
            Url = url;
        }
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
    }
}
