using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KorovanMovement : LineMovement
{
    int direction;

    public void init(GameObject road)
    {
        if (!is_moving) { 
            direction = road.GetComponent<Road>().get_direction(gameObject.transform.position);
            Debug.Log(direction);
            is_moving = true;
            movement_time = road.GetComponent<Road>().move_time;
            GameObject[] villages = road.GetComponent<Road>().get_villages();

            if (direction == 1)
            {
                to = villages[1].transform.position;
                from = villages[0].transform.position;
            }
            else
            {
                to = villages[0].transform.position;
                from = villages[1].transform.position;
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        elapsedTime += Time.deltaTime;
        if (gameObject.transform.position != to)
        {
            var a = Time.deltaTime;
            gameObject.transform.position = Vector3.Lerp(from, to, elapsedTime / movement_time);
        }
        else
        {
            elapsedTime = 0f;
            is_moving = false;
        }
    }
}
