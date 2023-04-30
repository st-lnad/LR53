using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Road : MyEntity
{
    public float move_time = 5;
    public GameObject[] villages = new GameObject[2];

    public void init(GameObject[] villages)
    {
        this.villages[0] = villages[0];
        this.villages[1] = villages[1];

        // ��������� ��������� Line Renderer � ������� ������
        gameObject.AddComponent<LineRenderer>();

        // ������������� ������ �����
        gameObject.GetComponent<LineRenderer>().startWidth = 0.2f;
        gameObject.GetComponent<LineRenderer>().endWidth = 0.2f;

        // ������������� ����� ����� ������
        gameObject.GetComponent<LineRenderer>().positionCount = 2;
        gameObject.GetComponent<LineRenderer>().SetPosition(0, villages[0].transform.position);
        gameObject.GetComponent<LineRenderer>().SetPosition(1, villages[1].transform.position);
    }
    public GameObject[] get_villages()
    {
        return villages;
    }
    public int get_direction(Vector3 current_position)
    {

        return ((villages[0].transform.position == current_position) ? 1 : -1); 
    }
    
}
