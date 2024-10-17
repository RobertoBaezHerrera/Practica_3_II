using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio_4 : MonoBehaviour
{
    public float speed = 2f;
    public GameObject esfera, cubo;
    Vector3 moveDirectionCubo = new Vector3(0, 0, 0);
    Vector3 moveDirectionEsfera = new Vector3(0, 0, 0);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
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
        cubo.transform.Translate(moveDirectionCubo * speed);

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
        esfera.transform.Translate(moveDirectionEsfera * speed);
    }
}
