using UnityEngine;

public class GestorCargaContenido : MonoBehaviour
{
    [Header("Configuracion de Carga")]
    [Tooltip("Objeto que se activara/desactivara en memoria segun la presencia del jugador.")]
    public GameObject contenidoDinamico;

    private void OnTriggerEnter(Collider other)
    {
        if (contenidoDinamico != null && !contenidoDinamico.activeSelf)
        {
            contenidoDinamico.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        // Oculta el contenido al salir de la zona para liberar procesamiento
        if (contenidoDinamico != null && contenidoDinamico.activeSelf)
        {
            contenidoDinamico.SetActive(false);
            Resources.UnloadUnusedAssets(); // Aquí se libera la memoria de los recursos no utilizados
            Debug.Log("Contenido liberado de memoria activa.");
        }
    }
}