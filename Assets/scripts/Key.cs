using UnityEngine;

public class Key : MonoBehaviour, IInteractuable
{
    public void Interactuar()
    {
        InventarioJugador.instancia.tieneLlave = true;
        Debug.Log("¡Llave recogida!");
        gameObject.SetActive(false);
    }
}