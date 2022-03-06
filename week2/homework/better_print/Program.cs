// See https://aka.ms/new-console-template for more information
var time = new JupiterTime(1, 20);
var timeIn20Minutes = time.AddMinutes(-101);


Console.WriteLine(timeIn20Minutes);

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
    public override string ToString()
    {
        return "Time: " + Hours + ":" + Minutes;
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
        return new JupiterTime(Hours, Minutes);

    }

    public JupiterTime AddMinutes(int minutesToAdd)
    {
        var totalMins = Math.Abs(Minutes + minutesToAdd);
        if (totalMins >= 60)
        {
            var extraHours = totalMins / 60;
            totalMins %= 60;
            Minutes = totalMins;
            if (minutesToAdd < 0)
            {
                extraHours = -extraHours;
                if (totalMins != 0)
                {
                    Minutes = 60 - totalMins;
                    extraHours--;
                }
            }

            this.AddHours(extraHours);
        }
        else
        {
            Minutes = totalMins;
            if (minutesToAdd < 0)
            {
                this.AddHours(-1);
                Minutes = 60 - totalMins;
            }
        }

        return new JupiterTime(Hours, Minutes);
    }

}
