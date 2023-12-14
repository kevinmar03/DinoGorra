using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoPersonaje : MonoBehaviour
{
    [SerializeField] Animator animator;
    [SerializeField] Rigidbody2D rigidBody;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        rigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            animator.SetBool("AccionSalto", true);
        }
        if (Input.GetKeyUp(KeyCode.V))
        {
            animator.SetBool("AccionSalto", false);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
    }
}
