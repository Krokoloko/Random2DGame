using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController: MonoBehaviour
{
    private Vector2 _velocity;
    private Movement _movement;
    private Jump _jump;
    private MomentumBreaker _momentumBreaker;
    private RestrictGoThroughCollision _restricter;
    private SpriteRenderer _spriteRender;
    private float _moveSpeed, _jumpSpeed, _horAxis, _verAxis;

    [Tooltip("GameObject must be reference to Jump and Movement")]
    public GameObject mappedFrom;
    public float moveSpeed, jumpSpeed;



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
        _moveSpeed = moveSpeed;
        _jumpSpeed = jumpSpeed;
        _movement = mappedFrom.GetComponent<Movement>();
        _jump = mappedFrom.GetComponent<Jump>();
        _momentumBreaker = mappedFrom.GetComponent<MomentumBreaker>();
        _restricter = mappedFrom.GetComponent<RestrictGoThroughCollision>();
        _spriteRender = mappedFrom.GetComponent<SpriteRenderer>();
    }
    void Update()
    { 
        if (Input.GetAxis("Horizontal") != 0)
        {
            _horAxis = Input.GetAxis("Horizontal");
            _velocity.x = ((mappedFrom.transform.position + 
                new Vector3(_horAxis * moveSpeed, mappedFrom.transform.position.y) - mappedFrom.transform.position).x);

            _moveSpeed = Mathf.Abs(_restricter.RestrainSpeed(mappedFrom.transform.position + 
                //sprite size had to be devided by 10 because of the actual size it was compared to its origin.
                new Vector3((_velocity.x<0&&_velocity.x!=0)?-(_spriteRender.sprite.rect.size.x/2/10):_spriteRender.sprite.rect.size.x/2/10,0)
                , new Vector2(_horAxis,0).normalized,Mathf.Abs(_velocity.x)));

            _movement.Move(_velocity.x*_moveSpeed,_verAxis*_jumpSpeed);
        }
        else
        {
            if(_velocity.x != 0)
            {
                _velocity.x = _momentumBreaker.MomentumBreakDown(_velocity.x, 0.001f);
            }
        }
    }
}
