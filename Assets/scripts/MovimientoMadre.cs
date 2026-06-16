using UnityEngine;

public class MovimientoMadre : MonoBehaviour
{
    private Rigidbody2D rig;
    private Animator anim;
    private SpriteRenderer spritePersonaje;
    public float velocidad = 5f;

    private IInteractuable objetoCercano = null;

    private void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        spritePersonaje = GetComponent<SpriteRenderer>();
    }

    private void FixedUpdate()
    {
        Movimiento();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
            Debug.Log("E presionada, objetoCercano: " + (objetoCercano != null ? "asignado" : "null"));

        if (Input.GetKeyDown(KeyCode.E) && objetoCercano != null)
            objetoCercano.Interactuar();
    }

    private void Movimiento()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        rig.linearVelocity = new Vector2(horizontal, vertical) * velocidad;
        anim.SetFloat("camina", rig.linearVelocity.magnitude);

        if (horizontal > 0)
            spritePersonaje.flipX = false;
        else if (horizontal < 0)
            spritePersonaje.flipX = true;
    }

    private void OnTriggerEnter2D(Collider2D otro)
    {
        Debug.Log("Trigger detectado: " + otro.gameObject.name);
        IInteractuable interactuable = otro.GetComponent<IInteractuable>();
        if (interactuable != null)
        {
            objetoCercano = interactuable;
            Debug.Log("Objeto interactuable asignado: " + otro.gameObject.name);
        }
    }

    private void OnTriggerExit2D(Collider2D otro)
    {
        IInteractuable interactuable = otro.GetComponent<IInteractuable>();
        if (interactuable != null && interactuable == objetoCercano)
        {
            objetoCercano = null;
            Debug.Log("Saliste del rango de: " + otro.gameObject.name);
        }
    }
}