


using Hospital_BLL.Repositories;

var patient = new PatientRepo();
var Doctor = new DoctorRepo();

Console.WriteLine("*** Welcome To Our Hospital  ***");
Console.WriteLine("            ^_^                 \n");

while (true)
{
    try
    {
        Console.WriteLine("Enter 1 For Admin \nEnter 2 For Patient\nEnter 3 For Doctor\nEnter 4 For Nurse");
        int check = int.Parse(Console.ReadLine());
        Console.Clear();
        switch (check)
        {

            #region Admin
            case 1:
                Console.WriteLine("Enter 1 for Patients\nEnter 2 for Doctors\nEnter 3 for Nurses");
                int Check = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (Check)
                {
                    case 1: //Patient
                        Console.WriteLine("Number of Patients : " + PatientRepo.No_patients());
                        Console.WriteLine("All money sould be paid by all patients : " + PatientRepo.All_pay());
                        Console.WriteLine("press any Key");
                        Console.ReadKey();
                        break;
                    case 2: //Doctor
                        Console.WriteLine("Number of Doctors : " + DoctorRepo.No_Doctors());
                        Console.WriteLine("All money sould be payied to all Doctors : " + DoctorRepo.All_salary());
                        Console.WriteLine("press any Key");
                        Console.ReadKey();
                        break;
                    case 3: //Nurse
                        Console.WriteLine("Number of Nurses : " + NurseRepo.No_Nurses());
                        Console.WriteLine("All money sould be payied to all Nurses : " + NurseRepo.All_salary());
                        Console.WriteLine("press any Key");
                        Console.ReadKey();
                        break;
                }
                break;
            #endregion

            #region Patient_PL

            case 2:
                Console.Clear();
                Console.WriteLine(
                    "Enter 1 Add New Patient\n" +
                    "Enter 2 Delete a Patient\n" +
                    "Enter 3 Update a Patient\n" +
                    "Enter 4 return All Patients\n" +
                    "Enter 5 Find Patient by Id");
                int chck = int.Parse(Console.ReadLine());
                switch (chck)
                {
                    case 1:
                        patient.Add();

                        break;
                    case 2:
                        Console.Write("Enter the Id of the patient : ");
                        string Delssn = Console.ReadLine();
                        patient.Delete(Delssn);

                        break;
                    case 3:
                        Console.Write("Enter the Id of the patient : ");
                        string Updssn = Console.ReadLine();
                        patient.Update(Updssn);
                        Thread.Sleep(1500);
                        break;
                    case 4:
                        foreach (var item in patient.GetAll())
                        {
                            //Console.WriteLine(
                            //    $"SSN : {item.Id}\n" +
                            //    $"Name : {item.Name}\n" +
                            //    $"Age: {item.Age}\n" +
                            //    $"Illness : {item.Illness}\n" +
                            //    $"EnteryDate: {item.Entery_date}\n" +
                            //    $"ExitDate : {item.Exit_date}\n"+
                            //    $"Ward Id :{item.ward.Id}\n" +
                            //    $"Ward Name: {item.ward.Name}\n" +
                            //    $"Drug Code {item.drug.Code}\n" +
                            //    $"Drug Name {item.drug.Name}\n" +
                            //    $"Drug Dosage {item.drug.Dosage}"                              
                            //    );
                            Console.WriteLine(item);
                            Thread.Sleep(1000);
                            Console.WriteLine("=====>");
                        }
                        Console.WriteLine("Press any key");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 5:
                        Console.Write("Enter the id : ");
                        string GetBtId = Console.ReadLine();
                        Console.WriteLine(patient.GetById(GetBtId));
                        Console.WriteLine("Press any key");
                        Console.ReadKey();
                        break;


                }
                break;

            #endregion

            #region Doctor_PL
            case 3:
                Console.Clear();
                Console.WriteLine(
                    "Enter 1 Add New Doctor\n" +
                    "Enter 2 Delete a Doctor\n" +
                    "Enter 3 Update a Doctor\n" +
                    "Enter 4 return All Doctors\n"+
                    "Enter 5 Find Doctor by Id");
                int chk = int.Parse(Console.ReadLine());
                switch (chk)
                {
                    case 1:
                        Doctor.Add();

                        break;
                    case 2:
                        Console.Write("Enter the Id of the Doctor : ");
                        string Delssn = Console.ReadLine();
                        Doctor.Delete(Delssn);

                        break;
                    case 3:
                        Console.Write("Enter the Id of the Doctor : ");
                        string Updssn = Console.ReadLine();
                        Doctor.Update(Updssn);

                        break;
                    case 4:
                        foreach (var item in Doctor.GetAll())
                        {
                            //Console.WriteLine(
                            //    $"SSN : {item.Id}\n" +
                            //    $"Name : {item.Name}\n" +
                            //    $"Age: {item.Age}\n" +
                            //    $"Salary : {item.Salary}\n"+
                            //    $"the SSN of the patient that the doctor examin is  : {item.patient.Id}"
                            //    );
                            Console.WriteLine(item);
                            Thread.Sleep(1000);
                            Console.WriteLine("=====>");
                        }
                        Console.WriteLine("Press any key");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 5:
                        Console.Write("Enter the id : ");
                        string GetBtId = Console.ReadLine();
                        Console.WriteLine(Doctor.GetById(GetBtId));
                        Console.WriteLine("Press any key");
                        Console.ReadKey();
                        break;

                }

                break;
            #endregion     

            #region Nurse
            case 4:
                Console.Clear();
                Console.WriteLine(
                    "Enter 1 Add New Nurse\n" +
                    "Enter 2 Delete a Nurse\n" +
                    "Enter 3 Update a Nurse\n" +
                    "Enter 4 return All Nurse\n" +
                    "Enter 5 Find Nurse by Id");
                int chCk = int.Parse(Console.ReadLine());
                NurseRepo nurse = new NurseRepo();

                switch (chCk)
                {
                    case 1:
                        nurse.Add();
                        break;
                    case 2:
                        Console.Write("Enter the Id of the Nurse : ");
                        string Delssn = Console.ReadLine();
                        nurse.Delete(Delssn);
                        break;
                    case 3:
                        Console.Write("Enter the Id of the Nurse : ");
                        string Updssn = Console.ReadLine();
                        nurse.Update(Updssn);

                        break;
                    case 4:
                        foreach (var item in nurse.GetAll())
                        {
                            Console.WriteLine(item);
                            Thread.Sleep(1000);
                            Console.WriteLine("=====>");
                        }
                        Console.WriteLine("Press any key");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 5:
                        Console.Write("Enter the id : ");
                        string GetBtId = Console.ReadLine();
                        Console.WriteLine(nurse.GetById(GetBtId));
                        Console.WriteLine("Press any key");
                        Console.ReadKey();
                        break;
                } 
                #endregion


                break;
        }
        Console.Clear();
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
        Console.WriteLine("Press any key");
        Console.ReadKey();


        Console.Clear();
    }
}





