using UnityEngine;
using TMPro;

public class UIInventario : MonoBehaviour
{
    public TextMeshProUGUI textoMonedas;

    void Update()
    {
        textoMonedas.text = "Monedas: " + InventarioJugador.instancia.monedas;
    }
}
