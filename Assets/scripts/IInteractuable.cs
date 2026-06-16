using UnityEngine;

public class InventarioJugador : MonoBehaviour
{
    public static InventarioJugador instancia;
    public bool tieneLlave = false;

    void Awake()
    {
        instancia = this;
    }
}