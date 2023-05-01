using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Encounters
{
    struct Options
    {
        string button_text;
        int internal_value;
    }
    public struct Enc
    {
        int type; //-1 - плохой, 0 - нейтральный, 1 - хороший
        string flavor_start;
        
    }
}
