using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineMovement : MonoBehaviour
{
    protected Vector3 from;
    protected Vector3 to;
    //Vector3 increment;
    protected float movement_time;
    protected float elapsedTime = 0.0f;
    protected bool is_moving = false;
    
    
    public void init(Vector3 from, Vector3 to, float time)
    {
        if (!is_moving) {
            is_moving = true;
            this.from = from;
            this.to = to;
            movement_time = time;
            }
        else
        {
            Debug.Log("Object is moving. Fuck you");
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
            gameObject.transform.position =  Vector3.Lerp(from, to, elapsedTime/movement_time);
        }
        else
        {
            elapsedTime = 0f;
            is_moving = false;
        }
    }
}
