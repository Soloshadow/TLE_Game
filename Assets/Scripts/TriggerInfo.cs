using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TriggerInfo : MonoBehaviour
{
    public Collider2D coll;

    [SerializeField] Image imageTip;

    private bool isTriggered = false;

    // Use this for initialization
    /*
    void Start()
    {
        //Check if the isTrigger option on th Collider2D is set to true or false
        if (coll.isTrigger)
        {
            Debug.Log("player enter");
            Time.timeScale = 0;
        }
       
    }
    */

    private void Update()
    {
        if (isTriggered && Input.GetKeyUp(KeyCode.Return))
        {
            imageTip.gameObject.SetActive(false);
            Time.timeScale = 1;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!isTriggered)
        {
            imageTip.gameObject.SetActive(true);
            Time.timeScale = 0;
            isTriggered = true;
        }
    }
}
