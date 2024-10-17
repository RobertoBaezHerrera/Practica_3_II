using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicio_6 : MonoBehaviour
{
    public float speed = 2f;
    public GameObject esfera, cubo;
    Vector3 moveDirectionEsfera = new Vector3(0, 0, 0);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Cubo sigue a esfera
        Vector3 direccion_cubo_a_esfera = esfera.transform.position - cubo.transform.position;
        direccion_cubo_a_esfera.y = 0f;

        cubo.transform.Translate(direccion_cubo_a_esfera.normalized * speed * Time.deltaTime);

        // Movimiento esfera
        if (Input.GetKeyDown(KeyCode.W)) {
            moveDirectionEsfera += new Vector3(0, 1, 0);
        }
        if (Input.GetKeyDown(KeyCode.S)) {
            moveDirectionEsfera += new Vector3(0, -1, 0);
        }
        if (Input.GetKeyDown(KeyCode.A)) {
            moveDirectionEsfera += new Vector3(-1, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.D)) {
            moveDirectionEsfera += new Vector3(1, 0, 0);
        }
        esfera.transform.Translate(moveDirectionEsfera * speed * Time.deltaTime);
    }
}
