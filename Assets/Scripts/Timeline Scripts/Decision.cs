using System.Collections;
using System.Collections.Generic;
using UnityEngine;


using UnityEngine.Playables;

/*
 *  This script is for pausing the current timeline to give the players the chance to make a decision. 
 */

public class Decision : MonoBehaviour
{

    // Get the playable director timeline
    [SerializeField] PlayableDirector currentTimeline;
 
    // Puase current time line
    void Start()
    {
        currentTimeline.Pause();
    }
 
}
