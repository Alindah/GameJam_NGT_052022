using UnityEngine;

public class ItemSpawner : MonoBehaviour
{
    public GameObject[] item;
    
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
        Instantiate(item[randomIndex]);
        Debug.Log("spawned item " + randomIndex);
    }
}
