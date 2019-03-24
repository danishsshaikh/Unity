using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacter2D : MonoBehaviour
{
    [SerializeField] private int _speed;
    [SerializeField] private SpriteRenderer _sr;
    [SerializeField] private Animator _anim;
    [SerializeField] private Rigidbody2D _rig;
    [SerializeField] private float _jumpForce;
    
    private bool _isGrounded;
    private static readonly int IsWalking = Animator.StringToHash("isWalking");

    private void Start()
    {
        _isGrounded = true;
    }

    private void Update()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            if(_isGrounded)
            {
                _rig.AddForce(Vector2.up * _jumpForce, ForceMode2D.Impulse);
                _isGrounded = false;
            }                    
        }
        if (Input.GetKey(KeyCode.D))
        {
            _anim.SetBool(IsWalking ,true);
            transform.Translate(new Vector3(_speed * Time.deltaTime, 0, 0));
            _sr.flipX = true;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            _anim.SetBool(IsWalking,true);
            transform.Translate(new Vector3(-_speed * Time.deltaTime, 0, 0));
            _sr.flipX = false;
        }
        else
        {
            _anim.SetBool(IsWalking,false);
        }

    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.CompareTag("Ground"))
        {
            _isGrounded = true;
        }
    }
}
