using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MomentumBreaker : MonoBehaviour
{
    public float MomentumBreakDown(float speed,float breakDownSpeed)
    {
        if (speed != 0)
        {
            return Mathf.Lerp(speed, 0, breakDownSpeed);
        }
        else
        {
            return speed;
        }
    }
    public float MomentumBreakDown(float speed)
    {
        if(speed != 0)
        {
            return Mathf.Lerp(speed, 0, 0.5f);
        }
        else
        {
            return speed;
        }
    }
}
