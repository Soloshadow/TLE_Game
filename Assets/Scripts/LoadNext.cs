using System.Collections;
using System.Collections.Generic;
using UnityEngine;


using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadNext : MonoBehaviour
{

    public float delay;
    public string sceneName;
    public Sprite[] scenes;


    // Start is called before the first frame update
    // Load next scene after a few seconds
    void Start()
    {
        // Call the Coroutine to run a function after delay
        StartCoroutine(LoadNextImage(delay));



    }

    // Function to load next sprite into image source after a delay.
    IEnumerator LoadNextImage(float delay)
    {
        // Loop through Sprite array and load each sprite into the image source
        for (int i = 0; i < scenes.Length; i++)
        {
          
            // Wait a few seconds before running next statement
            yield return new WaitForSeconds(delay);
            gameObject.GetComponent<Image>().sprite = scenes[i];

        }
    }

    // Load next scene 
    private void LoadNextScene()
    {
        Debug.Log("testing");
        // SceneManager.LoadScene(sceneName);
    }
}
