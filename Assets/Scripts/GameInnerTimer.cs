using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInnerTimer : MonoBehaviour
{
    public float hours;
    public int days;
    public float secs_per_day;

    public int get_time_in_days()
    {
        return days;
    }

    public void add_time_to_timer(float secs_in_real_time)
    {
        hours += (secs_in_real_time / secs_per_day) * 24;
        days = (int)(hours / 24);
    }

    // Start is called before the first frame update
    void Start()
    {
        hours = 0;
    }
}
