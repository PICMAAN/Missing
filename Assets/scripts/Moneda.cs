using UnityEngine;

public class Moneda : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D otro)
    {
        if (otro.CompareTag("Player"))
        {
            InventarioJugador.instancia.AgregarMoneda();
            Destroy(gameObject);
        }
    }
}