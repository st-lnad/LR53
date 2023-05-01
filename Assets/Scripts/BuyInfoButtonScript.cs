using UnityEngine;
using UnityEngine.UI;

public class BuyInfoButtonScript : MonoBehaviour
{
    public Text gossip_text;

    public GameObject korovan;

    public int gossipPrice = 30000;
    public void BuyInfo()
    {
        if (korovan.GetComponent<Korovan>().money >= gossipPrice)
        {
            korovan.GetComponent<Korovan>().money -= gossipPrice;
            gossip_text.text = Gossips.CreateGossip(Random.Range(2, 4));
        } else
        {
            gossip_text.text = "You have no money!";
        }
    }
}
