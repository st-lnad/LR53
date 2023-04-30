using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    protected Vector3 from;
    protected Vector3 to;
    protected float movement_time;
    protected bool is_movement_allowed;
    protected float elapsedTime = 0.0f;

    public void init()
    {

    }
    public void pause()
    {
        is_movement_allowed = false;
    }

    public void resume()
    {
        is_movement_allowed = true;
    }
    public void cancel()
    {

    }
}
