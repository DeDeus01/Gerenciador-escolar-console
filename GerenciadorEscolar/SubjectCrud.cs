using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorEscolar
{
    class SubjectCrud
    {
        Subject subject;

        public List<Subject> subjects = new List<Subject>();

        //metodo que cadastra uma disciplina
        public void createNewSubject()
        {
            subject = new Subject();

            Console.WriteLine("\n\n CADASTRO DE DISCIPLINA \n Novo\n\n");

            Console.Write(" Nome da disciplina: ");
            subject.subjectName = Console.ReadLine();

            Console.WriteLine("\n SALVANDO OS DADOS...\n");

            subjects.Add(subject);

            showSubject(subject);
        }

        //metodo que exibe a disciplina
        public void showSubject(Subject subject)
        {
            Console.WriteLine(" DADOS DA DISCIPLINA \n\n");

            Console.WriteLine(" Nome: " + subject.subjectName);

        }

        //metodo que lista todas as disciplinas cadastradas
        public void listAllSubjects()
        {
            Console.WriteLine(" LISTA DE TODAS AS DISCIPLINAS CADASTRADAS \n\n");

            if (subjects.Count() == 0)
            {
                Console.WriteLine("Não há nenhuma disciplina ainda cadastrada!\n");
            }
            else
            {
                Console.WriteLine("{0,-20} {1,5}\n", "", "NOME");

                foreach (var sub in subjects)
                {
                    Console.WriteLine("{0,-20} {1,5:N1}", "--", sub.subjectName);
                }
            }
        }
    }
}
