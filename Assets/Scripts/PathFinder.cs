using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathFinder : MonoBehaviour
{
    public GameObject[] places; 
    public GameObject[] roads;

    
    // Start is called before the first frame update
    void Start()
    {
        places = GameObject.FindGameObjectsWithTag("Place");
        roads = GameObject.FindGameObjectsWithTag("Road");
    }

    public List<GameObject> get_neighbors(GameObject place)
    {
        List<GameObject> res = new List<GameObject>();
        foreach (var road in roads)
        {
            var ends = road.GetComponent<Road>().get_ends();
            if (ends[0] == place)
            {
                res.Add(ends[1]);
            }
            else if (ends[1] == place)
            {
                res.Add(ends[0]);
            }
        }
        return res;
    }

    public GameObject get_place_by_korovan_position(Vector3 korovan_position)
    {
        foreach (var place in places)
        {
            if (place.transform.position == korovan_position)
            {
                return place;
            } 
        }
        return null;
    }

    public GameObject find_near_position(Vector3 click_position, float esp)
    {
        foreach (var place in places)
        {
            if ((place.transform.position - click_position).magnitude <= esp)
            {
                return place;
            }
        }
        return null;
    }

    public GameObject get_road(GameObject place, GameObject korovan)
    {
        GameObject place1 = get_place_by_korovan_position(gameObject.transform.position);
        foreach (var road in roads)
        {
            var road_ends = road.GetComponent<Road>().get_ends();
            if ((road_ends[0] == place1 && road_ends[1] == place) || (road_ends[1] == place1 && road_ends[0] == place)) return road;

        }
        return null;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
