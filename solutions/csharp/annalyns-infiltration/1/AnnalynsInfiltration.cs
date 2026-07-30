static class QuestLogic
{
    public static bool CanFastAttack(bool knightIsAwake) => !knightIsAwake;

    public static bool CanSpy(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake) => knightIsAwake || archerIsAwake || prisonerIsAwake;

    public static bool CanSignalPrisoner(bool archerIsAwake, bool prisonerIsAwake) => !archerIsAwake && prisonerIsAwake;

    public static bool CanFreePrisoner(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake, bool petDogIsPresent)
    {    
        /*
            Alternative implementations explored while solving this exercise.
            Each implementation is correct, but they differ in readability,
            maintainability, and the clarity with which they express business rules.
        */
        
        // 1. Literal implementation
        // Direct translation of the problem statement.
        /*
            if(petDogIsPresent && !archerIsAwake) 
                return true;
            if(!petDogIsPresent && prisonerIsAwake && !knightIsAwake && !archerIsAwake) 
                return true;
            return false;
        */

        // 2. Literal implementation using a single boolean expression
        // The same logic as before, condensed into a single expression.
        /* 
            return (petDogIsPresent && !archerIsAwake) || !petDogIsPresent && !archerIsAwake && !knightIsAwake && prisonerIsAwake; 
        */

        // 3. Early return implementation
        // Optimizes the execution flow but makes business rules less explicit.
        /*
            if(archerIsAwake) 
                return false;
            if(petDogIsPresent)
                return true;
            if(knightIsAwake)
                return false;
            return prisonerIsAwake;
        */

        // 4. Factored boolean expression
        /* 
            return !archerIsAwake && (petDogIsPresent || !knightIsAwake && prisonerIsAwake); 
        */

        // 5. Preferred implementation
        // The best balance between readability, maintainability, and clear representation of business rules.
        bool canRescueWithDog = petDogIsPresent && !archerIsAwake;
        bool canRescueWithoutDog = !petDogIsPresent && !archerIsAwake && !knightIsAwake && prisonerIsAwake;
        
        return canRescueWithDog || canRescueWithoutDog;
    }
}
