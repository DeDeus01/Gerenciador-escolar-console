using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorEscolar
{
    class StudentCrud
    {
        Student student;

        public List<Student> students = new List<Student>();

        //metodo que cria um novo estudante
        public void createNewStudent()
        {
            student = new Student();

            Console.WriteLine("\n\n CADASTRO DE ESTUDANTE \n Novo\n\n");

            Console.Write(" RA: ");
            student.ra = Console.ReadLine();

            Console.Write(" Nome: ");
            student.name = Console.ReadLine();

            Console.Write(" Telefone: ");
            student.phone = Console.ReadLine();

            Console.Write(" Email: ");
            student.email = Console.ReadLine();

            Console.Write(" Endereço: ");
            student.address = Console.ReadLine();

            Console.Write(" Cidade: ");
            student.city = Console.ReadLine();

            Console.Write(" Estado: ");
            student.state = Console.ReadLine();

            Console.Write(" País: ");
            student.country = Console.ReadLine();

            Console.WriteLine("\n SALVANDO OS DADOS...\n");

            //adiciona um estudante na lista geral de estudantes.
            students.Add(student);

            //exibe as informações do estudante.
            showStudent(student);
        }

        //metodo que exibe as informações de um estudante
        public void showStudent(Student student)
        {
            Console.WriteLine(" DADOS DO ESTUDANTE \n");

            Console.WriteLine(" RA: " + student.ra);
            Console.WriteLine(" Nome: " + student.name);
            Console.WriteLine(" Telefone: " + student.phone);
            Console.WriteLine(" Email: " + student.email);
            Console.WriteLine(" Endereço: " + student.address);
            Console.WriteLine(" Cidade: " + student.city);
            Console.WriteLine(" Estado: " + student.state);
            Console.WriteLine(" País: " + student.country);
        }

        //metodo que exibe uma lista com estudantes
        public void listAllStudents()
        {
            Console.WriteLine("\n LISTA DE TODOS OS ESTUDANTES CADASTRADOS \n\n");

            if (students.Count == 0)
            {
                Console.WriteLine(" Não há nenhum estudante ainda cadastrado!");
            }
            else
            {
                Console.WriteLine("{0,-20} {1,5}\n", "RA", "NOME");

                foreach (var std in students)
                {
                    Console.WriteLine("{0,-20} {1,5:N1}", std.ra, std.name);
                }
            }
        }
    }
}
