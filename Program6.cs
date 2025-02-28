using System;
using System.Collections.Generic;

//creating 'Patient' class
class Patient{
    public string name { get; private set; }
    private List<Doctor> doctors; 

	//constructor to initialise Patient details
    public Patient(string name){
        this.name = name;
        doctors = new List<Doctor>();
    }

    //method to add a doctor to patient's list
    public void AddDoctor(Doctor doctor){
        if(!doctors.Contains(doctor)){
            doctors.Add(doctor);
            doctor.AddPatient(this);
        }
    }

    //method to display the doctors a patient has consulted
    public void ShowDoctors(){
        Console.WriteLine("\nPatient \'{0}\' has consulted the following doctors:",name);
        if(doctors.Count == 0) Console.WriteLine("No coonsultations!");
        else{
            foreach(Doctor doctor in doctors){
                Console.WriteLine("- "+doctor.name);
			}
		}
    }
}

//creating 'Doctor' class
class Doctor{
    public string name { get; private set; }
    private List<Patient> patients; 

	//constructor to initialise Doctor details
    public Doctor(string name){
        this.name = name;
        patients = new List<Patient>();
    }

    //method to add a patient to doctor's list
    public void AddPatient(Patient patient){
        if(!patients.Contains(patient)) patients.Add(patient);
    }

    //method to consult 
    public void Consult(Patient patient){
        AddPatient(patient); 
        patient.AddDoctor(this);
    }

    //method to display the patients a doctor has consulted
    public void ShowPatients(){
        Console.WriteLine("\nDoctor \'{0}\' has consulted the following patients:",name);
        if(patients.Count == 0) Console.WriteLine("No consultations!");
        else{
            foreach(Patient patient in patients){
                Console.WriteLine("- "+patient.name);
			}
		}
    }
}

//creating 'Hospital' class
class Hospital{
    public string HospitalName { get; private set; }
    private List<Doctor> doctors;
    private List<Patient> patients;

	//constructor to initialise Hospital details
    public Hospital(string hospitalName){
        HospitalName = hospitalName;
        doctors = new List<Doctor>();
        patients = new List<Patient>();
    }

    //method to add doctor to hospital
    public void AddDoctor(Doctor doctor){
        if (!doctors.Contains(doctor)) doctors.Add(doctor);
    }

    //method to add patient to hospital
    public void AddPatient(Patient patient){
        if (!patients.Contains(patient)) patients.Add(patient);
    }

    //method to display hospital details
    public void ShowHospital(){
        Console.WriteLine("\nHospital: "+HospitalName);

        Console.WriteLine("\nDoctors:");
        if(doctors.Count == 0) Console.WriteLine("No doctors available.");
        else{
            foreach(Doctor doctor in doctors){
                Console.WriteLine("- "+doctor.name);
			}
		}

        Console.WriteLine("\nPatients:");
        if(patients.Count == 0) Console.WriteLine("No patients available.");
        else{
            foreach(Patient patient in patients){
                Console.WriteLine("- "+patient.name);
			}
		}
    }
}

class Program6{
    static void Main(string[] args){
        //creating Hospital object
        Hospital hospital = new Hospital("City Hospital");

        //creating Doctor objects
        Doctor dr1 = new Doctor("Asha Solanki");
        Doctor dr2 = new Doctor("Kanika Maheshwari");

        //creating Patient objects
        Patient patient1 = new Patient("Sneha");
        Patient patient2 = new Patient("Rishi");

        //adding doctors and patients to hospital
        hospital.AddDoctor(dr1);
        hospital.AddDoctor(dr2);
        hospital.AddPatient(patient1);
        hospital.AddPatient(patient2);

        //consultations
        dr1.Consult(patient1);
        dr1.Consult(patient2);
        dr1.Consult(patient1);

        //displaying hospital information
        hospital.ShowHospital();

        //showing doctor-patient relationships
        dr1.ShowPatients();
        dr2.ShowPatients();
        patient1.ShowDoctors();
        patient2.ShowDoctors();
    }
}
