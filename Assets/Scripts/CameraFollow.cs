using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    Vector3 offset;
    public float smothSpeed = 0.4f;
    void Start()
    {
        offset = transform.position - target.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newposition = Vector3.Lerp(transform.position, target.position + offset, smothSpeed);
        transform.position = newposition;
    }
}
