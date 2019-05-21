using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestrictGoThroughCollision : MonoBehaviour
{
    public GameObject[] whatCanBeTransparent;

    private Ray _ray;
    private Ray2D _ray2D;

    ///How to avoid collision based on travel:
    ///Our x will be based on the axis input which will be called 'X'.
    ///Our first vector we are gonna define is our speed which we will call 'V'.
    ///Take the position vector which we call 'P'.
    ///
    ///First we will define how much distance it will travel which is 'D' = 'P' + 'V' - 'P'
    ///
    ///Knowing what our distance is that we will travel, we can now avoid being truly collided.
    ///This will be done by substracting 'D' with the distance between the player and the raycasted collider which is 'R'.
    ///So we will get something like 'R' = 'D'-('D' - 'S')

    public float RestrainSpeed(Vector3 position, Vector3 direction, float travel)
    {
        _ray = new Ray(position, direction);
        RaycastHit hit;
        if (Physics.Raycast(_ray, out hit))
        {
            Debug.DrawLine(_ray.origin, hit.point, Color.red);

            if (hit.distance <= travel)
            {
                foreach (GameObject obj in whatCanBeTransparent){
                    if (obj.Equals(hit.collider.gameObject))
                    {
                        return travel;
                    }
                }
                Debug.Log("subtracting speed");
                return travel-(travel - hit.distance)-0.01f;
            }
            else
            {
                return travel;
            }
            
        }
        else
        {
            return travel;
        }
    }
}
