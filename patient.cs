public class Patient
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public double Weight { get; set; } // in KG
    public double Height { get; set; } // in Centimeters

    public Patient(string firstName, string lastName, double weight, double height)
    {
        FirstName = firstName;
        LastName = lastName;
        Weight = weight;
        Height = height;
    }

    public string CalculateBloodPressure(int systolic, int diastolic)
    {
        if (systolic < 90 || systolic > 200 || diastolic < 60 || diastolic > 120)
        {
            return "Invalid blood pressure values. Please consult your doctor.";
        }
        else if (systolic <= 120 && diastolic <= 80)
        {
            return "Normal";
        }
        else if (systolic <= 129 && diastolic <= 84)
        {
            return "Elevated";
        }
        else if (systolic <= 139 && diastolic <= 89)
        {
            return "High Blood Pressure (Hypertension) Stage 1";
        }
        else if (systolic <= 180 && diastolic <= 120)
        {
            return "High Blood Pressure (Hypertension) Stage 2";
        }
        else
        {
            return "Hypertensive Crisis. Please consult your doctor immediately.";
        }
    }

    public double CalculateBMI()
    {
        double heightInMeter = Height / 100; // Convert height from centimeters to meters
        return Weight / (heightInMeter * heightInMeter);
    }

    public void PrintPatientInformation()
    {
        Console.WriteLine("Patient Information:");
        Console.WriteLine("Full Name: {0} {1}", FirstName, LastName);
        Console.WriteLine("Weight: {0} KG", Weight);
        Console.WriteLine("Height: {0} CM", Height);
        Console.WriteLine("Blood Pressure: {0}", CalculateBloodPressure(120, 80));
        Console.WriteLine("BMI: {0}", CalculateBMI());

        double bmi = CalculateBMI();
        if (bmi >= 25.0)
        {
            Console.WriteLine("BMI Status: Overweight");
        }
        else if (bmi >= 18.5 && bmi <= 24.9)
        {
            Console.WriteLine("BMI Status: Normal (In the healthy range)");
        }
        else
        {
            Console.WriteLine("BMI Status: Underweight");
        }
    }
}
