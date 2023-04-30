using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMap : MonoBehaviour
{
    public GameObject villagePrefab;
    public GameObject korovanPrefab;
    public GameObject roadPrefab;

    private GameObject road1;
    private GameObject korovan;
    
    //private GameObject make_road(GameObject[] villages)
    //{
    //    GameObject road = new GameObject("Road");
    //    road.AddComponent<Road>();
    //    road.GetComponent<Road>().init(villages);

    //    return road;
    //}

    private void Start()
    {
        /*
        // Создаем первую деревню
        GameObject village1 = Instantiate(villagePrefab, new Vector3(0, 0, 0), Quaternion.identity);
        village1.name = "Village1";
        // Создаем первую деревню
        GameObject village1 = Instantiate(villagePrefab, new Vector3(0, 0, 0), Quaternion.identity);
        village1.name = "Village1";

        // Создаем вторую деревню
        GameObject village2 = Instantiate(villagePrefab, new Vector3(5, 0, 0), Quaternion.identity);
        village2.name = "Village2";

        // Создаем объект дороги
        //road1 = make_road(new GameObject[]{ village1, village2});

        
         Создаем корован
        korovan = Instantiate(korovanPrefab, new Vector3(0, 0, 0), Quaternion.identity);
        korovan.name = "Korovan";
        
        // Создаем корован
        korovan = Instantiate(korovanPrefab, new Vector3(0, 0, 0), Quaternion.identity);
        korovan.name = "Korovan";
        */
    }

    private void FixedUpdate()
    {

    }


}
