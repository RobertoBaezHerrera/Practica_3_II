using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ejercicio_9 : MonoBehaviour
{
    // Activar ejercicio_5 para mover cubo y esfera
    // Detectar colisiones físicas usando OnCollisionEnter
    // Detectar colisiones físicas usando OnCollisionEnter
    private void OnCollisionEnter(Collision other) {
        Debug.Log("Colisión de Cilindro con: " + other.gameObject.tag);
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
        
    }
}
