using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TriggerInfo : MonoBehaviour
{
   // [SerializeField] Collider2D trigger;

    [SerializeField] Image imageTip;

    private bool isTriggered = false;



    private void Update()
    {
        if (isTriggered && Input.GetKeyDown(KeyCode.X))
        {
            imageTip.gameObject.SetActive(false);
            gameObject.SetActive(false);
            Time.timeScale = 1;
        }
    }

    private void OnTriggerEnter2D(Collider2D trigger)
    {
        // check if the collider tag is equal to player
        if(trigger.tag == "Player")
        {
            // check if the info is triggered or not. In this case is true
            if (!isTriggered)
            {

                imageTip.gameObject.SetActive(true);
                Time.timeScale = 0;
                isTriggered = true;
            }
        }
        else
        {
            return;
        }
    }
}
