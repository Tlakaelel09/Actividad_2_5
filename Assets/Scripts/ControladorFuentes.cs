using UnityEngine;
using TMPro; // Importante para manipular textos TextMeshPro

public class ControladorFuentes : MonoBehaviour
{
    public TextMeshProUGUI textoAControlar;

    // Esta función se conectará a tu botón
    public void CambiarEstiloFuente()
    {
        textoAControlar.fontSize = 80;
        textoAControlar.color = Color.yellow;
    }
}
