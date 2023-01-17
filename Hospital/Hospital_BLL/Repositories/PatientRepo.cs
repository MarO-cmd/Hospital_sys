using Hospital_BLL.Servises;
using Hospital_DAL.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Hospital_BLL.Repositories
{
    public class PatientRepo : IHumanCRUD<Patient> , ISorting<Patient> , ISortPatient
    {
        static List<Patient> Patients = new List<Patient>();
       
        const int MoneyPerDay = 500;
        int days;


        public int Hospital_Days(string Entery_date, string Exit_date)
        {
           
            string[] Endate = Entery_date.Split('/');
            string[] Exdate = Exit_date.Split('/');
            int enday = int.Parse(Endate[0]);
            int exday = int.Parse(Exdate[0]);
            int enmonth = int.Parse(Endate[1]);
            int exmonth = int.Parse(Exdate[1]);
            int enyear = int.Parse(Endate[2]);
            int exyear = int.Parse(Exdate[2]);

            DateTime endate = new DateTime(enyear,enmonth,enday);
            DateTime exdate = new DateTime(exyear,exmonth,exday);

            TimeSpan Days = exdate - endate;
            days = (int) Days.TotalDays;          
            return days;

        }
        public decimal Payment(string Entery_date, string Exit_date)
        {
            int res = MoneyPerDay * days;
            Patient.All_Payments += res;
            return res;
        }
        public static int No_patients()
        {
            return Patients.Count();
        }
        public static decimal All_pay()
        {
            return Patient.All_Payments;
        }

        #region CRUD

        void InsertData(Patient patient)
        {
            //ID
            Console.Write("Enter The Id : ");
            patient.Id = Console.ReadLine();
            //Name
            Console.Write("Enter Name : ");
            patient.Name = Console.ReadLine();
            //Age
            Console.Write("Enter Age : ");
            patient.Age = int.Parse(Console.ReadLine());
            //Illness
            Console.Write("Enter Illness : ");
            patient.Illness = Console.ReadLine();
            //EnteryDate
            Console.Write("Enter EnteryDate 'D:M:Y' Separated by '/' : ");
            patient.Entery_date = Console.ReadLine().Trim();
            //ExitDate
            Console.Write("Enter ExitDate 'D:M:Y' Separated by '/' : ");
            patient.Exit_date = Console.ReadLine().Trim();
            //WardId
            patient.ward = new Ward(); // Definition of the ward => Allocation in the memory
            Console.Write("Enter Ward Id : ");
            patient.ward.Id = Console.ReadLine();
            //WardName
            Console.Write("Enter Ward Name : ");
            patient.ward.Name = Console.ReadLine();
            //Drug
            Console.Write("How many Drugs does the patient Take : ");
            int n = int.Parse(Console.ReadLine());
            patient.drug = new Drug[n];   // Definition of the Drug => Allocation in the memory

            for (int i = 0; i < n; i++)
            {
                patient.drug[i] = new Drug();
                Console.Write($"Enter the code of druge number {i+1} : ");
                patient.drug[i].Code = Console.ReadLine();
                //DrugName
                Console.Write($"Enter the name of druge number {i + 1} : ");
                patient.drug[i].Name = Console.ReadLine();
                //DrugTime
                Console.Write($"Enter the dosage of druge number {i + 1} : ");
                patient.drug[i].Dosage = Console.ReadLine();
            }

           
        }

        public void Add()
        {
            var patient = new Patient();

            ////ID
            //Console.Write("Enter The Id : ");
            //patient.Id = Console.ReadLine();
            ////Name
            //Console.Write("Enter Name : ");
            //patient.Name = Console.ReadLine();
            ////Age
            //Console.Write("Enter Age : ");
            //patient.Age = int.Parse(Console.ReadLine());
            ////Illness
            //Console.Write("Enter Illness : ");
            //patient.Illness = Console.ReadLine();
            ////EnteryDate
            //Console.Write("Enter EnteryDate 'D:M:Y' Separated by '/' : ");
            //patient.Entery_date = Console.ReadLine();
            ////ExitDate
            //Console.Write("Enter ExitDate 'D:M:Y' Separated by '/' : ");
            //patient.Exit_date = Console.ReadLine();
            ////WardId
            //patient.ward = new Ward(); // Definition of the ward => Allocation in the memory
            //Console.Write("Enter Ward Id : ");
            //patient.ward.Id = Console.ReadLine();
            ////WardName
            //Console.Write("Enter Ward Name : ");
            //patient.ward.Name = Console.ReadLine();
            ////DrugCode
            //patient.drug = new Drug();// Definition of the Drug => Allocation in the memory
            //Console.Write("Enter drug Code : ");
            //patient.drug.Code = Console.ReadLine();
            ////DrugName
            //Console.Write("Enter drug Name : ");
            //patient.drug.Name= Console.ReadLine();
            ////DrugTime
            //Console.Write("Enter drug Dosage : ");
            //patient.drug.Dosage = Console.ReadLine();

            InsertData(patient);

            patient.days = Hospital_Days(patient.Entery_date, patient.Exit_date);
            patient.Payment = Payment(patient.Entery_date, patient.Exit_date);       

            Patients.Add(patient);
            
            Console.Write("Patient Added..");
            Thread.Sleep(1500);
        }

        public void Delete(string Id)
        {
            if (Patients.Count == 0)
            {
                throw new Exception("there are no Patients");
            }
            else
            {
                bool flag = false;
                var delPnt = Patients.Where(item => item.Id == Id).ToList();
                if (delPnt.Count != 0)
                {
                    Patient.All_Payments -= delPnt[0].Payment; //reset payment
                    Patients.Remove(delPnt[0]);
                    flag = true;
                }

                if (flag)
                {
                    Console.WriteLine("Patient Deleted..");
                    Thread.Sleep(1500);
                }
                else
                {
                    Console.WriteLine("The Patient Not Found !");
                    Thread.Sleep(1500);
                }
            }
        }

        public List<Patient> GetAll()
        {
            if (Patients.Count == 0)
            {
                throw new Exception("there are no patients");              
            }
            else
                return Patients;
        }

        public Patient GetById(string Id)
        {
            if (Patients.Count == 0)
            {
                throw new Exception("there are no Patients");
            }
            else
            {
                bool flag = false;
                var FoundPnt = Patients.Where(item => item.Id == Id).ToList();
                if (FoundPnt.Count != 0)               
                    return FoundPnt[0];              
                else               
                    throw new Exception("Patient Not Found");               
            }
        }

        public void Update(string Id)
        {
            if (Patients.Count == 0)
            {
                throw new Exception("there are no Patients");

            }
            else
            {
                bool flag = false;

                var UpPnt = Patients.Where(item => item.Id == Id).ToList();
                if (UpPnt.Count != 0)
                {
                    Console.Write("Enter Name : ");
                    UpPnt[0].Name = Console.ReadLine();

                    Console.Write("Enter Age : ");
                    UpPnt[0].Age = int.Parse(Console.ReadLine());

                    Console.Write("Enter Illness : ");
                    UpPnt[0].Illness = Console.ReadLine();

                    Console.Write("Enter EnteryDate 'D:M:Y' Separated by '/' : ");
                    UpPnt[0].Entery_date = Console.ReadLine();

                    Console.Write("Enter ExitDate 'D:M:Y' Separated by '/' : ");
                    UpPnt[0].Exit_date = Console.ReadLine();

                    UpPnt[0].ward = new Ward(); // Definition of the ward => Allocation in the memory
                    Console.Write("Enter Ward Id : ");
                    UpPnt[0].ward.Id = Console.ReadLine();

                    Console.Write("Enter Ward Name : ");
                    UpPnt[0].ward.Name = Console.ReadLine();

                    Console.Write("How many Drugs does the patient Take : ");
                    int n = int.Parse(Console.ReadLine());
                    UpPnt[0].drug = new Drug[n];   // Definition of the Drug => Allocation in the memory

                    for (int i = 0; i < n; i++)
                    {
                        UpPnt[0].drug[i] = new Drug();
                        Console.Write($"Enter the code of druge number {i + 1} : ");
                        UpPnt[0].drug[i].Code = Console.ReadLine();
                        //DrugName
                        Console.Write($"Enter the name of druge number {i + 1} : ");
                        UpPnt[0].drug[i].Name = Console.ReadLine();
                        //DrugTime
                        Console.Write($"Enter the dosage of druge number {i + 1} : ");
                        UpPnt[0].drug[i].Dosage = Console.ReadLine();
                    }


                  

                    Patient.All_Payments -= UpPnt[0].Payment; //reset payment

                    UpPnt[0].days = Hospital_Days(UpPnt[0].Entery_date, UpPnt[0].Exit_date);
                    UpPnt[0].Payment = Payment(UpPnt[0].Entery_date, UpPnt[0].Exit_date);                  

                    flag = true;
                    
                }
                
                if (flag)
                    Console.WriteLine("Patient Updated..");
                else
                    Console.WriteLine("Not Found The Patient!");
            }
        }

        #endregion

        #region Sorting
       
        public static List<Patient> SortBy_Id()
        {
            if (Patients.Count == 0)
                throw new Exception("there are no Patients");
            else
                return Patients.OrderBy(p => p.Id).ToList();           
        }

        public static List<Patient> SortBy_Age()
        {
            if (Patients.Count == 0)
                throw new Exception("there are no Patients");
            else
                return Patients.OrderBy(p => p.Age).ToList();
        }

        public static List<Patient> SortBy_Name()
        {
            if (Patients.Count == 0)
                throw new Exception("there are no Patients");
            else
                return Patients.OrderBy(p => p.Name).ToList();
        }
        public static List<Patient> SortBy_Days()
        {
            if (Patients.Count == 0)
                throw new Exception("there are no Patients");
            else
                return Patients.OrderBy(p => p.days).ToList();
        }

        public static List<Patient> SortBy_DaysDesc()
        {
            if (Patients.Count == 0)
                throw new Exception("there are no Patients");
            else
                return Patients.OrderByDescending(p => p.days).ToList();
        }

        public static List<Patient> SortBy_Payment()
        {
            if (Patients.Count == 0)
                throw new Exception("there are no Patients");
            else
                return Patients.OrderBy(p => p.Payment).ToList();
        }

        public static List<Patient> SortBy_PaymentDesc()
        {
            if (Patients.Count == 0)
                throw new Exception("there are no Patients");
            else
                return Patients.OrderByDescending(p => p.Payment).ToList();
        }

      
        #endregion


    }
}
