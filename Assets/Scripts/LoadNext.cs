using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNext : MonoBehaviour
{

    public float delay;
    public string sceneName;


    // Start is called before the first frame update
    // Load next scene after a few seconds
    void Start()
    {
        StartCoroutine(LoadNextAfterDelay(delay));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Load next scene 
   IEnumerator LoadNextAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene(sceneName);
    }
}
