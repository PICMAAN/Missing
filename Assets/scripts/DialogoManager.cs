using UnityEngine;
using TMPro;

public class DialogoManager : MonoBehaviour
{
    public static DialogoManager instancia;

    public GameObject panelDialogo;
    public TextMeshProUGUI textoDialogo;
    public TextMeshProUGUI textoNombre;

    private LineaDialogo[] dialogosActuales;
    private int indiceActual = 0;
    public bool dialogoActivo = false;

    void Awake()
    {
        instancia = this;
        panelDialogo.SetActive(false);
    }

    void Update()
    {
        if (dialogoActivo && Input.GetKeyDown(KeyCode.E))
            SiguienteDialogo();
    }

    public void IniciarDialogo(LineaDialogo[] dialogos)
    {
        dialogosActuales = dialogos;
        indiceActual = 0;
        dialogoActivo = true;
        panelDialogo.SetActive(true);
        textoNombre.text = dialogosActuales[indiceActual].nombre;
        textoDialogo.text = dialogosActuales[indiceActual].texto;
    }

    private void SiguienteDialogo()
    {
        indiceActual++;

        if (indiceActual >= dialogosActuales.Length)
        {
            TerminarDialogo();
            return;
        }

        textoNombre.text = dialogosActuales[indiceActual].nombre;
        textoDialogo.text = dialogosActuales[indiceActual].texto;
    }

    private void TerminarDialogo()
    {
        dialogoActivo = false;
        panelDialogo.SetActive(false);
    }
}