using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class RandomTip : MonoBehaviour
{

    [SerializeField] Text[] tips;


    private void Start()
    {
        tips[Random.Range(0, tips.Length)].GetComponent<Text>().enabled = true;
    }

}
