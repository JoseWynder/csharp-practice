static class AssemblyLine
{
    private const int CarsPerHour = 221;
    
    public static double SuccessRate(int speed)
    {
        if(speed == 0) 
        {
            return 0.0;
        }
        
        if(speed >= 1 && speed <= 4)
        {
            return 1.0;
        }
        
        if(speed >= 5 && speed <= 8)
        {
            return 0.9;
        }
        
        if(speed == 9)
        {
            return 0.8;
        }
        
        if(speed == 10)
        {
            return 0.77;
        }
        
        throw new ArgumentOutOfRangeException(nameof(speed));

        // Equivalent solution using a switch expression.
        // The implementation using if statements was chosen to align with the exercise requirements.
        /*
            return speed switch 
            {
                0 => 0.00,
                >= 1 and <= 4 => 1.00,
                >= 5 and <= 8 => 0.90,
                9 => 0.80,
                10 => 0.77,
                _ => throw new ArgumentOutOfRangeException(nameof(speed))
            };
        */
    }
    
    public static double ProductionRatePerHour(int speed) => speed * CarsPerHour * SuccessRate(speed);

    public static int WorkingItemsPerMinute(int speed) => (int)(ProductionRatePerHour(speed) / 60);
}
