using UnityEngine;
using UnityEngine.SceneManagement;

public class ControladorEnlaces : MonoBehaviour
{
    public void AbrirSitioWeb(string url)
    {
        Application.OpenURL(url);
    }

    public void CambiarEscena(string nombreEscena)
    {
        SceneManager.LoadScene(nombreEscena);
    }
}