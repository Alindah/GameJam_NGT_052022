using UnityEngine;

public class ItemSpawner : MonoBehaviour
{
    public GameObject[] item;
    public float xBoundary = 10.0f;
    public float delayTime;
    public float spawnIntervalMin;
    public float spawnIntervalMax;
    
    private int maxNumOfItemTypes;
    private const string SPAWN_FUNC = "SpawnItem";
    private float spawnInterval;

    private void Start()
    {
        maxNumOfItemTypes = item.Length;
        Invoke(SPAWN_FUNC, delayTime);
    }

    private void Update()
    {
        if (!IsInvoking(SPAWN_FUNC))
        {
            spawnInterval = Random.Range(spawnIntervalMin, spawnIntervalMax);
            Invoke(SPAWN_FUNC, spawnInterval);
        }
    }

    // Instantiate the itemPool
    private void SpawnItem()
    {
        int randomIndex = Random.Range(0, maxNumOfItemTypes);
        float xRange = Random.Range(-xBoundary, xBoundary);
        Instantiate(item[randomIndex], new Vector2(xRange, item[randomIndex].transform.position.y), Quaternion.identity);
        Debug.Log("spawned item " + randomIndex);
    }
}
