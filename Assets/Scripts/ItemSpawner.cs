using UnityEngine;

public class ItemSpawner : MonoBehaviour
{
    public GameObject[] itemPool;
    public float xBoundary = 10.0f;
    public float delayTime;
    public float spawnIntervalMin;
    public float spawnIntervalMax;
    public int maxNumOfItemTypes;

    private const string SPAWN_FUNC = "SpawnItem";
    private float spawnInterval;

    private void Start()
    {
        // Makes sure game doesn't break if maxNumOfItemTypes exceeds the number of item types we have
        if (maxNumOfItemTypes > itemPool.Length)
            maxNumOfItemTypes = itemPool.Length;

        // Assign ids to ingredient prefabs
        for (int i = 0; i < itemPool.Length; i++)
            itemPool[i].gameObject.GetComponent<Ingredient>().SetId(i);

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
        Instantiate(itemPool[randomIndex], new Vector2(xRange, itemPool[randomIndex].transform.position.y), Quaternion.identity, transform);
    }

    public void IncreasePool()
    {
        if (maxNumOfItemTypes < itemPool.Length)
            maxNumOfItemTypes++;
    }
}
