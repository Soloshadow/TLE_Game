using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.Playables;

/*
 * This script is solely for resuming the timeline when player choses the right decision. 
 */

public class RightChoice : MonoBehaviour
{
    // Get current timeline
    [SerializeField] PlayableDirector currentTimeline;

    // Resume current timeline on mouse click
    void OnMouseDown()
    {
        
        currentTimeline.Resume();
    }
}
