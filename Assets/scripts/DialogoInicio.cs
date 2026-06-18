using UnityEngine;

public class DialogoInicio : MonoBehaviour
{
    public LineaDialogo[] dialogos;

    void Start()
    {
        if (DialogoManager.instancia != null)
            DialogoManager.instancia.IniciarDialogo(dialogos);
        else
            Debug.LogError("DialogoManager no encontrado");
    }
}