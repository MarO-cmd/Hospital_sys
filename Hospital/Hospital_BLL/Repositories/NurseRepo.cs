using Hospital_BLL.Servises;
using Hospital_DAL.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_BLL.Repositories
{
    public class NurseRepo : IHumanCRUD<Nurse>, ISorting<Nurse> , ISortNurse
    {
       static List<Nurse> Nurses = new List<Nurse>();

        public static int No_Nurses()
        {
            return Nurses.Count();
        }
        public static decimal All_salary()
        {
            return Nurse.All_Salary;
        }

        #region CRUD OP
        void InsertData(Nurse nurse)
        {
            //ID
            Console.Write("Enter The Id : ");
            nurse.Id = Console.ReadLine();
            //Name
            Console.Write("Enter Name : ");
            nurse.Name = Console.ReadLine();
            //Age
            Console.Write("Enter the Age : ");
            nurse.Age = int.Parse(Console.ReadLine());
            //address
            Console.Write("Enter the adress : ");
            nurse.Address = Console.ReadLine();
            //Salary
            Console.Write("Enter the salary : ");
            nurse.Salary = decimal.Parse(Console.ReadLine());
            //WardId
            nurse.ward = new Ward(); // Definition of the ward => Allocation in the memory
            Console.Write("Enter Ward Id : ");
            nurse.ward.Id = Console.ReadLine();
            //WardName
            Console.Write("Enter Ward Name : ");
            nurse.ward.Name = Console.ReadLine();
        }

        public void Add()
        {
            var nurse = new Nurse();

            InsertData(nurse);
            Nurse.All_Salary += nurse.Salary;   //money

            ////ID
            //Console.Write("Enter The Id : ");
            //nurse.Id = Console.ReadLine();
            ////Name
            //Console.Write("Enter Name : ");
            //nurse.Name = Console.ReadLine();
            ////Age
            //Console.Write("Enter the Age : ");
            //nurse.Age = int.Parse(Console.ReadLine());
            ////address
            //Console.Write("Enter the adress : ");
            //nurse.Address = Console.ReadLine();
            ////Salary
            //Console.Write("Enter the salary : ");
            //nurse.Salary = decimal.Parse(Console.ReadLine());
            //Nurse.All_Salary += nurse.Salary;
            ////WardId
            //nurse.ward = new Ward(); // Definition of the ward => Allocation in the memory
            //Console.Write("Enter Ward Id : ");
            //nurse.ward.Id = Console.ReadLine();
            ////WardName
            //Console.Write("Enter Ward Name : ");
            //nurse.ward.Name = Console.ReadLine();

            Nurses.Add(nurse);
            Console.Write("Nurse Added..");
            Thread.Sleep(1500);
        }

        public void Delete(string Id)
        {
            if (Nurses.Count == 0)
            {
                throw new Exception("there are no Nurses");
            }
            else
            {
                bool flag = false;
                var delnurse = Nurses.Where(item => item.Id == Id).ToList();
                if (delnurse.Count != 0)
                {
                    Nurse.All_Salary -= delnurse[0].Salary;
                    Nurses.Remove(delnurse[0]);
                    flag = true;

                }

                if (flag)
                {
                    Console.WriteLine("Nurse Deleted..");
                    Thread.Sleep(1500);
                }
                else
                {
                    Console.WriteLine("The Nurse Not Found !");
                    Thread.Sleep(1500);
                }
            }
        }

        public List<Nurse> GetAll()
        {
            if (Nurses.Count == 0)
            {
                throw new Exception("there are no Nurses");
            }
            else
            {
                return Nurses;
            }
        }

        public Nurse GetById(string Id)
        {
            if (Nurses.Count == 0)
            {
                throw new Exception("there are no Nurses");
            }
            else
            {
                bool flag = false;
                var FoundNrs = Nurses.Where(item => item.Id == Id).ToList();
                if (FoundNrs.Count != 0)
                    return FoundNrs[0];
                else
                    throw new Exception("Nurse Not Found");
            }
        }

        public void Update(string Id)
        {
            if (Nurses.Count == 0)
            {
                throw new Exception("there are no Doctors");
            }
            else
            {
                bool flag = false;

                var UpNurse = Nurses.Where(item => item.Id == Id).ToList();
                if (UpNurse.Count != 0)
                {

                    //Name
                    Console.Write("Enter Name : ");
                    UpNurse[0].Name = Console.ReadLine();
                    //Age
                    Console.Write("Enter the Age : ");
                    UpNurse[0].Age = int.Parse(Console.ReadLine());
                    //address
                    Console.Write("Enter the adress : ");
                    UpNurse[0].Address = Console.ReadLine();
                    //Salary
                    Nurse.All_Salary -= UpNurse[0].Salary; //reset the salary
                    Console.Write("Enter the salary : ");
                    UpNurse[0].Salary = decimal.Parse(Console.ReadLine());
                    //WardId
                    UpNurse[0].ward = new Ward(); // Definition of the ward => Allocation in the memory
                    Console.Write("Enter Ward Id : ");
                    UpNurse[0].ward.Id = Console.ReadLine();
                    //WardName
                    Console.Write("Enter Ward Name : ");
                    UpNurse[0].ward.Name = Console.ReadLine();


                    Nurse.All_Salary += Nurses[0].Salary;

                    flag = true;


                }

                if (flag)
                    Console.WriteLine("Nurse Updated..");
                else
                    Console.WriteLine("The Nurse Not Found !");
            }

        }

        #endregion


        #region Sorting
        public static List<Nurse> SortBy_Id()
        {
            if (Nurses.Count == 0)
                throw new Exception("There is no Nureses");
            else
                return Nurses.OrderBy(N => N.Id).ThenBy(N => N.Age).ToList();
        }

        public static List<Nurse> SortBy_Age()
        {
            if (Nurses.Count == 0)
                throw new Exception("There is no Nureses");
            else
                return Nurses.OrderBy(N => N.Age).ThenBy(N => N.Name).ToList();
        }

        public static List<Nurse> SortBy_Name()
        {
            if (Nurses.Count == 0)
                throw new Exception("There is no Nureses");
            else
                return Nurses.OrderBy(N => N.Name).ThenBy(N => N.Age).ToList();
        }

        public static List<Nurse> SortBy_Salary()
        {
            if (Nurses.Count == 0)
                throw new Exception("There is no Nureses");
            else
                return Nurses.OrderBy(N => N.Salary).ThenBy(N => N.Age).ToList();
        }
        public static List<Nurse> SortBy_SalaryDesc()
        {
            if (Nurses.Count == 0)
                throw new Exception("There is no Nureses");
            else
                return Nurses.OrderByDescending(N => N.Salary).ThenBy(N => N.Age).ToList();
        }

        public static List<Nurse> SortBy_Adress()
        {
            if (Nurses.Count == 0)
                throw new Exception("There is no Nureses");
            else
                return Nurses.OrderBy(N => N.Address).ThenBy(N => N.Age).ToList();
        } 
        #endregion

    }

       
}

