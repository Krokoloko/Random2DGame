using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField]
    private float xSpeed;
    [SerializeField]
    private float ySpeed;

    public void Move(float xAxis,float yAxis)
    {
        gameObject.transform.Translate(new Vector2(xAxis * xSpeed, yAxis * ySpeed));
    }
}
