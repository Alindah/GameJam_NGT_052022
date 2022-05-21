using UnityEngine;

public class ItemSpawner : MonoBehaviour
{
    public GameObject[] item;
    public float xBoundary = 10.0f;
    
    private int maxNumOfItemTypes;
    public int waitCounter = 0;
    public int waitCounterLimit = 15;
    public int probabilityRangeLimit = 50;

    private void Start()
    {
        maxNumOfItemTypes = item.Length;
    }

    private void Update()
    {
        float randomNumber = Random.Range(0, probabilityRangeLimit);
        if (randomNumber==1||waitCounter>waitCounterLimit)
        {
            SpawnItem();
            waitCounter = 0;
        } else {
            waitCounter += 1;
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
