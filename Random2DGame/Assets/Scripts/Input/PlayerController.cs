using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController: MonoBehaviour
{
    private Vector2 velocity;
    private Movement _movement;
    private Jump _jump;
    private MomentumBreaker _momentumBreaker;

    [Tooltip("GameObject must be reference to Jump and Movement")]
    public GameObject mappedFrom;

    /*Button Inputs for snes
     * 
     * joystick button 0 = X
     * joystick button 1 = A
     * joystick button 2 = B
     * joystick button 3 = Y
     * joystick button 4 = L
     * joystick button 5 = R
     * joystick button 8 = Select
     * joystick button 9 = Start
     * 
    */
    // Start is called before the first frame update
    void Awake()
    {
        _movement = mappedFrom.GetComponent<Movement>();
        _jump = mappedFrom.GetComponent<Jump>();
        _momentumBreaker = mappedFrom.GetComponent<MomentumBreaker>();
    }
    void Update()
    { 
        if (Input.GetAxis("Horizontal") != 0)
        {
            velocity.x = Input.GetAxis("Horizontal");
            _movement.Move(velocity.x,velocity.y);
        }
        else
        {
            velocity.x = _momentumBreaker.MomentumBreakDown(velocity.x,0.001f);
        }
    }
}
