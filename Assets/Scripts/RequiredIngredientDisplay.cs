using UnityEngine;
using UnityEngine.UI;

public class RequiredIngredientDisplay : MonoBehaviour
{
    public GameController gameController;
    public ItemSpawner itemSpawner;

    public void DisplayReqIng()
    {
        GetComponent<Image>().sprite = itemSpawner.itemPool[gameController.GetRequiredIngID()].GetComponent<SpriteRenderer>().sprite;
    }
}
