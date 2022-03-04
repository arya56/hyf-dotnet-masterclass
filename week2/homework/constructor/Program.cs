// See https://aka.ms/new-console-template for more information
var time = new JupiterTime(14, 88);
PrintTime(time);


void PrintTime(JupiterTime jtime)
{
    Console.WriteLine($"{jtime.Hours.ToString("D2")}:{jtime.Minutes.ToString("D2")}");
}
class JupiterTime
{
    public int Hours
    { get; set; }
    public int Minutes
    { get; set; }

    public JupiterTime(int hours, int minutes)
    {
        if (hours > 12)
        {
            hours %= 10;
        }
        if (minutes > 60)
        {
            var extraHours = minutes / 60;
            minutes %= 60;
            hours += extraHours;

        }
        Hours = hours;
        Minutes = minutes;
    }
}