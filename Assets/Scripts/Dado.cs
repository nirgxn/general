using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Dado : MonoBehaviour
{
    bool clicado = false;
    public int qntd;
    public bool manter = true;
  

    private void Start()
    {
        //controla dado clicado
        clicado = manter = false;
        this.gameObject.GetComponent<BoxCollider2D>().autoTiling = true;
    }
    private void OnMouseEnter()
    {

        if (!clicado)
        {
            this.gameObject.GetComponent<RectTransform>().localScale =
                        new Vector3(1.15f,1.15f,1.15f);
        }
        // aumenta tamanho do dado com mouse
        
    }

    private void OnMouseExit()
    {

        if (!clicado)
        {
            //diminui dado com clique do mouse
            this.gameObject.GetComponent<RectTransform>().localScale =
                       new Vector3(
                           1f,
                           1f,
                          1f);
        }
        
    }

    //qnd dado eh clicado
    private void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            clicado = !clicado;
            manter = !manter;

            if (clicado)
            {
                //aumenta
                this.gameObject.GetComponent<RectTransform>().localScale = new Vector3(1.3f, 1.3f, 1.3f);

            }
            else
            {
                //diminui
                this.gameObject.GetComponent<RectTransform>().localScale = new Vector3(1.0f, 1.0f, 1.0f);

            }
        }
    }

    public void setValor(int valor)
    {
        this.qntd = valor;
    }


    public bool getClicado()
    {
        return this.clicado;
    }

    public void setClicado(bool status)
    {
        this.clicado = status;
    }

    public void zerarDados()
    {
        this.manter = false;
        this.clicado = false;
    }
}
