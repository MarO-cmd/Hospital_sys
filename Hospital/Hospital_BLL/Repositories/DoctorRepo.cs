using Hospital_BLL.Servises;
using Hospital_DAL.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_BLL.Repositories
{
    public class DoctorRepo : IHumanCRUD<Doctor>
    {
        static List<Doctor> Doctors = new List<Doctor>();

        public static int No_Doctors()
        {
            return Doctors.Count();
        }
        public static decimal All_salary()
        {
            return Doctor.All_Salary;
        }

        #region CRUD OP

        public void Add()
        {
            var doctor = new Doctor();

            Console.Write("Enter The Id : ");
            doctor.Id = Console.ReadLine();

            Console.Write("Enter Name : ");
            doctor.Name = Console.ReadLine();

            Console.Write("Enter Age : ");
            doctor.Age = int.Parse(Console.ReadLine());

            Console.Write("Enter Salary : ");
            doctor.Salary = decimal.Parse(Console.ReadLine());

            Doctor.All_Salary += doctor.Salary;

            doctor.patient = new Patient();
            Console.Write("Enter the patient id that the doctor examin : ");
            doctor.patient.Id = Console.ReadLine();

            Console.Write("Enter the patient Name: ");
            doctor.patient.Name = Console.ReadLine();

            Doctors.Add(doctor);

            Console.Write("Doctor Added..");
            Thread.Sleep(1500);
        }
        public void Delete(string Id)
        {
            if (Doctors.Count == 0)
            {
                throw new Exception("there are no Doctors");
            }
            else
            {
                bool flag = false;
                var delDoc = Doctors.Where(item => item.Id == Id).ToList();
                if (delDoc.Count != 0)
                {
                    Doctor.All_Salary -= delDoc[0].Salary;
                    Doctors.Remove(delDoc[0]);
                    flag = true;
                }

                if (flag)
                {
                    Console.WriteLine("Doctor Deleted..");
                    Thread.Sleep(1500);
                }
                else
                {
                    Console.WriteLine("The Doctor Not Found !");
                    Thread.Sleep(1500);
                }
            }
        }
        public List<Doctor> GetAll()
        {
            if (Doctors.Count == 0)
            {
                throw new Exception("there are no Doctors");

            }
            else
            {
                return Doctors;
            }
        }
        public Doctor GetById(string Id)
        {
            if (Doctors.Count == 0)
            {
                throw new Exception("there are no Doctors");
            }
            else
            {
              
                var FoundDoc = Doctors.Where(item => item.Id == Id).ToList();
                if (FoundDoc.Count != 0)               
                    return FoundDoc[0];              
                else             
                    throw new Exception("Doctor Not Found");
               
            }
        }
        public void Update(string Id)
        {
            if (Doctors.Count == 0)
            {
                throw new Exception("there are no Doctors");

            }
            else
            {
                bool flag = false;

                var UpDoc = Doctors.Where(item => item.Id == Id).ToList();
                if (UpDoc.Count != 0)
                {
                    Console.Write("Enter Name : ");
                    UpDoc[0].Name = Console.ReadLine();

                    Console.Write("Enter Age : ");
                    UpDoc[0].Age = int.Parse(Console.ReadLine());

                    Doctor.All_Salary -= UpDoc[0].Salary; //reset salary
                    Console.Write("Enter Salary : ");
                    UpDoc[0].Salary = decimal.Parse(Console.ReadLine());

                    UpDoc[0].patient = new Patient();
                    Console.Write("Enter the patient id that the doctor examin : ");
                    UpDoc[0].patient.Id = Console.ReadLine();

                    Console.Write("Enter the patient name: ");
                    UpDoc[0].patient.Name = Console.ReadLine();

                    Doctor.All_Salary += UpDoc[0].Salary; //update the salary

                    flag = true;


                }
                if (flag)
                    Console.WriteLine("Doctor Updated..");
                else
                    Console.WriteLine("The Doctor Not Found !");
            }
        } 

        #endregion

    }
}
