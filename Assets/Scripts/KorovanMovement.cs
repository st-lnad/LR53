using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KorovanMovement : MonoBehaviour
{
    public int direction;
    public bool is_init_allowed;
    protected float movement_time;
    public Vector3 to;
    public Vector3 from;

    public void init(GameObject road)
    {
        if (is_init_allowed)
        {
            Debug.Log("Okey");
            is_init_allowed = false;
            direction = road.GetComponent<Road>().get_direction(gameObject.transform.position);
            movement_time = road.GetComponent<Road>().move_time;
            Transform[] raw_points = road.GetComponent<Road>().points;
            List<Vector3> points = new List<Vector3>();

            foreach (var point in raw_points)
            {
                points.Add(point.position);
            }
            
            if (direction == 1)
            {
                gameObject.GetComponent<BezierMovement>().init(points, movement_time);
            }
            else
            {

                points.Reverse();
                gameObject.GetComponent<BezierMovement>().init(points, movement_time);
            }
            from = points[0];
            to = points[points.Count - 1];


        }
    }

    // Start is called before the first frame update
    void Start()
    {
        is_init_allowed = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.transform.position == to)
        {
            is_init_allowed = true;
        }
        //elapsedTime += Time.deltaTime;
        //if (gameObject.transform.position != to)
        //{
        //    var a = Time.deltaTime;
        //    gameObject.transform.position = Vector3.Lerp(from, to, elapsedTime / movement_time);
        //}
        //else
        //{
        //    elapsedTime = 0f;
        //    is_moving = false;
        //}
    }
}
