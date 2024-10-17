using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicio_11 : MonoBehaviour
{
    public float speed = 2f;
    GameObject cubo, esfera;
    Rigidbody rbEsfera;
    Vector3 moveDirectionCubo = Vector3.zero;

    void Start()
    {
        // Encontrar los objetos usando sus tags
        cubo = GameObject.FindGameObjectWithTag("cubo");
        esfera = GameObject.FindGameObjectWithTag("esfera");

        rbEsfera = esfera.GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Movimiento cubo
        if (Input.GetKeyDown(KeyCode.UpArrow)) {
            moveDirectionCubo += new Vector3(0, Input.GetAxis("Vertical"), 0);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow)) {
            moveDirectionCubo += new Vector3(0, Input.GetAxis("Vertical"), 0);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow)) {
            moveDirectionCubo += new Vector3(Input.GetAxis("Horizontal"), 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow)) {
            moveDirectionCubo += new Vector3(Input.GetAxis("Horizontal"), 0, 0);
        }
        cubo.transform.Translate(moveDirectionCubo * speed * Time.deltaTime);

        // Movimiento de la esfera (física con AddForce)
        Vector3 moveDirectionEsfera = Vector3.zero;
        if (Input.GetKey(KeyCode.W)) {
            moveDirectionEsfera += new Vector3(0, 0, 1);
        }
        if (Input.GetKey(KeyCode.S)) {
            moveDirectionEsfera += new Vector3(0, 0, -1);
        }
        if (Input.GetKey(KeyCode.A)) {
            moveDirectionEsfera += new Vector3(-1, 0, 0);
        }
        if (Input.GetKey(KeyCode.D)) {
            moveDirectionEsfera += new Vector3(1, 0, 0);
        }
        // Aplicar fuerza a la esfera
        rbEsfera.AddForce(moveDirectionEsfera.normalized * speed, ForceMode.Force);
    }

    // Detectar colisiones físicas usando OnCollisionEnter
    private void OnCollisionEnter(Collision other) {
        Debug.Log("Colisión Física de Cilindro con: " + other.gameObject.tag);
    }
    // Detectar colisiones cinemáticas usando OnCollisionEnter
    private void OnTriggerEnter(Collider other) {
        Debug.Log("Colisión Trigger de Cilindro con: " + other.gameObject.tag);
    }
}
