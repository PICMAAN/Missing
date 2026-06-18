using UnityEngine;

public class NPC : MonoBehaviour, IInteractuable
{
    public LineaDialogo[] dialogos;
    public GameObject[] paredesADestruir;

    private bool yaInteractuado = false;

    public void Interactuar()
    {
        if (!yaInteractuado)
        {
            yaInteractuado = true;

            foreach (GameObject pared in paredesADestruir)
            {
                if (pared != null)
                    pared.SetActive(false);
            }
        }

        DialogoManager.instancia.IniciarDialogo(dialogos);
    }
}