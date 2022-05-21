using UnityEngine;

public class ItemSpawner : MonoBehaviour
{
    public GameObject[] item;
    public float xBoundary = 10.0f;
    
    private int maxNumOfItemTypes;

    private void Start()
    {
        maxNumOfItemTypes = item.Length;
    }

    private void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            SpawnItem();
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
