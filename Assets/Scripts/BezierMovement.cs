using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BezierMovement : Movement
{
    public Vector3 P0;
    public Vector3 P1;
    public Vector3 P2;
    public Vector3 P3;
    [Range(0, 1)]
    public float t=0.0f;
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
            gameObject.GetComponent<GameInnerTimer>().add_time_to_timer(dt);
            elapsedTime += dt;
            if (gameObject.transform.position != to)
            {
                t = elapsedTime / movement_time;

                gameObject.transform.position = Bezier.GetPoint(P0, P1, P2, P3, t);
            }
            else
            {
                elapsedTime = 0f;
                is_movement_allowed = false;
            }
        }
        //korovan.transform.position = Bezier.GetPoint(P0.position, P1.position, P2.position, P3.position, t);
    }

}