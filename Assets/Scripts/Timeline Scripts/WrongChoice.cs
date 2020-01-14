using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class WrongChoice : MonoBehaviour
{

    // [SerializeField] string[] errorTexts;
    [SerializeField] GameObject textCanvas;
    [SerializeField] Text[] text;

    private int counter = 0;

    private void OnMouseDown()
    {
         textCanvas.SetActive(true);

        textCanvas.GetComponentInChildren<Text>().enabled = false;
        
        if (counter < text.Length)
        {
            
            text[counter].GetComponent<Text>().enabled = true;
            Debug.Log(text[counter].text);
            counter++;
        }
        else
        {
            Debug.Log("finish");
        }
        
    }

}
