using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineMovement : Movement
{   
    
    public void init(Vector3 from, Vector3 to, float time)
    {
            this.from = from;
            this.to = to;
            movement_time = time;
            is_movement_allowed = true;
    }
    public new void cancel()
    {
        var tmp = to;
        to = from;
        from = tmp;
        elapsedTime = movement_time - elapsedTime;

    }

    // Start is called before the first frame update
    void Start()
    {
        is_movement_allowed = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (is_movement_allowed) { 
            elapsedTime += Time.deltaTime;
            if (gameObject.transform.position != to)
            {
                gameObject.transform.position =  Vector3.Lerp(from, to, elapsedTime/movement_time);
            }
            else
            {
                elapsedTime = 0f;
                is_movement_allowed = false;
            }
        }
    }
}
