using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoPersonaje : MonoBehaviour
{
    [SerializeField] Animator animator;
    [SerializeField] int alturaSalto;
    [SerializeField] Rigidbody2D rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Jump"))
        {
            animator.SetBool("AccionSalto", true);
            rigidbody.AddForce(Vector2.up * alturaSalto);
        }
        else
        {
            animator.SetBool("AccionSalto", false);
            rigidbody.velocity = Vector2.zero;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
    }
}
