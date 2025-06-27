using UnityEngine;

public class MoveTower : MonoBehaviour
{
    public float rotationspeed = 150f;
    
    void Update()
    {
        if(Input.GetAxis("Horizontal") != 0)
        {
            float horizontal = Input.GetAxis("Horizontal");
            transform.Rotate(0, -horizontal * rotationspeed * Time.deltaTime, 0);
        }
    }
}
