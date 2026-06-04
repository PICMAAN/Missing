using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.ShaderGraph.Internal;
using UnityEngine;

public class MovimientoMadre : MonoBehaviour
{
    private Rigidbody2D rig;
    private Animator anim;
    private SpriteRender spritePersonaje;

    {
        rig = GetComponent<Rigidbody2D>();
        anim = GetComponetChildren<Animator>();
        spritePersonaje = GetComponetChildren<SpriteRenderer>();
}

    private void FixedUpdate()
    {
    Movimiento();
    }

    private void Movimiento()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical")

        rig.velocity = new Vector2(horizontal, vertical) * velocidad;
        anim.SetFloat("camina", Mathf.Abs(rig.velocity.magnitude));

    if (horizontal > 0)
    {
        spritePersonaje.flipX = false
    }
    else if (vertical > 0) 
    {
        spritePersonaje.flipX = true
    }
}
