using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    public GameObject playerObject;
    public GameObject[] cubeSpawner;

    public float timeToSpawn = 1f;
    public float timeBetweenWaves = 0.5f;

    float x;
    float y;
    float z;
    
    void Update()
    {
        x = Random.Range(0f, 5f);
        y = 0f;
        z = playerObject.transform.position.z;

        if (Time.time >= timeToSpawn)
        {
            SpawnCubes();
            timeToSpawn = Time.time + timeBetweenWaves;
        }
    }

    void SpawnCubes()
    {
        int spawnerNumber = Random.Range(0, 10);

        Instantiate(cubeSpawner[spawnerNumber], new Vector3(x, y-5 , z + 200), Quaternion.identity);
    }
}
