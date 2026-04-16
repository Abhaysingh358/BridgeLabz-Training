
namespace FactoryRobotHazardAnalyzer
{
    public class RobotSafetyException : Exception
    {
        // Implementing the common constructor 
        public RobotSafetyException(){} 

        public RobotSafetyException(string message) : base(message)
        { }

        public RobotSafetyException(string message , Exception innerException) : base (message , innerException)
        {
            
        }
    }
}