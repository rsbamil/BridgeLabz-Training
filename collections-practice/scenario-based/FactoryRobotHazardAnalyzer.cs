using System;
public class RobotSafetyException : Exception
{
    public RobotSafetyException(string message) : base(message)
    {

    }
}
class RobotHazardAuditor
{
    public double CalculateHazardScore(double armPrecision, int workerDensity, string machineryState)
    {
        if (armPrecision < 0 || armPrecision > 1)
        {
            throw new RobotSafetyException("Error: Arm precision must be 0.0-1.0.");
        }
        if (workerDensity < 1 || workerDensity > 20)
        {
            throw new RobotSafetyException("Error: Worker density must be 1 - 20");
        }
        double machineRiskFactor;
        switch (machineryState)
        {
            case "Worn":
                machineRiskFactor = 1.3;
                break;
            case "Faulty":
                machineRiskFactor = 2.0;
                break;
            case "Critical":
                machineRiskFactor = 3.0;
                break;
            default:
                throw new RobotSafetyException("Error: Unsupported machinery state.");
        }
        double hazardRisk = ((1.0 - armPrecision) * 15.0) + (workerDensity * machineRiskFactor);
        return hazardRisk;
    }
}
class FactoryRobotHazardAnalyzer
{
    static void Main()
    {
        RobotHazardAuditor auditor = new RobotHazardAuditor();
        Console.WriteLine("Enter the Arm Precision (0.0 - 1.0): ");
        double armPrecision = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter the Worker Density (1 - 20): ");
        int workerDensity = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the Machinery State (Worn, Faulty, Critical): ");
        string machineryState = Console.ReadLine();
        try
        {
            double hazardScore = auditor.CalculateHazardScore(armPrecision, workerDensity, machineryState);
            Console.WriteLine("Calculated Hazard Score : " + hazardScore);
        }
        catch (RobotSafetyException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}