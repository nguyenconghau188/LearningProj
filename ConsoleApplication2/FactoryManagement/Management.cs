using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryManagement
{
    public static class Management
    {
        public static ArrayList listPeople = new ArrayList();

        public static void Manage()
        {
            string continute = "n";
            do
            {
                string choose;
                Console.WriteLine("*======================================================*");
                Console.WriteLine("*                 FACTORY MANAGEMENT                   *");
                Console.WriteLine("*======================================================*");
                Console.WriteLine("Select Menu: ");
                Console.WriteLine("     1. Add new Employee.");
                Console.WriteLine("     2. Print Employees.");
                Console.WriteLine("     3. Find Employees");
                Console.WriteLine("     4. Delete Employees");
                Console.WriteLine("     5. Edit Employees");
                Console.WriteLine("\n");
                Console.WriteLine("Enter service you want use: ");
                choose = Console.ReadLine();
                int choosen;
                while (!int.TryParse(choose, out choosen) || choosen>5 || choosen <1)
                {
                    Console.WriteLine("Please re-enter service you want use: ");
                    choose = Console.ReadLine();
                }
                    switch (choosen)
                    {
                        case 1: AddPeople(); break;
                        case 2: PrintEmployees(); break;
                        case 3: FindEmployees(); break;
                        case 4: DeleteEmployees(); break;
                        case 5: EditEmployee(); break;
                    }
                Console.WriteLine("*=========================================*");
                Console.WriteLine("Do you want continute use program? (y/n)");
                continute = Console.ReadLine();
            }
            while (continute == "y" || continute == "Y");
        }

        private static void DeleteEmployees()
        {
            throw new NotImplementedException();
        }

        private static void EditEmployee()
        {
            throw new NotImplementedException();
        }

        private static void FindEmployees()
        {
            Console.WriteLine("Please enter mode find? (1) or (2)");
            Console.WriteLine("1 - Find by name \n 2 - Find by position");
            Console.WriteLine("=> Your choose: ");
            string strChoose = Console.ReadLine();
            int choose;
            while (!int.TryParse(strChoose, out choose) || choose < 1 || choose > 2)
            {
                Console.WriteLine("Please re-enter your choose: ");
                strChoose = Console.ReadLine();
            }
            if (choose == 1)
            {
                FindByName();
            }
            else
            {
                FindByPosition();
            }
        }

        private static void FindByPosition()
        {
            PrintBreakSection();
            Console.WriteLine("Enter position you want to find? (1), (2) or (3)");
            Console.WriteLine("1 - Find Engineer | 2 - Find Staff | 3 - Find Worker");
            Console.WriteLine("=> Your choose: ");
            string strChoose = Console.ReadLine();
            int choose;
            while (!int.TryParse(strChoose, out choose) || choose < 1 || choose > 3)
            {
                Console.WriteLine("Please re-enter your choose: ");
                strChoose = Console.ReadLine();
            }

        }

        private static void PrintBreakSection()
        {
            for (int i = 0; i < 20; i++)
                Console.Write("=");
            Console.Write("\n");
        }

        private static void FindByName()
        {
            throw new NotImplementedException();
        }

        private static void PrintEmployees()
        {
            if (listPeople.Count >0)
            {
                foreach (People employees in listPeople)
                {
                    Console.WriteLine(employees.ToString());             
                }
            }
            else
            {
                Console.WriteLine("No Employees.");
            }
        }

        public static void AddPeople()
        {
            int choose;
            Console.WriteLine("Please enter number you want to input: ");
            Console.WriteLine("1. Staff | 2. Engineer | 3. Worker");
            choose = int.Parse(Console.ReadLine());

            switch (choose)
            {
                case 1: StaffInput(); break;
                case 2: EngineerInput(); break;
                case 3: WorkerInput(); break;
            }
        }

        private static void WorkerInput()
        {
            Worker worker = new Worker();
            Console.WriteLine("=== Add new Worker ===");
            worker.SetPostion("W");
            worker.name = Entername();
            worker.dayOfBirth = EnterDateOfBirth();
            worker.SetGender(EnterGender());
            worker.address = EnterAddress();
            worker.rankWorker = EnterRank();
            listPeople.Add(worker);
        }


        private static void EngineerInput()
        {
            Engineer engineer = new Engineer();
            Console.WriteLine("=== Add new Engineer ===");
            engineer.SetPostion("E");
            engineer.name = Entername();
            engineer.dayOfBirth = EnterDateOfBirth();
            engineer.SetGender(EnterGender());
            engineer.address = EnterAddress();
            engineer.specialize = EnterSpecialize();
            listPeople.Add(engineer);
        }

        private static string EnterSpecialize()
        {
            Console.WriteLine("Enter Specialize: ");
            return Console.ReadLine();
        }

        private static void StaffInput()
        {
            Staff staff = new Staff();
            Console.WriteLine("=== Add new Staff ===");
            staff.SetPostion("S");
            staff.name = Entername();
            staff.dayOfBirth = EnterDateOfBirth();
            staff.SetGender(EnterGender());
            staff.address = EnterAddress();
            staff.job = EnterStaffJob();
            listPeople.Add(staff);
        }

        private static string EnterStaffJob()
        {
            Console.WriteLine("Enter Staff job: ");
            return Console.ReadLine();
        }

        private static string Entername()
        {
            Console.WriteLine("Enter Name: ");
            return Console.ReadLine();
        }

        private static DateTime EnterDateOfBirth()
        {
            //string  date = Console.ReadLine();
            //DateTime dOfBirth = Convert.ToDateTime(date);
            Console.WriteLine("Enter day of birth (mm/dd/yyyy): ");
            DateTime dateOfBirth;
            while (!DateTime.TryParse(Console.ReadLine(), out dateOfBirth))
            {
                Console.WriteLine("Wrong datetime format, please re-enter date of birth: ");
            }
            return dateOfBirth;
        }

        private static string EnterGender()
        {
            Console.WriteLine("Enter gender (M (male)/F (female)) ");
            string gender = Console.ReadLine();
            while (gender != "M" && gender != "F")
            {
                Console.WriteLine("Wrong gender format, please re-enter gender (M (male)/F (female)): ");
                gender = Console.ReadLine();
            }
            return gender;
        }

        private static string EnterAddress()
        {
            Console.WriteLine("Enter Address: ");
            return Console.ReadLine();
        }

        private static int EnterRank()
        {
            Console.WriteLine("Enter Worker Rank (x/7): ");
            int rank = int.Parse(Console.ReadLine());
            while ((rank < 1 || rank > 7))
            {
                Console.WriteLine("Enter wrong rank, please re-enter (x/7): ");
                rank = int.Parse(Console.ReadLine());
            }
            return rank;
        }
    }
}
