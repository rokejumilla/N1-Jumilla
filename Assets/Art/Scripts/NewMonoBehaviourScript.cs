using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    // Velocidad de rotación
    public float rotationSpeed = 100f;
    // Variable para controlar si la rotación está bloqueada
    private bool canRotate = true;

    // Update is called once per frame
    void Update()
    {
        // Si no está presionada la barra espaciadora, permitimos la rotación
        if (canRotate)
        {
            // Rotación con teclas de flechas
            if (Input.GetKey(KeyCode.RightArrow))
            {
                // Girar en sentido horario (derecha)
                transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
            }
            else if (Input.GetKey(KeyCode.LeftArrow))
            {
                // Girar en sentido antihorario (izquierda)
                transform.Rotate(-Vector3.up * rotationSpeed * Time.deltaTime);
            }
        }

        // Si se presiona la barra espaciadora, se deshabilita la rotación
        if (Input.GetKey(KeyCode.Space))
        {
            canRotate = false;
        }
        // Si se suelta la barra espaciadora, se vuelve a habilitar la rotación
        else if (Input.GetKeyUp(KeyCode.Space))
        {
            canRotate = true;
        }
    }
}





