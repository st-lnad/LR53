using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class City : ProtoGorod
{

    // Start is called before the first frame update
    private void Start()
    {
        price_modifier = 5;
        for (int i = 0; i < 7; i++)
        {
            Capacity[i] = 5000;
            Inventory[i] = Capacity[i] / 2;
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }

   

}
