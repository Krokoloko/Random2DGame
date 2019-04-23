using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    [SerializeField]
    private float speed;

    public void jump(float axis)
    {
        gameObject.transform.Translate(new Vector2());
    }
}
