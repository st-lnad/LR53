using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Road : MyEntity
{
    public float move_time = 50;
    public Village[] villages = new Village[2];

    public void init(GameObject[] villages)
    {
        this.villages[0] = villages[0].GetComponent<Village>();
        this.villages[1] = villages[1].GetComponent<Village>();

        // Добавляем компонент Line Renderer к объекту дороги
        gameObject.AddComponent<LineRenderer>();

        // Устанавливаем ширину линии
        gameObject.GetComponent<LineRenderer>().startWidth = 0.2f;
        gameObject.GetComponent<LineRenderer>().endWidth = 0.2f;

        // Устанавливаем точки линии дороги
        gameObject.GetComponent<LineRenderer>().positionCount = 2;
        gameObject.GetComponent<LineRenderer>().SetPosition(0, villages[0].transform.position);
        gameObject.GetComponent<LineRenderer>().SetPosition(1, villages[1].transform.position);
    }
    public Village[] get_villages()
    {
        return villages;
    }
    public int get_direction(Vector3 current_position)
    {

        return ((villages[0].transform.position == current_position) ? 1 : -1); 
    }
    
}
