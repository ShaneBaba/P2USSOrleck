using UnityEngine;

public class RoomManager : MonoBehaviour
{
    public GameObject[] rooms; // Array to hold all room GameObjects
    private int currentRoomIndex = 0; // Tracks the current room index

    // Move to the next room
    public void GoToNextRoom()
    {
        if (currentRoomIndex < rooms.Length - 1)
        {
            rooms[currentRoomIndex].SetActive(false); // Disable current room
            currentRoomIndex++; // Increment room index
            rooms[currentRoomIndex].SetActive(true); // Enable next room
        }
        else
        {
            Debug.Log("You are in the last room!");
        }
    }

    // Move to the previous room
    public void GoToPreviousRoom()
    {
        if (currentRoomIndex > 0)
        {
            rooms[currentRoomIndex].SetActive(false); // Disable current room
            currentRoomIndex--; // Decrement room index
            rooms[currentRoomIndex].SetActive(true); // Enable previous room
        }
        else
        {
            Debug.Log("You are in the first room!");
        }
    }

    // Teleport to a specific room by index
    public void GoToRoomByIndex(int roomIndex)
    {
        if (roomIndex >= 0 && roomIndex < rooms.Length)
        {
            rooms[currentRoomIndex].SetActive(false); // Disable current room
            currentRoomIndex = roomIndex; // Set new room index
            rooms[currentRoomIndex].SetActive(true); // Enable target room
        }
        else
        {
            Debug.LogError("Invalid room index!");
        }
    }
}
