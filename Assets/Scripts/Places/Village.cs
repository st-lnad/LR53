using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Village : ProtoGorod
{
    public int village_type;
    public Gossips.OrderNeeds Order;
    public int test;
    public string village_name;
    public int MaxPopulation;

    public Vector3 get_position()
    {
        return transform.position;
    }

    private void Start()
    {
        population = 1000;
        price_modifier = 3;
        for (int i = 0; i < 7; i++) {
            if (village_type == i) {
                population = 100;
                price_modifier = 2;
                Capacity[i] = 1000;
            }
            else
            {
                Capacity[i] = 500;
            }

            if (village_type == -1)
            {
                Capacity[i] *= 10;
            }
            IsHere[i] = true;
            Inventory[i] = Capacity[i] / 2;


        }
        MaxPopulation = population * 2;
    }
    private void Update()
    {
        test = Order.value;
    }

}
