using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float velocidadX = 10;    // Horizontal (para movimiento horizontal) 
    public float velocidadY = 10;    // Vertical (para el salto) 
    // El componente Rigidbody del personaje (para f�sica) 
    private Rigidbody2D rb;

    private Animator animator; //velocidad

    private SpriteRenderer rendererMario;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        rendererMario = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        float movHorizontal = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(movHorizontal * velocidadX, rb.velocity.y);
        float movVertical = Input.GetAxis("Jump");      // [0, 1]
        if (movVertical > 0)
        {
            GetComponent<Rigidbody2D>().AddForce(Vector2.up * velocidadY);
        }
        //Cambiar animacion
        animator.SetFloat("velocidad", Mathf.Abs(rb.velocity.x));
        animator.SetFloat("velocidad", Mathf.Abs(rb.velocity.y));
        //Cambiar direccion 
        rendererMario.flipX = rb.velocity.x < 0;
    }
}
