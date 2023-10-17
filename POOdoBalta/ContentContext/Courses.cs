using POOdoBalta.ContentContext.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOdoBalta.ContentContext
{
    public class Courses : Content
    {
        public Courses(string title , string url) : base(title , url)
        {
            Modules = new List<Module>(); //Garantido que ao acessar modules ele não esteja nulo
        }
        public string Tag { get; set; }
        public IList<Module> Modules { get; set; }  //Uma interface 
        public int DurationInMinutes { get; set; }
        public EContentLevel Level { get; set; }
    }

    

    


}
