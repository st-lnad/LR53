using UnityEngine;

public class VillageMenuScript : MonoBehaviour
{
    public GameObject Menu0;
    public GameObject Menu1;
    public GameObject Menu2;

    private void OnMouseDown()
    {
        print("Clicked");
        if (Menu2.activeSelf == true)
        {
            print("Try set false");
            Menu2.SetActive(false);
            print("Set false");
        }
        else if (Menu2.activeSelf == false)
        {
            print("Try set true");
            Menu2.SetActive(true);
            print("Set true");
        }
        print("Done");
        
    }
}
