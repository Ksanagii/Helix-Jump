using UnityEngine;

public class MoveTower : MonoBehaviour
{
    public float rotationSpeed = 150f;

    void Update()
    {
        if(Input.GetAxis("Horizontal") != 0)
        {
            float horizontal = Input.GetAxis("Horizontal");
            transform.Rotate(0, -horizontal * rotationSpeed * Time.deltaTime, 0);
        }
    }
}
