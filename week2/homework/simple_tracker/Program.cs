// See https://aka.ms/new-console-template for more information
var time = new JupiterTime();
time.Hours = 8;
time.Minutes = 9;
PrintTime(time);


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
}