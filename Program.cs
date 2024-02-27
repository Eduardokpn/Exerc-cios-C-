using System;

namespace testesAula01
{
    
    class Testes
    {
            static void Main(string[] args) 
            {
                detalharData();

            }

            public static void detalharData()
            {
                Console.WriteLine("Digite uma data: ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                string frase1 = string.Format("Dia da semana: {0:dddd}, Mês: {0:MMMM}, São: {1:HH:mm}", date, DateTime.Now);
                string frase2 = string.Format("Dia da semana: {0:dddd}, Mês: {0:MMMM}", date);

                if(date.DayOfWeek == DayOfWeek.Sunday)
                Console.WriteLine(frase1);

                else
                Console.WriteLine(frase2);

                
    





                

            }



    }


}
