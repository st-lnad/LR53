using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SellerTest : MonoBehaviour
{
    public Village seller;

    public int amount;
    public int price;

    private void Update()
    {
       price = MainThings.getBuyPrice(3, amount,seller);
    }


}
