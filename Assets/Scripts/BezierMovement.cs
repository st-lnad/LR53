using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BezierMovement : Movement
{
    public Vector3 P0;
    public Vector3 P1;
    public Vector3 P2;
    public Vector3 P3;
    private int yesterday;
    [Range(0, 1)]
    public float t=0.0f;
    public float esp = 0.001f;
    private void Start()
    {
        is_movement_allowed = false;
    }

    public void init(List<Vector3> points, float time)
    {
            from = points[0];
            to = points[points.Count - 1];
            movement_time = time;
            is_movement_allowed = true;
            P0 = points[0];
            P1 = points[1];
            P2 = points[2];
            P3 = points[3];

    }
    public new void cancel()
    {
        Vector3 tmp = to;
        to = from;
        from = tmp;
        elapsedTime = movement_time - elapsedTime;
        tmp = P0;
        P0 = P3;
        P3 = tmp;
        tmp = P1;
        P1 = P2;
        P2 = tmp;
    }

    

    void Update()
    {
        if (is_movement_allowed)
        {
            var dt = Time.deltaTime;
            GameInnerTimer.add_time_to_timer(dt);
            if (yesterday < GameInnerTimer.days) 
            {
                yesterday = GameInnerTimer.days;
                MainThings.LifeGoesOn();
            };
            elapsedTime += dt;
            if ((gameObject.transform.position - to).magnitude > esp)
            {
                t = elapsedTime / movement_time;

                gameObject.transform.position = Bezier.GetPoint(P0, P1, P2, P3, t);
            }
            else if ((gameObject.transform.position - to).magnitude <= esp && (gameObject.transform.position - to).magnitude > 0)
            {
                gameObject.transform.position = to;
            } else
            {
                t = 0.0f;
                elapsedTime = 0f;
                is_movement_allowed = false;
            }

        }
        //korovan.transform.position = Bezier.GetPoint(P0.position, P1.position, P2.position, P3.position, t);
    }

}