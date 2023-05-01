using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gossips
{
    public struct OrderNeeds 
    {
        public Village village;
       public int product;
       public int value;
    }
    public static int[] cost = new int[6];
    public static string GossipMessage;
    public static string OrderMessage;
    static Gossips() {
        cost[0] = 100;
        cost[1] = 250;
        cost[2] = 500;
        cost[3] = 1000;
        cost[4] = 2500;
        cost[5] = 5000;
    }
    public static void CreateGossip(int value) 
    {
        int product = Random.Range(0, 7);
        GameObject village = MainThings.villages[Random.Range(0, MainThings.villages.Length)];
        if (Random.Range(0, 2) > 0)
        {
            GossipMessage = "Эй, я слышал, что в городе " + village.GetComponent<Village>().name + " внезапно выросла цена на " + MainThings.stock_name[product] + ". Должно быть, какой-то торговец выкупил все запасы.";
            village.GetComponent<Village>().Inventory[product] -= cost[value];
            village.GetComponent<Village>().Inventory[product] = Mathf.Max(village.GetComponent<Village>().Inventory[product], 0);
        }
        else
        {
            GossipMessage = "Эй, я слышал, что в городе " + village.GetComponent<Village>().name + " какой-то торговец все склады забил своим товаром! Теперь " + MainThings.stock_name[product] + " Там почти ничего не стоит!";
            village.GetComponent<Village>().Inventory[product] += cost[value];
            village.GetComponent<Village>().Inventory[product] = Mathf.Min(village.GetComponent<Village>().Inventory[product], village.GetComponent<Village>().Capacity[product]);
        }
        Debug.Log(GossipMessage);
    }

    public static void CreateOrder(OrderNeeds order)
    {
        int product = order.product;
        int amount = 100*cost[order.value]/MainThings.BasicCost[product];
        OrderMessage = "На доске объявлений висит заказ: \"Требуется " + MainThings.stock_name[product] + " в количестве " +  amount + "шт. Доставить в город "+ order.village.name+". Награда - " + 100*cost[order.value]*3/2 + " денег.";
    }
}
