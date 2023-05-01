using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInnerTimer
{
    public static float hours;
    public static int days;
    public static float secs_per_day;

    public static int get_time_in_days()
    {
        return days;
    }

    public static void add_time_to_timer(float secs_in_real_time)
    {
        hours += (secs_in_real_time / secs_per_day) * 24;
        days = (int)(hours / 24);
    }

    // Start is called before the first frame update
    static GameInnerTimer()
    {
        hours = 0;
        secs_per_day = 0.75f;
    }
    
}
