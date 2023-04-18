using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; // The object that the camera will follow
    public float smoothing = 5f; // The speed of camera movement

    private Vector3 offset; // The initial offset from the target

    private void Start()
    {
        offset = transform.position - target.position;
    }

    private void FixedUpdate()
    {
        Vector3 targetCamPos = target.position + offset;
        transform.position = Vector3.Lerp(transform.position, targetCamPos, smoothing * Time.deltaTime);
    }
}
