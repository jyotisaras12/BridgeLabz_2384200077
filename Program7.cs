using System;
using System.Collections.Generic;

//creating an abstract class 'Patient'
abstract class Patient {
    protected string patientId;
    protected string name;
    protected int age;

    //constructor to initialize patient details
    public Patient(string patientId, string name, int age) {
        this.patientId = patientId;
        this.name = name;
        this.age = age;
    }

    //abstract method to calculate bill
    public abstract double CalculateBill();

    //method to display patient details
    public virtual void GetPatientDetails() {
        Console.WriteLine("Patient Details:\nID: {0}\nName: {1}\nAge: {2}", patientId, name, age);
    }
}

//creating an interface for managing medical records
interface IMedicalRecord {
    void AddRecord(string record);
    string ViewRecords();
}

//creating 'InPatient' class inheriting from Patient and implementing IMedicalRecord
class InPatient : Patient, IMedicalRecord {
    private double dailyCharge;
    private int numberOfDays;
    private List<string> medicalRecords = new List<string>();

    //constructor to initialize InPatient details
    public InPatient(string patientId, string name, int age, double dailyCharge, int numberOfDays)
        : base(patientId, name, age) {
        this.dailyCharge = dailyCharge;
        this.numberOfDays = numberOfDays;
    }

    //method to calculate bill for inpatients
    public override double CalculateBill() {
        return dailyCharge * numberOfDays;
    }

    //method to add a medical record
    public void AddRecord(string record) {
        medicalRecords.Add(record);
    }

    //method to view medical records
    public string ViewRecords() {
        return medicalRecords.Count > 0 ? string.Join(", ", medicalRecords) : "No medical records available.";
    }

    //method to display patient details
    public override void GetPatientDetails() {
        base.GetPatientDetails();
        Console.WriteLine("Patient Type: InPatient");
        Console.WriteLine("Medical Records: {0}", ViewRecords());
    }
}

//creating 'OutPatient' class inheriting from Patient and implementing IMedicalRecord
class OutPatient : Patient, IMedicalRecord {
    private double consultationFee;
    private List<string> medicalRecords = new List<string>();

    //constructor to initialize OutPatient details
    public OutPatient(string patientId, string name, int age, double consultationFee): base(patientId, name, age) {
        this.consultationFee = consultationFee;
    }

    //method to calculate bill for outpatients
    public override double CalculateBill() {
        return consultationFee;
    }

    //method to add a medical record
    public void AddRecord(string record) {
        medicalRecords.Add(record);
    }

    //method to view medical records
    public string ViewRecords() {
        return medicalRecords.Count > 0 ? string.Join(", ", medicalRecords) : "No medical records available.";
    }

    //method to display patient details
    public override void GetPatientDetails() {
        base.GetPatientDetails();
        Console.WriteLine("Patient Type: OutPatient");
        Console.WriteLine("Medical Records: {0}", ViewRecords());
    }
}

class Program7 {
    public static void Main(string[] args) {
        //creating a list of patients
        List<Patient> patients = new List<Patient>();

        //adding an inpatient
        InPatient inPatient = new InPatient("P123", "Diva", 45, 3000, 6);
        inPatient.AddRecord("Heart Surgery");
        patients.Add(inPatient);

        //adding an outpatient
        OutPatient outPatient = new OutPatient("P345", "Jasmine", 28, 700);
        outPatient.AddRecord("Regular Checkup");
        patients.Add(outPatient);

        //iterating through the list to display patient details and bills
        foreach (Patient patient in patients) {
            patient.GetPatientDetails();
            double billAmount = patient.CalculateBill();
            Console.WriteLine("Total Bill: {0}", billAmount);
            Console.WriteLine(new string('-', 40));
        }
    }
}
