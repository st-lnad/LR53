using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Road : MonoBehaviour
{
    public float move_time = 5;
    public GameObject[] ends = new GameObject[2];
    public Transform[] points = new Transform[4];


    public GameObject[] get_ends()
    {
        return ends;
    }
    public int get_direction(Vector3 current_position)
    {

        return ((ends[0].transform.position == current_position) ? 1 : -1); 
    }
    
}
