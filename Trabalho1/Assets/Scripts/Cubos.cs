using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubos : MonoBehaviour
{
    public GameObject movimentar;
    public GameObject rotacionar;
    public GameObject escalar;

    public GameObject movimentarClone;
    public GameObject rotacionarClone;
    public GameObject escalarClone;

    private bool prefCriados = false;



    float escala;
    float rot;
    Vector3 mov;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (escalarClone)
        {
            escala = escalarClone.transform.position.z - transform.position.z;
            rot = rotacionarClone.transform.position.x - transform.position.x;

            mov = new Vector3(movimentarClone.transform.position.x, movimentarClone.transform.position.y, movimentarClone.transform.position.z);


            if(mov.y - transform.position.y != 1.5f)
            {
                transform.position = new Vector3(mov.x, mov.y -1.5f, mov.z);

                escalarClone.transform.position = new Vector3(transform.position.x + escalarClone.transform.position.x - transform.position.x, 
                    transform.position.y + escalarClone.transform.position.y - transform.position.y,
                    transform.position.z + escalarClone.transform.position.z - transform.position.z);

                rotacionarClone.transform.position = new Vector3(transform.position.x + rotacionarClone.transform.position.x - transform.position.x, 
                    transform.position.y + rotacionarClone.transform.position.y - transform.position.y, 
                    transform.position.z + rotacionarClone.transform.position.z - transform.position.z);

            }
            transform.localScale = new Vector3(escala -0.5f, escala - 0.5f, escala - 0.5f);
            transform.Rotate(new Vector3(rot, rot, rot));

        }
        
    }



    private void OnMouseDown()
    {
        if (prefCriados)
        {
            Cubos.Destroy(movimentarClone);
            Cubos.Destroy(rotacionarClone);
            Cubos.Destroy(escalarClone);


            prefCriados = !prefCriados;
        }
        else
        {
            Vector3 posPai = transform.position;
            Vector3 pos = posPai + new Vector3(0, 1.5f,0);

            movimentarClone = Instantiate(movimentar, pos, Quaternion.identity, transform.parent);
            pos = posPai + new Vector3(1.5f, 0, 0);
            rotacionarClone = Instantiate(rotacionar, pos, Quaternion.identity, transform.parent);
            pos = posPai + new Vector3(0,0, 1.5f);
            escalarClone = Instantiate(escalar, pos, Quaternion.identity, transform.parent);

            

            prefCriados = !prefCriados;
        }

    }
}
