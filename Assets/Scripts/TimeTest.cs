using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeTest : MonoBehaviour
{
    public int yesterday = 0;

    // Update is called once per frame
    void Update()
    {
        var dt = Time.deltaTime;
        GameInnerTimer.add_time_to_timer(dt);
        if (yesterday < GameInnerTimer.days)
        {
            yesterday = GameInnerTimer.days;
            MainThings.LifeGoesOn();
        };
    }
}
