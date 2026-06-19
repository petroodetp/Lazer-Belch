using UnityEngine;

public class spawner : MonoBehaviour
{
    [SerializeField] float spawnInterval = 3.0f;
    [SerializeField] GameObject spawnPrefab;
    float lastSpawnTick = 0;
    private void Start()
    {
       lastSpawnTick = Random.Range(0.0f, spawnInterval);
    }
    void Update()
    {
        lastSpawnTick += Time.deltaTime;
        if (lastSpawnTick > spawnInterval)
        {
            Instantiate(spawnPrefab, transform.position,transform.rotation);
            lastSpawnTick = 0;
        }
    }
}
