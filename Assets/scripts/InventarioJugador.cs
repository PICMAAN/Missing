using UnityEngine;

public class InventarioJugador : MonoBehaviour
{
    public static InventarioJugador instancia;
    public bool tieneLlave = false;
    public int monedas = 0;

    void Awake()
    {
        instancia = this;
    }

    public void AgregarMoneda()
    {
        monedas++;
        Debug.Log("Monedas: " + monedas);
    }
}