using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;


public class Menu :
    MonoBehaviour,
    IPointerDownHandler
{

    const string NOMECENA = "suhdushudsds";
    public void OnPointerDown(PointerEventData eventData)
    {
  
       
        if (Input.GetMouseButtonDown(0))
        {
           // StartCoroutine(esperarAnimacao();
        }
    }

    IEnumerator esperarAnimacao(Animation animation)
    {
        while (animation.isPlaying)
        {   
            yield return null; 
        }

        yield return new WaitForSeconds(2.0f);

        SceneManager.LoadScene(NOMECENA);
    }
}

