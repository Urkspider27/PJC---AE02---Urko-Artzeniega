using UnityEngine;

public class ControlJugador : MonoBehaviour
{
    public float velocidad = 6f;

    void Update()
    {
        // Lee el teclado: WASD o Flechas direccionales
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 direccion = new Vector3(horizontal, 0f, vertical).normalized;

        // Mueve la cápsula por el escenario
        transform.Translate(direccion * velocidad * Time.deltaTime, Space.World);
    }
}