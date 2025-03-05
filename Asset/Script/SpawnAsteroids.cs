using UnityEngine;

public class SpawnAsteroids : MonoBehaviour
{
    [SerializeField] 
    private GameObject[] spawnPoints;
    [SerializeField]
    private GameObject asteroid;
    [SerializeField]
    private GameObject heal;
    [SerializeField]
    private GameObject RedLight;
    [SerializeField]
    private float timeInterval = 1.4f;

    void Start()
    {
        Invoke("Spawn", timeInterval);
        Invoke("SpawnHeal", 13);
        Invoke("SpawnSpeed", 9);
    }

    private void Spawn()
    {
        int rng = UnityEngine.Random.Range(0, 5);
        GameObject ast = Instantiate(asteroid);
        Vector3 position = spawnPoints[rng].transform.position;
        ast.transform.position = position;
        Invoke("Spawn", timeInterval);
    }

    private void SpawnHeal()
    {
        int rng = UnityEngine.Random.Range(0, 5);
        GameObject ast = Instantiate(heal);
        Vector3 position = spawnPoints[rng].transform.position;
        ast.transform.position = position;
        Invoke("SpawnHeal", 13);
    }

    private void SpawnSpeed()
    {
        int rng = UnityEngine.Random.Range(0, 5);
        GameObject ast = Instantiate(RedLight);
        Vector3 position = spawnPoints[rng].transform.position;
        ast.transform.position = position;
        Invoke("SpawnSpeed", 9);
    }
}
