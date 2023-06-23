class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Patient Information System!");

        // Ask user to enter their age
        Console.Write("Please enter your age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        // Ask user to insert patient information
        Console.WriteLine("\nEnter the patient information:");
        Console.Write("First Name: ");
        string firstName = Console.ReadLine();
        Console.Write("Last Name: ");
        string lastName = Console.ReadLine();
        Console.Write("Weight (in KG): ");
        double weight = Convert.ToDouble(Console.ReadLine());
        Console.Write("Height (in CM): ");
        double height = Convert.ToDouble(Console.ReadLine());

        // Create a Patient object based on user input
        Patient patient = new Patient(firstName, lastName, weight, height);

        // Print patient information
        patient.PrintPatientInformation();

        Console.ReadLine();
    }
}
