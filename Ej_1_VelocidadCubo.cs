using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej_1_VelocidadCubo : MonoBehaviour
{
    public float velocidad = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0, 0, -1) * velocidad * Time.deltaTime);
        // Input.GetKey: si se hace con esto, update va a 60 ps y se imprime un mensaje por fps en el que se presione la Key
        if (Input.GetKeyDown(KeyCode.UpArrow)) {
            Debug.Log("UpArrow: " + (velocidad * Input.GetAxis("Vertical")));
        }
        if (Input.GetKeyDown(KeyCode.DownArrow)) {
            Debug.Log("DownArrow: " + (velocidad * Input.GetAxis("Vertical")));
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow)) {
            Debug.Log("LeftArrow: " + (velocidad * Input.GetAxis("Horizontal")));
        }
        if (Input.GetKeyDown(KeyCode.RightArrow)) {
            Debug.Log("RightArrow: " + (velocidad * Input.GetAxis("Horizontal")));
        }
    }
}
