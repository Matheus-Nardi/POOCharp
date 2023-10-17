using POOdoBalta.ContentContext;
using POOdoBalta.SubscriptionContext;

namespace POOdoBalta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var artciles = new List<Article>();
            artciles.Add(new Article("Entendendo o CSharp" , "fundamentos-csharp"));
            artciles.Add(new Article("Entendendo a POO" , "POO-csharp"));
            artciles.Add(new Article("Entendendo SQL" , "banco-de-dados-SQL"));

            foreach (var item in artciles)
            {
                Console.WriteLine(item.Id);
                Console.WriteLine(item.Title);
                Console.WriteLine(item.Url);
                Console.WriteLine("-------------------------");
            }

            var cursos = new List<Courses>();
            var courseCsharp = new Courses("Fundamentos do C#" , "fundamentos-csharp");
            var courseApsNet = new Courses("Fundamentos do ASPNET" , "fundamentos-ASPNET");
            var coursePOO = new Courses("Fundamentos da POO" , "fundamentos-POO");
            cursos.Add(courseCsharp);
            cursos.Add(courseApsNet);
            cursos.Add(coursePOO);

            var carres = new List<Carrer>();

            var carrerDotNet = new Carrer("Dominando o .NET" , "dominando-dotnet");
            var carrerPOO = new CarrerItem(3 ,"Comece POO aqui" , "" , null);
            var carrerCsharp = new CarrerItem(1 ,"Comece por aqui" , "" , courseCsharp);
            var carrerAspNet = new CarrerItem(2 ,"Comece AspNet por aqui" , "" , courseApsNet);
            carrerDotNet.Itens.Add(carrerCsharp);
            carrerDotNet.Itens.Add(carrerPOO);
            carrerDotNet.Itens.Add(carrerAspNet);
            carres.Add(carrerDotNet);
            

             foreach(var career in carres )
             {
                Console.WriteLine(career.Title);
                foreach(var item in career.Itens.OrderBy(x=>x.Order))
                {
                    Console.WriteLine($"{item.Order} - {item.Title} ");
                    Console.WriteLine(item.Course?.Title);
                    Console.WriteLine(item.Course?.Level);
                    foreach(var notification in item.Notifications)
                    {
                        Console.WriteLine($"{notification.Property} - {notification.Message}");
                    }
                }

                var paypalSubscription = new PayPalSubscription();
                var student = new Student();
                student.CreateSubscription(paypalSubscription);
             }


            Console.ReadLine();
        }
    }
}