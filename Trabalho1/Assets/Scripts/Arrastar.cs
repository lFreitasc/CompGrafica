using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrastar : MonoBehaviour
{
    Vector3 deslocamento;
    Transform parentPrefab;
    private void OnMouseDown()
    {
        deslocamento = this.transform.position - CoordMouseNoMundo();
    }


    Vector3 CoordMouseNoMundo()
    {
        //coord do (x,y) na tela
        Vector3 coordMouseNaTela = Input.mousePosition;
        coordMouseNaTela.z = Camera.main.WorldToScreenPoint(this.transform.position).z;
        return Camera.main.ScreenToWorldPoint(coordMouseNaTela);
    }

    private void OnMouseDrag()
    {
        this.transform.position = CoordMouseNoMundo() + deslocamento;
    }

    public void setParent4Drag(Transform newParent)
    {
        transform.SetParent(newParent);
    }
}
