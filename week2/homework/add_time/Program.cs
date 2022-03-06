// See https://aka.ms/new-console-template for more information
var time = new JupiterTime(2, 20);
var timeIn2Hours = time.AddHours(1);

PrintTime(timeIn2Hours);


void PrintTime(JupiterTime jtime)
{
    Console.WriteLine($"{jtime.Hours}:{jtime.Minutes.ToString("D2")}");
}
class JupiterTime
{
    public int Hours
    { get; set; }
    public int Minutes
    { get; set; }

    public JupiterTime(int hours, int minutes)
    {
        if (minutes >= 60)
        {
            var extraHours = minutes / 60;
            minutes %= 60;
            hours += extraHours;
        }
        if (hours >= 10)
        {
            hours %= 10;
        }

        Hours = hours;
        Minutes = minutes;
    }
    public JupiterTime AddHours(int timeToAdd)
    {

        Hours += timeToAdd;

        if (Hours < 0)
        {
            Hours += 10;

        }
        if (Hours >= 10)
        {
            Hours %= 10;
        }

        Hours = Math.Abs(Hours);
        if (Hours >= 10)
        {
            Hours %= 10;
        }
        return new JupiterTime(hours, minutes);

    }
}
