using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainThings
{
    public static GameObject[] villages;
    public static int[] BasicCost = new int[7];
    public static string[] stock_name = new string[7];
    public static int[] weight = new int[7];
    static MainThings()
    {

        villages = GameObject.FindGameObjectsWithTag("Place");
        BasicCost[0] = 100; //хлеб
        BasicCost[1] = 200; //Дерево
        BasicCost[2] = 200; //Уголь
        BasicCost[3] = 200; //Железо
        BasicCost[4] = 500; //Сталь
        BasicCost[5] = 800; //Инструменты
        BasicCost[6] = 2000; //Мебель
        stock_name[0] = "Хлеб";
        stock_name[1] = "Дерево";
        stock_name[2] = "Уголь";
        stock_name[3] = "Железо";
        stock_name[4] = "Сталь";
        stock_name[5] = "Инструменты";
        stock_name[6] = "Мебель";
        weight[0] = 1;
        weight[1] = 5;
        weight[2] = 5;
        weight[3] = 5;
        weight[4] = 5;
        weight[5] = 5;
        weight[6] = 5;
    }
    public static int getBuyPrice(int slot, int amount, Village Seller)
    {
        int price = 0;
        float AmountDependency;
        for (int i = 0; i < amount; i++)
        {
            AmountDependency = (float)(Seller.Capacity[slot] - 2*Seller.Inventory[slot] + i)/Seller.Capacity[slot];
            price += (int)(((Mathf.Pow(Seller.price_modifier,AmountDependency)  + 0.1) * MainThings.BasicCost[slot]));
        }
        return price;
    }
   public static int getSellPrice(int slot, int amount, Village Seller)
    {
        int price = 0;
        float AmountDependency;
        for (int i = 0; i < amount; i++)
        {
            AmountDependency = (float)(Seller.Capacity[slot] - 2 * Seller.Inventory[slot] - i) / Seller.Capacity[slot];
            price += (int)(((Mathf.Pow(Seller.price_modifier, AmountDependency) - 0.1) * MainThings.BasicCost[slot]));
        }
        return price;
    }

    public static void LifeGoesOn()
    {
    
        foreach (GameObject Village in MainThings.villages)
        {
            Village.GetComponent<Village>().Order.product = Random.Range(0, 7);
            Village.GetComponent<Village>().Order.value = Random.Range(0, 3);
            Village.GetComponent<Village>().Order.village = MainThings.villages[Random.Range(0, MainThings.villages.Length)].GetComponent<Village>();
            for (int i = 1; i < 7; i++)
            {
                if (Village.GetComponent<Village>().IsHere[i])
                {
                    if (Village.GetComponent<Village>().village_type == i)
                    {
                        Village.GetComponent<Village>().Inventory[i] += (int) (50000 / MainThings.BasicCost[i] * Random.Range(0.5f,1.5f));
                    }
                    else
                    {
                        if (Village.GetComponent<Village>().Inventory[i] < Village.GetComponent<Village>().Capacity[i] / 2)
                        {
                            Village.GetComponent<Village>().Inventory[i] +=  Random.Range(0, Village.GetComponent<Village>().Capacity[i] / 50);
                        }
                        else
                        {
                            Village.GetComponent<Village>().Inventory[i] -= Random.Range(0, Village.GetComponent<Village>().Capacity[i] / 50);
                        }
                    }
                }
                Village.GetComponent<Village>().Inventory[i] = Mathf.Min(Village.GetComponent<Village>().Inventory[i], Village.GetComponent<Village>().Capacity[i]);
            }
            if (Village.GetComponent<Village>().village_type == 0) 
            { 
                Village.GetComponent<Village>().Inventory[0] += (int)(500 * Random.Range(0.5f, 1.5f));
                Village.GetComponent<Village>().Inventory[0] = Mathf.Min(Village.GetComponent<Village>().Inventory[0], Village.GetComponent<Village>().Capacity[0]);
            }
            else
            {

                if (Village.GetComponent<Village>().village_type < 0)
                {
                    Village.GetComponent<Village>().Inventory[0] -= (int)(100 * Random.Range(0.0f, 1.0f));
                }
                else
                {
                    Village.GetComponent<Village>().Inventory[0] -= (int)(10 * Random.Range(0.0f, 1.0f));
                }
            }
            Village.GetComponent<Village>().Inventory[0] = Mathf.Max(Village.GetComponent<Village>().Inventory[0], 0);
        }
    }




}
