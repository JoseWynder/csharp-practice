class Lasagna
{
    private readonly int expectedMinutesInOven;
    private readonly int timePerLayer;

    public Lasagna(int expectedMinutesInOven, int timePerLayer) 
    {
        this.expectedMinutesInOven = expectedMinutesInOven;
        this.timePerLayer = timePerLayer;
    }

    public Lasagna() : this(40, 2) 
    {
    }
    
    // TODO: define the 'ExpectedMinutesInOven()' method
    public int ExpectedMinutesInOven() => this.expectedMinutesInOven;
    
    // TODO: define the 'RemainingMinutesInOven()' method
    public int RemainingMinutesInOven(int spentMinutesInOven) => this.expectedMinutesInOven - spentMinutesInOven;
    
    // TODO: define the 'PreparationTimeInMinutes()' method
    public int PreparationTimeInMinutes(int numberLayersAdded) => this.timePerLayer * numberLayersAdded;

    // TODO: define the 'ElapsedTimeInMinutes()' method
    public int ElapsedTimeInMinutes(int numberLayersAdded, int numberElapsedMinutesInOven) 
    {
        int totalPreparationTime = PreparationTimeInMinutes(numberLayersAdded);
        int totalElapsedTime = totalPreparationTime + numberElapsedMinutesInOven;
        return totalElapsedTime;
    }
}
