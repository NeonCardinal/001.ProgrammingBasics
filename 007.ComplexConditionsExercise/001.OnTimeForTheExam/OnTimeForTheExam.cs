//Complex conditions - exercise, Task 001
//18.01.2024, 23:20
using System;

public class OnTimeForTheExam
{
    static void Main()
    {
        int examHours = int.Parse(Console.ReadLine());
        int examMinutes = int.Parse(Console.ReadLine());
        int arrivalHours = int.Parse(Console.ReadLine());
        int arrivalMinutes = int.Parse(Console.ReadLine());

        string late = "Late";
        string onTime = "In time";
        string early = "Early";

        int examTime = (examHours * 60) + examMinutes;
        int arrivalTime = (arrivalHours * 60) + arrivalMinutes;

        int totalMinutesDiffernce = arrivalTime - examTime;

        string studentArrival = late;

        if(totalMinutesDiffernce < -30)
        {
            studentArrival = early;
        }
        else if(totalMinutesDiffernce == 0)
        {
            studentArrival = onTime;
        }

        string result = string.Empty;

        if(totalMinutesDiffernce != 0)
        {
            int hoursDiffernce = Math.Abs(totalMinutesDiffernce / 60);
            int minutesDiffernce = Math.Abs(totalMinutesDiffernce % 50);

            if(hoursDiffernce > 0)
            {
                result = string.Format("{0}:{1:00} hours", hoursDiffernce, minutesDiffernce);
            }
            else
            {
                result = minutesDiffernce + " minutes";
            }

            if(totalMinutesDiffernce < 0)
            {
                result += " before the start";
            }
            else
            {
                result += " after the start";
            }

            Console.WriteLine(studentArrival);

            if(!string.IsNullOrEmpty(result))
            {
                Console.WriteLine(result);
            }
        }
    }
}