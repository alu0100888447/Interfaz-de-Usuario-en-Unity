using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    public delegate void _ChangeColor();
    public static event _ChangeColor ChangeColor;

    public delegate void _ChangeScale();
    public static event _ChangeScale ChangeScale; 

    public static void ChangeBlocksColor ()
    {
        if (ChangeColor != null)
        {
            ChangeColor();
        }
    }

    public static void ChangeBlocksScale()
    {
        if (ChangeScale != null)
        {
            ChangeScale();
        }
    }
}
