using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Village : ProtoGorod
{
    public int village_type;

    public Vector3 get_position()
    {
        return transform.position;
    }
    
}
