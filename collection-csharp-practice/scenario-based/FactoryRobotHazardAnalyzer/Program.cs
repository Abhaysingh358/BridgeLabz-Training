namespace FactoryRobotHazardAnalyzer
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Arm Precision (0.0 - 1.0):");
            double armPrecision = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter Worker Density (1 - 20):");
            int workerDensity = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Machinery State (Worn/Faulty/Critical):");
            string machineryState = Console.ReadLine();
            if (string.IsNullOrEmpty(machineryState))
            {
                Console.WriteLine("machineryState can not be empty");
                return;
            }

            RobotHazardAuditor auditor = new RobotHazardAuditor();
            double hazardRiskScore = auditor.CalculateHazardRisk(armPrecision,workerDensity,machineryState);
            Console.WriteLine(hazardRiskScore);
            
        }
    }
}