using UnityEngine;

public class VillageMenuScript : MonoBehaviour
{
    public GameObject Menu0_0;
    public GameObject Menu0_1;
    public GameObject Menu1;
    public GameObject Menu2;
    public int status;
    public int tipe;

    private void OnMouseDown()
    {
        if (status == 1)
        {
            if (Menu1.activeSelf == true && UIManagementScript.UI_activated == true)
            {
                Menu1.SetActive(false);
                UIManagementScript.UI_activated = false;
            }
            else if (Menu1.activeSelf == false && UIManagementScript.UI_activated == false)
            {
                Menu1.SetActive(true);
                UIManagementScript.UI_activated = true;
            }
        }
        else if (status == 2)
        {
            if (Menu2.activeSelf == true && UIManagementScript.UI_activated == true)
            {
                Menu2.SetActive(false);
                UIManagementScript.UI_activated = false;
            }
            else if (Menu2.activeSelf == false && UIManagementScript.UI_activated == false)
            {
                Menu2.SetActive(true);
                UIManagementScript.UI_activated = true;
            }
        }
        else if (status == 0 && tipe == 0)
        {
            if (Menu0_0.activeSelf == false && UIManagementScript.UI_activated == false)
            {
                Menu0_0.SetActive(true);
                UIManagementScript.UI_activated = true;
            }
        }
        else if (status == 0 && tipe == 1)
        {
            if (Menu0_1.activeSelf == false && UIManagementScript.UI_activated == false)
            {
                Menu0_1.SetActive(true);
                UIManagementScript.UI_activated = true;
            }
        }


    }
}
