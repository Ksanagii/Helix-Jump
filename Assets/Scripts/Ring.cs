using UnityEngine;

public class Ring : MonoBehaviour
{
    private Transform player;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y > player.position.y)
        {
            GameManager.numberOfPassedRings++;
            GameManager.score++;
            Destroy(gameObject);
        }
    }
}
