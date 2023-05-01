using UnityEngine;
using UnityEngine.UI;

public class TalkToInnkeeperButtonScript : MonoBehaviour
{
    public Text gossip_text;

    public GameObject korovan;

    public int gossipPrice = 100;
    public void Talk()
    {
        if (korovan.GetComponent<Korovan>().money >= gossipPrice)
        {
            korovan.GetComponent<Korovan>().money -= gossipPrice;
            gossip_text.text = Gossips.CreateGossip(Random.Range(0, 2));
        } else
        {
            gossip_text.text = "You have no money!";
        }
    }

}
