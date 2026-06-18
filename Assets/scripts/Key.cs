using UnityEngine;

public class Key : MonoBehaviour, IInteractuable
{
    public GameObject[] paredesSecretas;

    public void Interactuar()
    {
        InventarioJugador.instancia.tieneLlave = true;
        Debug.Log("¡Pastel recogido!");

        foreach (GameObject pared in paredesSecretas)
        {
            if (pared != null)
                pared.SetActive(false);
        }

        gameObject.SetActive(false);
    }
}