using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NodeLoadingScript : MonoBehaviour
{
    public Material myMaterial; // Skybox material for the new room
    public GameObject myNodeList; // Nodes for the target room
    public GameObject currentNodeList; // Nodes for the current room

    public void LoadNewRoom()
    {
        // Update the skybox to the new room's material
        if (myMaterial != null)
        {
            RenderSettings.skybox = myMaterial;
            DynamicGI.UpdateEnvironment(); // Updates lighting to reflect the new skybox
        }

        // Deactivate the current room's nodes
        if (currentNodeList != null)
        {
            currentNodeList.SetActive(false);
        }

        // Activate the target room's nodes
        if (myNodeList != null)
        {
            myNodeList.SetActive(true);
        }
    }
}
