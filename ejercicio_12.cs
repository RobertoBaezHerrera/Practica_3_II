using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicio_12 : MonoBehaviour
{
    public float speed = 2f;
    public GameObject esfera;
    Rigidbody rbCilindro;
    // Start is called before the first frame update
    void Start()
    {
        rbCilindro = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 moveDirectionCilindro = Vector3.zero;
        if (Input.GetKey(KeyCode.UpArrow)) {
            moveDirectionCilindro += new Vector3(0, 0, 1);
        }
        if (Input.GetKey(KeyCode.DownArrow)) {
            moveDirectionCilindro += new Vector3(0, 0, -1);
        }
        if (Input.GetKey(KeyCode.LeftArrow)) {
            moveDirectionCilindro += new Vector3(-1, 0, 0);
        }
        if (Input.GetKey(KeyCode.RightArrow)) {
            moveDirectionCilindro += new Vector3(1, 0, 0);
        }
        rbCilindro.AddForce(moveDirectionCilindro.normalized * speed, ForceMode.Force);

        // Mover hacia esfera
        if (Input.GetKey(KeyCode.Space)) {
            Vector3 direccion_cilindro_a_esfera = esfera.transform.position - transform.position;
            rbCilindro.AddForce(direccion_cilindro_a_esfera.normalized * speed, ForceMode.Force);
        }
    }
}
