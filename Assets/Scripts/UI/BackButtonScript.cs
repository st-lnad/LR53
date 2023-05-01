using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackButtonScript : MonoBehaviour
{
    public void OnClick()
    {
        UIManagementScript.UI_activated = false;
        UIManagementScript.Inner_UI_activated = false;
    }
}
