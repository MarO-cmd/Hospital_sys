


using Hospital_BLL.Repositories;
using Hospital_BLL.Servises;
//using Hospital_DAL.DomainModels;

//IHumanCRUD<Patient> patient = new PatientRepo();  // is this true ?

var patient = new PatientRepo();
var Doctor = new DoctorRepo();

Console.WriteLine("*** Welcome To Our Hospital  ***");
Console.WriteLine("            ^_^                 \n");

while (true)
{
    try
    {
        Console.WriteLine(
            "1. For Admin \n" +
            "2. For Patient\n" +
            "3. For Doctor\n" +
            "4. For Nurse");
        int check = int.Parse(Console.ReadLine());
        Console.Clear();
        switch (check)
        {

            #region Admin
            case 1:
                Console.Write("enter the username : ");
                string user = Console.ReadLine().ToLower();
                Console.Write("enter the Password : ");
                string pass = Console.ReadLine();
                Console.Clear();
                if (user == "maro" && pass == "1234Aa")
                {
                    Console.WriteLine(
                        "1. for Patients\n" +
                        "2. for Doctors\n" +
                        "3. for Nurses");
                    int Check = int.Parse(Console.ReadLine());
                    Console.Clear();
                    switch (Check)
                    {
                        #region Patient
                        case 1: //Patient
                            Console.WriteLine(
                                "1. Number of patients\n" +
                                "2. All money Should be paid by All Patients\n" +
                                "3. Sort Patient according to payment\n" +
                                "4. Sort Patient according to payment descending");
                            int cHk = int.Parse(Console.ReadLine());
                            switch (cHk)
                            {
                                case 1:
                                    if(PatientRepo.No_patients()== 0)
                                        Console.WriteLine("there is no patients ");
                                    else
                                        Console.WriteLine("Number of Patients : " + PatientRepo.No_patients());
                                    break;
                                case 2:
                                    if (PatientRepo.No_patients() == 0)
                                        Console.WriteLine("there is no patients ");
                                    else
                                        Console.WriteLine("All money sould be paid by all patients : " + PatientRepo.All_pay());
                                    break;
                                case 3:
                                    if (PatientRepo.No_patients() == 0)
                                        Console.WriteLine("there is no patients ");
                                    else
                                    {
                                        Console.WriteLine("---------------------------------------------------");
                                        Console.WriteLine("\tId\t\tPayment");

                                        foreach (var item in PatientRepo.SortBy_Payment().Select(P => new { P.Id, P.Payment }).ToList())
                                        {
                                            Console.WriteLine($"\t{item.Id}\t\t{item.Payment}");
                                        }
                                    }
                                    break;
                                case 4:
                                    if (PatientRepo.No_patients() == 0)
                                        Console.WriteLine("there is no patients ");
                                    else
                                    {
                                        Console.WriteLine("---------------------------------------------------");
                                        Console.WriteLine("\tId\t\tPayment");
                                        foreach (var item in PatientRepo.SortBy_PaymentDesc().Select(P => new { P.Id, P.Payment }).ToList())
                                        {
                                            Console.WriteLine($"\t{item.Id}\t\t{item.Payment}");
                                        }
                                    }
                                    break;

                            }

                            Console.WriteLine("press any Key");
                            Console.ReadKey();
                            break;
                        #endregion

                        #region Doctor
                        case 2: //Doctor
                            Console.WriteLine(
                               "1. Number of Doctors\n" +
                               "2. All money Should be payied to All Doctors\n" +
                               "3. Sort Doctors according to salary\n" +
                               "4. Sort Doctors according to salary descending");
                            int chEck = int.Parse(Console.ReadLine());
                            switch (chEck)
                            {
                                case 1:
                                    if(DoctorRepo.No_Doctors()==0)
                                        Console.WriteLine("there is no doctors!");
                                    else
                                        Console.WriteLine("Number of Doctors : " + DoctorRepo.No_Doctors());
                                    break;
                                case 2:
                                    if (DoctorRepo.No_Doctors() == 0)
                                        Console.WriteLine("there is no doctors!");
                                    else
                                        Console.WriteLine("All money sould be payied to all Doctors : " + DoctorRepo.All_salary());

                                    break;
                                case 3:
                                    if (DoctorRepo.No_Doctors() == 0)
                                        Console.WriteLine("there is no doctors!");
                                    else
                                    {
                                        Console.WriteLine("---------------------------------------------------");
                                        Console.WriteLine("\tId\t\tSalary");
                                        foreach (var item in DoctorRepo.SortBy_Salary().Select(P => new { P.Id, P.Salary }).ToList()) //anonymous class
                                        {
                                            Console.WriteLine($"\t{item.Id}\t\t{item.Salary}");

                                        }
                                    }
                                    break;
                                case 4:
                                    if (DoctorRepo.No_Doctors() == 0)
                                        Console.WriteLine("there is no doctors!");
                                    else
                                    {
                                        Console.WriteLine("---------------------------------------------------");
                                        Console.WriteLine("\tId\t\tSalary");
                                        foreach (var item in DoctorRepo.SortBy_SalaryDesc().Select(P => new { P.Id, P.Salary }).ToList())
                                        {
                                            Console.WriteLine($"\t{item.Id}\t\t{item.Salary}");
                                        }
                                    }
                                    break;
                            }


                            Console.WriteLine("press any Key");
                            Console.ReadKey();
                            break;
                        #endregion

                        #region Nurse
                        case 3: //Nurse
                            Console.WriteLine(
                               "1. Number of Nurses\n" +
                               "2. All money Should be payied to All Nurses\n" +
                               "3. Sort Nurses according to salary\n" +
                               "4. Sort Nurses according to salary descending");
                            int cheCk = int.Parse(Console.ReadLine());
                            switch (cheCk)
                            {
                                case 1:
                                    if(NurseRepo.No_Nurses()==0)
                                        Console.WriteLine("There is no Nurses!");
                                    else
                                        Console.WriteLine("Number of Nurses : " + NurseRepo.No_Nurses());
                                    break;
                                case 2:
                                    if (NurseRepo.No_Nurses() == 0)
                                        Console.WriteLine("There is no Nurses!");
                                    else
                                        Console.WriteLine("All money sould be payied to all Nurses : " + NurseRepo.All_salary());
                                    break;
                                case 3:
                                    if (NurseRepo.No_Nurses() == 0)
                                        Console.WriteLine("There is no Nurses!");
                                    else
                                    {
                                        Console.WriteLine("---------------------------------------------------");
                                        Console.WriteLine("\tId\t\tSalary");
                                        foreach (var item in NurseRepo.SortBy_Salary().Select(P => new { P.Id, P.Salary }).ToList()) //anonymous class
                                        {
                                            Console.WriteLine($"\t{item.Id}\t\t{item.Salary}");
                                        }
                                    }

                                    break;
                                case 4:
                                    if (NurseRepo.No_Nurses() == 0)
                                        Console.WriteLine("There is no Nurses!");
                                    else
                                    {
                                        Console.WriteLine("---------------------------------------------------");
                                        Console.WriteLine("\tId\t\tSalary");
                                        foreach (var item in NurseRepo.SortBy_SalaryDesc().Select(P => new { P.Id, P.Salary }).ToList())
                                        {
                                            Console.WriteLine($"\t{item.Id}\t\t{item.Salary}");
                                        }
                                    }
                                    break;
                            }
                            Console.WriteLine("press any Key");
                            Console.ReadKey();
                            break;
                            #endregion


                    }
                    break;
                }
                else
                {
                    Console.WriteLine("wrong passward or username");
                    Console.WriteLine("press any key");
                    Console.ReadKey();
                    break;
                }

            #endregion

            #region Patient_PL

            case 2:
                Console.Clear();
                Console.WriteLine(
                    "1. Add New Patient\n" +
                    "2. Delete a Patient\n" +
                    "3. Update a Patient\n" +
                    "4. return All Patients\n" +
                    "5. Find Patient by Id\n" +
                    "6. Sorting ");
                int chck = int.Parse(Console.ReadLine());
                switch (chck)
                {
                    case 1: //add
                        patient.Add();

                        break;
                    case 2: //Delete
                        Console.Write("Enter the Id of the patient : ");
                        string Delssn = Console.ReadLine();
                        patient.Delete(Delssn);

                        break;
                    case 3: //Update
                        Console.Write("Enter the Id of the patient : ");
                        string Updssn = Console.ReadLine();
                        patient.Update(Updssn);
                        Thread.Sleep(1500);
                        break;
                    case 4: //return All
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
                            item.Drug_Display();
                            Thread.Sleep(1000);
                            Console.WriteLine("=====>");
                        }

                        Console.WriteLine("Press any key");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 5:  //Find By Id
                        Console.Write("Enter the id : ");
                        string GetBtId = Console.ReadLine();
                        Console.WriteLine(patient.GetById(GetBtId));
                        Console.WriteLine("Press any key");
                        Console.ReadKey();
                        break;
                    case 6: //Sorting
                        Console.WriteLine(
                            "1. sort by Name \n" +
                            "2. sort by Id \n" +
                            "3. sort by Age \n" +
                            "4. sort by Days \n" +
                            "5. sort by Days descending ");
                        int chcK = int.Parse(Console.ReadLine());
                        Console.Clear();
                        switch (chcK)
                        {
                            case 1:
                                foreach (var item in PatientRepo.SortBy_Name())
                                {
                                    Console.WriteLine(item);
                                    Thread.Sleep(1000);
                                    Console.WriteLine("=====>");                                   
                                }                             
                                break;
                            case 2:
                                foreach (var item in PatientRepo.SortBy_Id())
                                {
                                    Console.WriteLine(item);
                                    Thread.Sleep(1000);
                                    Console.WriteLine("=====>");

                                }                               
                                break;
                            case 3:
                                foreach (var item in PatientRepo.SortBy_Age())
                                {
                                    Console.WriteLine(item);
                                    Thread.Sleep(1000);
                                    Console.WriteLine("=====>");
                                }                               
                                break;
                            case 4:
                                foreach (var item in PatientRepo.SortBy_Days())
                                {
                                    Console.WriteLine(item);
                                    Thread.Sleep(1000);
                                    Console.WriteLine("=====>");
                                }                            
                                break;
                            case 5:
                                foreach (var item in PatientRepo.SortBy_DaysDesc())
                                {
                                    Console.WriteLine(item);
                                    Thread.Sleep(1000);
                                    Console.WriteLine("=====>");
                                }                              
                                break;
                        }
                        Console.WriteLine("Press any Key");
                        Console.ReadKey();
                        break;


                }
                break;

            #endregion

            #region Doctor_PL
            case 3:
                Console.Clear();
                Console.WriteLine(
                    "1. Add New Doctor\n" +
                    "2. Delete a Doctor\n" +
                    "3. Update a Doctor\n" +
                    "4. return All Doctors\n" +
                    "5. Find Doctor by Id\n" +
                    "6. Sorting");
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
                    case 6: //Sorting
                        Console.WriteLine(
                            "1. sort by Name \n" +
                            "2. sort by Id \n" +
                            "3. sort by Age");
                        int chcK = int.Parse(Console.ReadLine());
                        switch (chcK)
                        {
                            case 1:
                                foreach (var item in DoctorRepo.SortBy_Name())
                                {
                                    Console.WriteLine(item);
                                    Thread.Sleep(1000);
                                    Console.WriteLine("=====>");
                                }                             
                                break;
                            case 2:
                                foreach (var item in DoctorRepo.SortBy_Id())
                                {
                                    Console.WriteLine(item);
                                    Thread.Sleep(1000);
                                    Console.WriteLine("=====>");
                                }                              
                                break;
                            case 3:
                                foreach (var item in DoctorRepo.SortBy_Age())
                                {
                                    Console.WriteLine(item);
                                    Thread.Sleep(1000);
                                    Console.WriteLine("=====>");
                                }                             
                                break;

                        }
                        Console.WriteLine("Press any Key");
                        Console.ReadKey();
                        break;

                }

                break;
            #endregion     

            #region Nurse_PL
            case 4:
                Console.Clear();
                Console.WriteLine(
                    "1. Add New Nurse\n" +
                    "2. Delete a Nurse\n" +
                    "3. Update a Nurse\n" +
                    "4. return All Nurse\n" +
                    "5. Find Nurse by Id\n" +
                    "6. Sorting");
                int chCk = int.Parse(Console.ReadLine());
                NurseRepo nurse = new NurseRepo();

                switch (chCk)
                {
                    case 1: //Add
                        nurse.Add();
                        break;
                    case 2: //Delete
                        Console.Write("Enter the Id of the Nurse : ");
                        string Delssn = Console.ReadLine();
                        nurse.Delete(Delssn);
                        break;
                    case 3: //Update
                        Console.Write("Enter the Id of the Nurse : ");
                        string Updssn = Console.ReadLine();
                        nurse.Update(Updssn);
                        break;
                    case 4: //return All
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
                    case 5: //return by id
                        Console.Write("Enter the id : ");
                        string GetBtId = Console.ReadLine();
                        Console.WriteLine(nurse.GetById(GetBtId));
                        Console.WriteLine("Press any key");
                        Console.ReadKey();
                        break;
                    case 6: //Sorting
                        Console.WriteLine(
                            "1. sort by Name \n" +
                            "2. sort by Id \n" +
                            "3. sort by Age");
                        int chcK = int.Parse(Console.ReadLine());
                        switch (chcK)
                        {
                            case 1:
                                foreach (var item in NurseRepo.SortBy_Name())
                                {
                                    Console.WriteLine(item);
                                    Thread.Sleep(1000);
                                    Console.WriteLine("=====>");
                                }
                                break;
                            case 2:
                                foreach (var item in NurseRepo.SortBy_Id())
                                {
                                    Console.WriteLine(item);
                                    Thread.Sleep(1000);
                                    Console.WriteLine("=====>");
                                }
                                break;
                            case 3:
                                foreach (var item in NurseRepo.SortBy_Age())
                                {
                                    Console.WriteLine(item);
                                    Thread.Sleep(1000);
                                    Console.WriteLine("=====>");
                                }
                                break;                              
                        }
                        Console.WriteLine("Press any Key");
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





