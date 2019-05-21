using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    
    public float horiSpeed;
    
    public float vertSpeed;

    public void Move(float xAxis,float yAxis)
    {
        gameObject.transform.Translate(new Vector2(xAxis, yAxis));
    }
    public void Move(float xAxis, float yAxis, float xSpeed, float ySpeed)
    {
        gameObject.transform.Translate(new Vector2(xAxis * xSpeed, yAxis * ySpeed));
    }
}
