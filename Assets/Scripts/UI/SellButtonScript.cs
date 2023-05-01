using UnityEngine;
using UnityEngine.UI;

public class SellButtonScript : MonoBehaviour
{
    public int Good_Type;
    public InputField Good_Amount;
    public Text Good_TotalPrice;

    public GameObject korovan;

    public void Sell()
    {
        if (((korovan.GetComponent<PathFinder>().get_place_by_korovan_position(korovan.transform.position).GetComponent<Village>().Capacity[Good_Type] -
            korovan.GetComponent<PathFinder>().get_place_by_korovan_position(korovan.transform.position).GetComponent<Village>().Inventory[Good_Type]) >= int.Parse(Good_Amount.text)) &&
            korovan.GetComponent<Korovan>().Inventory[Good_Type] >= int.Parse(Good_Amount.text))
        {
            korovan.GetComponent<Korovan>().money += int.Parse(Good_TotalPrice.text);
            korovan.GetComponent<Korovan>().Inventory[Good_Type] -= int.Parse(Good_Amount.text);
            korovan.GetComponent<PathFinder>().get_place_by_korovan_position(korovan.transform.position).GetComponent<Village>().Inventory[Good_Type] += int.Parse(Good_Amount.text);
        }
    }
}
