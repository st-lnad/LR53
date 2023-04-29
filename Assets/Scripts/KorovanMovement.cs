using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KorovanMovement : MonoBehaviour
{
    float movement_time;
    GameObject road_for_moving;
    int direction;
    float speed;
    Vector3 increament;
    Vector3 endpoint;
    bool need_movement = false;

    

    Vector3 get_end()
    {
        return road_for_moving.GetComponent<Road>().get_villages()[((direction == 1) ? 1 : 0)].transform.position;
            
    }

    public void init(Vector3 current_position, GameObject road)
    {
        //Debug.Log(current_position.ToString());
        //Debug.Log(road.GetComponent<Road>().move_time.ToString());
        need_movement = true;
        road_for_moving = road;
        movement_time = road.GetComponent<Road>().move_time;
        direction = road_for_moving.GetComponent<Road>().get_direction(current_position);
        speed = 1.0f;
        Village[] villages = road_for_moving.GetComponent<Road>().get_villages();
        if (direction == 1)
        {
            endpoint = villages[1].transform.position;
            increament = (villages[1].transform.position - villages[0].transform.position) / movement_time;
        }
        else
        {
            endpoint = villages[0].transform.position;
            increament = (villages[0].transform.position - villages[1].transform.position) / movement_time;
        }
    }

    public Vector3 get_increment()
    {
        if (transform.position != endpoint)
        {
            return increament;
        }
        else
        {
            return new Vector3(0, 0, 0);
        }
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (need_movement)
        {
            transform.Translate(get_increment());
            if (transform.position == get_end())
            {
                need_movement = false;
            }
        }
    }
}
