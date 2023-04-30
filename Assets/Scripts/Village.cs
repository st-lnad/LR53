using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Village : ProtoGorod
{
    public int village_type;
    

    public Vector3 get_position()
    {
        return transform.position;
    }

    private void Start()
    {
        price_modifier = 2;
        for (int i = 0; i < 7; i++) {
            if (village_type == i) {
                Capacity[i] = 1000;
            }
            else
            {
                Capacity[i] = 500;
            }

            Inventory[i] = Capacity[i] / 2;
        }
    }
    private void Update()
    {
        
    }

}
