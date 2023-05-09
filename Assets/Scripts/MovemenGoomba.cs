using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovemenGoomba : MonoBehaviour
{

    public float velocidadX = -1;    // Horizontal (para movimiento horizontal)
    // El componente Rigidbody del personaje (para f�sica) 
    private Rigidbody2D rb;

    private SpriteRenderer rendererGoomba;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rendererGoomba = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(-velocidadX, 0);

        //Cambiar direccion 
        rendererGoomba.flipX = rb.velocity.x < 0;
    }
}
