using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicio_8 : MonoBehaviour
{
    public float speed = 2f;  // Velocidad del avance
    public float velocidadRotacion = 10f;  // Velocidad del giro
    float rotacion = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Obtener la rotación con el eje Horizontal (teclas izquierda-derecha o A-D)
        rotacion += Input.GetAxis("Horizontal") * velocidadRotacion * Time.deltaTime;

        // Rotar el objeto sobre su eje Y (girar a izquierda o derecha)
        transform.Rotate(0, rotacion, 0);

        // Avanzar en la dirección hacia adelante (transform.forward)
        transform.Translate(transform.forward * speed * Time.deltaTime);

        // Dibujar un rayo para visualizar la dirección hacia adelante del objeto
        Debug.DrawRay(transform.position, transform.forward * 2, Color.red);
    }
}
