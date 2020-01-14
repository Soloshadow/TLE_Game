using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*
 * This script is solely used for higlighting the available decisions for the players when they hover over a gameobject 
 */

public class ChoicesHighlights : MonoBehaviour
{
    // Give option to drag and drop gameobject in the unity ui
    [SerializeField] GameObject highlightedPanel;

    // Make variable for storing the starting color
    // Make variable for current scale
    private Color startcolor;
    private Vector3 startScale;

    void OnMouseEnter()
    {

        // Get the starting color and store it in the variable
        // Change the components color
        startcolor = GetComponent<Renderer>().material.color;
        GetComponent<Renderer>().material.color = Color.yellow;

        // Get the starting scale and save it into the variable for later use
        // Change the game object scale to make it visible to the player
        startScale = highlightedPanel.transform.localScale;
        highlightedPanel.transform.localScale += new Vector3(0.4f, 0.4f, 0);
    }
    void OnMouseExit()
    {
        // Restore the components color back to starting color from the variable
        GetComponent<Renderer>().material.color = startcolor;

        // Reset the game object scale to the starting scale after mouse exit
        highlightedPanel.transform.localScale = startScale;
    }
}
