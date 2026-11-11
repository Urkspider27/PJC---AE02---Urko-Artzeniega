using UnityEngine;

public class ControlJugador : MonoBehaviour
{
    public float velocidad = 6f;

    void Update()
    {
        // Lee teclado: WASD o Flechitas
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 direccion = new Vector3(horizontal, 0f, vertical).normalized;

        transform.Translate(direccion * velocidad * Time.deltaTime, Space.World);
    }
}