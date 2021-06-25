using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorEscolar
{
    class TeacherCrud
    {
        Teacher teacher;

        public List<Teacher> teachers = new List<Teacher>();

        //metodo que cria um novo professor
        public void createNewTeacher()
        {
            teacher = new Teacher();

            Console.WriteLine("\n\n CADASTRO DE PROFESSOR \n Novo\n\n");

            Console.Write(" Nome: ");
            teacher.name = Console.ReadLine();

            Console.Write(" Telefone: ");
            teacher.phone = Console.ReadLine();

            Console.Write(" Email: ");
            teacher.email = Console.ReadLine();

            Console.Write(" Endereço: ");
            teacher.address = Console.ReadLine();

            Console.Write(" Cidade: ");
            teacher.city = Console.ReadLine();

            Console.Write(" Estado: ");
            teacher.state = Console.ReadLine();

            Console.Write(" País: ");
            teacher.country = Console.ReadLine();

            Console.WriteLine("\n SALVANDO OS DADOS...\n");

            //adiciona um professor na lista geral de professores
            teachers.Add(teacher);

            //exibe as informações cadastradas do professor
            showTeacher(teacher);
        }

        //metodo que exibe as informações de um professor
        public void showTeacher(Teacher teacher)
        {
            Console.WriteLine(" DADOS DO PROFESSOR \n");

            Console.WriteLine(" Nome: " + teacher.name);
            Console.WriteLine(" Telefone: " + teacher.phone);
            Console.WriteLine(" Email: " + teacher.email);
            Console.WriteLine(" Endereço: " + teacher.address);
            Console.WriteLine(" Cidade: " + teacher.city);
            Console.WriteLine(" Estado: " + teacher.state);
            Console.WriteLine(" País: " + teacher.country);
        }

        //metodo que exibe uma lista com professores
        public void listAllTeachers()
        {
            Console.WriteLine("\n LISTA DE TODOS OS PROFESSORES CADASTRADOS \n\n");

            if (teachers.Count() == 0)
            {
                Console.WriteLine("Não há nenhum professor ainda cadastrado! \n");
            }
            else
            {
                Console.WriteLine("{0,-20} {1,5}\n", "NOME", "EMAIL");

                foreach (var td in teachers)
                {
                    Console.WriteLine("{0,-20} {1,5:N1}", td.name, td.email);
                }
            }
        }
    }
}
