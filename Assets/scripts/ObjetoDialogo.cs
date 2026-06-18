using UnityEngine;

public class ObjetoDialogo : MonoBehaviour, IInteractuable
{
    public LineaDialogo[] dialogos;

    public void Interactuar()
    {
        DialogoManager.instancia.IniciarDialogo(dialogos);
    }
}