public class Lasagna
{
    // Task 1: Define the expected oven time in minutes
    public int ExpectedMinutesInOven() => 40;

    // Task 2: Calculate the remaining oven time in minutes
    public int RemainingMinutesInOven(int minutesInOven) => ExpectedMinutesInOven() - minutesInOven;

    // Task 3: Calculate the preparation time in minutes
    public int PreparationTimeInMinutes(int layers) => layers * 2;

    // Task 4: Calculate the elapsed time in minutes
    public int ElapsedTimeInMinutes(int layers, int minutesInOven) => PreparationTimeInMinutes(layers) + minutesInOven;
}
