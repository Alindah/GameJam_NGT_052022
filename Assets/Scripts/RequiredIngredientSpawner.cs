using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RequiredIngredientSpawner : MonoBehaviour
{
    public ItemSpawner itemSpawner;

    // Start is called before the first frame update
    void Start()
    {
        SpawnRequiredItem();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void SpawnRequiredItem() {
        int randomIndex = Random.Range(0, itemSpawner.maxNumOfItemTypes);
        //itemSpawner.itemPool[randomIndex]
        //Instantiate(itemPool[randomIndex], new Vector2(8, itemPool[randomIndex].transform.position.y), Quaternion.identity, transform);
    }
}
