
using UnityEngine;

public class CameraFollowPlayerController : MonoBehaviour
{
    public Transform followTarget;

    public float smoothSpeed = 1;
    public Vector3 cameraOffset;

    private void LateUpdate()
    {
        Vector3 desiredPopsition = followTarget.position + cameraOffset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPopsition, smoothSpeed* Time.deltaTime);
        transform.position = smoothedPosition; 
    }
}
