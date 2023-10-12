namespace Genericos1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var pessoa = new Pessoa();
            var pay = new Pagamento();
            //Declaração de um tipo génerico
            var context = new DataContext<Pessoa , Pagamento ,Assinatura>();
            context.Save(pessoa);
            context.Save(pay);
        }

        public class DataContext<Pe , Pa , As>  //Torna-se um tipo 
             //Limitando os tipos génericos , podendo implementar tanto uma classe como Interfaces
             where Pe : Pessoa 
             where Pa : Pagamento
             where As : Assinatura
        {
             
            //Caso eu queira salvar tanto pessoa , como pagamento ou assinatura eu torno a classe génerica
            public void Save(Pe entidade)
            {

            }
            public void Save(Pa entidade)
            {

            }
            public void Save(As entidade)
            {

            }
        }
        
        public class Pessoa { }
        public class Pagamento { }
        public class Assinatura { }
    }
}