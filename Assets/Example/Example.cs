using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class respond : MonoBehaviour
{
    public void home()
    {

        if (SystemInfo.supportsVibration)
        {
            Handheld.Vibrate();
        }

    }
}