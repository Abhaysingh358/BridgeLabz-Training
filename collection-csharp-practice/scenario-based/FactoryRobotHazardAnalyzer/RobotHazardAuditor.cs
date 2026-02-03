namespace FactoryRobotHazardAnalyzer
{
    public class RobotHazardAuditor
    {
        public readonly double Worn = 1.3;
        public readonly  double Faulty = 2.0;
        public readonly double Critical = 3.0;
        // this method calculates and return hazard risk score using below formula 
        // hazard Risk = ((1.0 - armPrecision) * 15.0) + (workerDensity * machineRiskFactor)

        //Machine Risk Factor for machinery state are,
        // ● Worn→ 1.3
        // ● Faulty→ 2.0
        // ● Critical→ 3.0

        public double CalculateHazardRisk(double armPrecision , int workerDensity ,string machineryState)
        {
            try
            {
                if(armPrecision>1.0 || armPrecision <0.0)
                {
                    throw new RobotSafetyException("Error: Arm precision must be 0.0-1.0");
                }

                 if(workerDensity<1 || workerDensity >20)
                {
                    throw new RobotSafetyException("Error : Worker density must be 1-20");
                }

                // if(!machineryState.Equals("Faulty" , StringComparison.OrdinalIgnoreCase)
                // || !machineryState.Equals("Worn" , StringComparison.OrdinalIgnoreCase)
                // || !machineryState.Equals("Critical" , StringComparison.OrdinalIgnoreCase))
                // {
                    
                // }

                double hazardRiskScore = 0.0;
                if (machineryState.Equals("Faulty",StringComparison.OrdinalIgnoreCase))
                {
                    hazardRiskScore = ((1.0 - armPrecision) * 15.0) + (workerDensity * Faulty);
                    
                }

                else if(machineryState.Equals("Worn" , StringComparison.OrdinalIgnoreCase))
                {
                    hazardRiskScore = ((1.0 - armPrecision) * 15.0) + (workerDensity * Worn);
                  
                }

                else if(machineryState.Equals("Critical" , StringComparison.OrdinalIgnoreCase))
                {
                    hazardRiskScore = ((1.0 - armPrecision) * 15.0) + (workerDensity * Critical);
                    
                }

                else
                {
                    throw new Exception("Error: Unsupported machinery state");
                }

                return hazardRiskScore;
                
            }

            catch(RobotSafetyException ex)
            {
                Console.WriteLine($"Caught Error : {ex.Message}");
                return 0.0;
            }
        }
    }
}