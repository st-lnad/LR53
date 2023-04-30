using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInnerTimer : MonoBehaviour
{
    private float hours;
    public float secs_per_day = 3;

    public int get_time_in_days()
    {
        return (int)(hours / 24);
    }

    public void add_time_to_timer(float secs_in_real_time)
    {
        hours += 1 / (secs_in_real_time / secs_in_real_time) * 24; 
    }

    // Start is called before the first frame update
    void Start()
    {
        hours = 0;
    }
}
