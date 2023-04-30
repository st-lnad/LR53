using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VillageManagementScript : MonoBehaviour
{
    public GameObject korovan;

    public GameObject Village1;
    public GameObject Village2;
    public GameObject Village3;
    public GameObject Village4;
    public GameObject Village5;
    public GameObject Village6;
    public GameObject Village7;
    public GameObject Village8;
    public GameObject Village9;
    public GameObject Village10;
    public GameObject Village11;

    private GameObject[] villages;

    private void Start()
    {
        villages = new GameObject[]{ Village1, Village2, Village3, Village4, Village5, Village6, Village7, Village8, Village9, Village10, Village11 };
    }

    void Update()
    {

        foreach (GameObject obj in villages)
        {
            obj.GetComponent<VillageMenuScript>().status = 2;

            foreach (GameObject obj_nei in korovan.GetComponent<PathFinder>().get_neighbors(korovan.GetComponent<PathFinder>().get_place_by_korovan_position(korovan.transform.position)))
            {
                if (obj.transform.position == obj_nei.transform.position)
                {
                    obj.GetComponent<VillageMenuScript>().status = 1;
                }
            }

            if (obj.transform.position == korovan.GetComponent<PathFinder>().get_place_by_korovan_position(korovan.transform.position).transform.position)
            {
                obj.GetComponent<VillageMenuScript>().status = 0;
            }

        }
    }
}
