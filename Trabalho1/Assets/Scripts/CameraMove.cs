using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    float eixoX;
    float eixoY;
    float velocidade = 5f;
    public float velRot = 5f;
    float mouseX = 0f;
    float mouseY = 0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // velocidade *= Time.deltaTime;

        if(Input.GetKey(KeyCode.A)){
            transform.Translate(-velocidade*Time.deltaTime,0,0);
        }   
        if(Input.GetKey(KeyCode.D)){
            transform.Translate(velocidade*Time.deltaTime,0,0);
        }   
        if(Input.GetKey(KeyCode.W)){
            transform.Translate(0,0, velocidade * Time.deltaTime);
        }   
        if(Input.GetKey(KeyCode.S)){
            transform.Translate(0,0, -velocidade * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            transform.Translate(0, velocidade * Time.deltaTime, 0);
        }
        if (Input.GetKey(KeyCode.LeftControl))
        {
            transform.Translate(0, -velocidade * Time.deltaTime, 0);
        }

        mouseX = Input.GetAxis("Mouse Y") * velocidade * Time.deltaTime;
        mouseY = Input.GetAxis("Mouse X") * velocidade * Time.deltaTime;

        transform.Rotate(-mouseX, mouseY, 0f);
    }
}
