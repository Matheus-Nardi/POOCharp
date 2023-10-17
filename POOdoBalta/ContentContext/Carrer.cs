using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOdoBalta.ContentContext
{
    public class Carrer : Content
    {
        public Carrer(string title, string url) : base(title, url)
        {
            Itens = new List<CarrerItem>();
        }
        public IList<CarrerItem> Itens { get; set; }
        public int TotalCourses => Itens.Count;
        
    }

    

}
