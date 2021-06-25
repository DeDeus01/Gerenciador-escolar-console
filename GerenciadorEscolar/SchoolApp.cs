using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorEscolar
{
    class SchoolApp
    {
        StudentCrud student1;
        TeacherCrud teacher1;
        SubjectCrud subject1;
        ClassSeriesCrud cls1;

        //componente de print para definir o estudante
        public void interfaceComponentStudent()
        {
            int option2;

            Console.WriteLine("\n 1 - CADASTRAR NOVO ESTUDANTE");
            Console.WriteLine(" 2 - LISTAR TODOS OS ESTUDANTES");
            Console.Write("\n => ");

            student1 = new StudentCrud();

            option2 = int.Parse(Console.ReadLine());

            switch (option2)
            {
                case 1:
                    student1.createNewStudent();
                    break;
                case 2:
                    student1.listAllStudents();
                    break;
                default:
                    Console.WriteLine("\n Valor inválido!");
                    break;
            }
        }

        //componente de print para definir o professor
        public void interfaceComponentTeacher()
        {
            int option2;

            Console.WriteLine(" 1 - CADASTRAR NOVO PROFESSOR");
            Console.WriteLine(" 2 - LISTAR TODOS OS PROFESSORES");
            Console.Write("\n => ");

            teacher1 = new TeacherCrud();

            option2 = int.Parse(Console.ReadLine());

            switch (option2)
            {
                case 1:
                    teacher1.createNewTeacher();
                    break;
                case 2:
                    teacher1.listAllTeachers();
                    break;
                default:
                    Console.WriteLine("\n Valor inválido!");
                    break;
            }
        }

        //componente de print para definir a disciplina
        public void interfaceComponentSubject()
        {
            int option2;

            Console.WriteLine(" 1 - CADASTRAR NOVA DISCIPLINA");
            Console.WriteLine(" 2 - LISTAR TODAS AS DISCIPLINAS");
            Console.Write("\n => ");

            subject1 = new SubjectCrud();

            option2 = int.Parse(Console.ReadLine());

            switch (option2)
            {
                case 1:
                    subject1.createNewSubject();
                    break;
                case 2:
                    subject1.listAllSubjects();
                    break;
                default:
                    Console.WriteLine("\n Valor inválido!");
                    break;
            }
        }


        //componente de print para definir as classes
        public void interfaceComponentClassSerie()
        {
            int option2;

            Console.WriteLine(" 1 - CADASTRAR NOVA CLASSES");
            Console.WriteLine(" 2 - LISTAR TODAS AS CLASSES");
            Console.Write("\n => ");

            cls1 = new ClassSeriesCrud();

            option2 = int.Parse(Console.ReadLine());

            switch (option2)
            {
                case 1:
                    cls1.createNewClassSerie();
                    break;
                case 2:
                    cls1.listAllClassSeries();
                    break;
                default:
                    Console.WriteLine("\n Valor inválido!");
                    break;
            }
        }

        //Metodo de gerenciamento geral do sistema e relatorios(em construção)
        public void interfaceComponentInfoSettings()
        {
            Console.WriteLine("ALUNOS E CLASSES");
            Console.WriteLine("PROFESSORES E DISCIPLINAS");
            Console.WriteLine("DISCIPLINAS E CLASSES");
            Console.Write("\n => ");

            int option2;
            option2 = int.Parse(Console.ReadLine());

            switch (option2)
            {
                case 1:
                    //
                    break;
                case 2:
                    //
                    break;
                case 3:
                    //
                    break;
                default:
                    Console.WriteLine("\n Valor inválido!");
                    break;
            }
        }

        //Metodo para criar um menu de opções para navegação que chama componentes.
        public void createInterfaceSimulation()
        {
            int option;
            bool running = true;

            while (running)
            {
                Console.WriteLine(" BEM VINDO AO SISTEMA DE GERENCIAMENTO DA ESCOLA\n");
                Console.WriteLine(" 1 - ESTUDANTES");
                Console.WriteLine(" 2 - PROFESSORES");
                Console.WriteLine(" 3 - TURMAS");
                Console.WriteLine(" 4 - DISCIPLINAS");
                Console.WriteLine(" 5 - INFORMAÇÕES GERAIS");
                Console.WriteLine("\n 6 - SAIR");

                Console.Write("\n => ");
                option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        interfaceComponentStudent();
                        break;
                    case 2:
                        interfaceComponentTeacher();
                        break;
                    case 3:
                        interfaceComponentClassSerie();
                        break;
                    case 4:
                        interfaceComponentSubject();
                        break;
                    case 5:
                        //interfaceComponentInfoSettings();
                        break;
                    case 6:
                        running = false;
                        break;
                    default:
                        Console.WriteLine("\n Valor inválido!");
                        break;
                }

            }
        }

        public void run()
        {
            createInterfaceSimulation();
        }
    }

}
