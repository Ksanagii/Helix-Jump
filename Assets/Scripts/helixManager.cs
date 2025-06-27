
using UnityEngine;

public class helixManager : MonoBehaviour
{
    public GameObject[] HelixRings;
    private float ySpawn = 0f;
    private float ringsDistance = 5f;
    public int numberOfRings = 5;
    void Start()
    {
        numberOfRings = GameManager.currentLevelIndex + 3;
        SpawnRing(0);
        for (int i = 0; i < numberOfRings -1; i++)
        {
            SpawnRing(Random.Range(1, HelixRings.Length -1));
        }
        SpawnRing(HelixRings.Length -1);
    }
    private void SpawnRing( int i)
    {
        GameObject go = Instantiate(HelixRings[i], transform.up * ySpawn, Quaternion.identity);
        go.transform.parent = transform;
        ySpawn -= ringsDistance;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
