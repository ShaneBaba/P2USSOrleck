using UnityEngine;
using UnityEngine.XR;

public class DebugControllerTracking : MonoBehaviour
{
    void Update()
    {
        InputDevice rightController = InputDevices.GetDeviceAtXRNode(XRNode.RightHand);

        // Check for controller position
        if (rightController.TryGetFeatureValue(CommonUsages.devicePosition, out Vector3 position))
        {
            Debug.Log($"Right Controller Position: {position}");
        }

        // Check for controller rotation
        if (rightController.TryGetFeatureValue(CommonUsages.deviceRotation, out Quaternion rotation))
        {
            Debug.Log($"Right Controller Rotation: {rotation}");
        }
    }
}
