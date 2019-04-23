using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestrictGoThroughCollision : MonoBehaviour
{
    public GameObject[] whatCantBeTransparent;
    public GameObject theObject;

    private Ray _ray;
    private Ray2D _ray2D;

    void Awake()
    {
        theObject = (theObject == null) ? theObject : gameObject;     
    }

    public float RestrainSpeed(Vector3 direction, float speed)
    {
        _ray = new Ray(theObject.transform.position, direction);
        RaycastHit hit;
        if (Physics.Raycast(_ray, out hit))
        {
            if (hit.distance >=)
            {

            }
            else
            {
                return speed;
            }
            
        }
        else
        {
            return speed;
        }
    }

    public float RestrainSpeed(Vector2 direction, float speed)
    {
        RaycastHit2D hit = Physics2D.Raycast(theObject.transform.position, direction);
        if (hit.distance <= _maxLength)
        {
            return
        }
    }
    


}
