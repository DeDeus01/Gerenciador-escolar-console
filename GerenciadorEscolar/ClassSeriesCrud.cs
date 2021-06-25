using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorEscolar
{
    class ClassSeriesCrud
    {
        ClassSeries serie;

        public List<ClassSeries> series = new List<ClassSeries>();

        public void createNewClassSerie()
        {
            serie = new ClassSeries();

            Console.WriteLine("\n\n CADASTRO DE CLASSE \n Novo \n\n");

            Console.Write(" Nome da classe: ");
            serie.className = Console.ReadLine();

            Console.WriteLine("\n SALVANDO OS DADOS... \n");

            series.Add(serie);

            showClassSerie(serie);

        }

        public void showClassSerie(ClassSeries serie)
        {
            Console.WriteLine(" DADOS DA CLASSE \n\n");

            Console.WriteLine(" Nome da classe: " + serie.className);

        }

        public void listAllClassSeries()
        {
            Console.WriteLine(" LISTANDO TODAS AS CLASSES CADASTRADAS! \n\n");

            if (series.Count() == 0)
            {
                Console.WriteLine("Não há classes ainda cadastradas!\n");
            }
            else
            {
                Console.WriteLine("{0,-20} {1,5}\n", "", "NOME");

                foreach (var ser in series)
                {
                    Console.WriteLine("{0,-20} {1,5:N1}", "--", ser.className);
                }
            }
        }
    }
}
