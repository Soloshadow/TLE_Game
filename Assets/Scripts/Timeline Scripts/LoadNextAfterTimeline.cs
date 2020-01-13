using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.Video;
using UnityEngine.SceneManagement;


/*
 * This script is solely used in a video player to go the nexgt scene. 
 */

public class LoadNextAfterTimeline : MonoBehaviour
{
    [SerializeField] VideoPlayer VideoPlayer; // Drag & Drop the GameObject holding the VideoPlayer component
    [SerializeField] string SceneName;

    void Start()
    {
        // When the video player reaches the end (looppoint) it will then load the next scene
        VideoPlayer.loopPointReached += LoadScene;
    }

    void LoadScene(VideoPlayer vp)
    {
        SceneManager.LoadScene(SceneName);
    }
}
