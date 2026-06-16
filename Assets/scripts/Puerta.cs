using UnityEngine;

public class Puerta : MonoBehaviour, IInteractuable
{
    private Animator animador;
    private bool abierta = false;

    void Start()
    {
        animador = GetComponent<Animator>();
    }

    public void Interactuar()
    {
        if (abierta) return;

        if (InventarioJugador.instancia.tieneLlave)
        {
            animador.SetTrigger("Abrir");
            abierta = true;
            Debug.Log("¡Puerta abierta!");
        }
        else
        {
            Debug.Log("Necesitas la llave.");
        }
    }
}