using UnityEngine;
using UnityEngine.SceneManagement;

public class NodeInteraction : MonoBehaviour
{
    [SerializeField]
    private string targetRoomName; // Name of the scene or room to load

    // This method is called when the node is selected
    public void OnNodeSelected()
    {
        Debug.Log($"{gameObject.name} has been clicked!");

        // Ensure a target room is set
        if (!string.IsNullOrEmpty(targetRoomName))
        {
            // Load the target room (or perform the room change logic here)
            ChangeRoom(targetRoomName);
        }
        else
        {
            Debug.LogWarning("Target room name is not set for this node.");
        }
    }

    // Method to change the room or scene
    private void ChangeRoom(string roomName)
    {
        // Example for 360 VR: You can teleport to a different position or load another scene
        Debug.Log($"Changing to room: {roomName}");

        // For scene-based navigation:
        // Uncomment this if you're using Unity scenes for rooms
        // SceneManager.LoadScene(roomName);

        // For position-based navigation within the same scene:
        // Replace this with logic to reposition the camera or player
        // Example:
        // Camera.main.transform.position = newRoomPosition;
    }
}
