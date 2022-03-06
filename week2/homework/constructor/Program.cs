// See https://aka.ms/new-console-template for more information
var time = new JupiterTime(9, 88);
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

        if (minutes > 60)
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
}