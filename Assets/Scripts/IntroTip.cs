using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class IntroTip : MonoBehaviour
{

    [SerializeField] Image imgText;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            imgText.gameObject.SetActive(false);
            Time.timeScale = 1;
        }
    }
}
