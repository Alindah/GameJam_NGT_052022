using UnityEngine;

public class Cauldron : MonoBehaviour
{
    public GameController gameController;
    private const string ITEM_TAG = "item";

    private void OnTriggerEnter2D(Collider2D other)
    {
        //Debug.Log(other.gameObject.GetComponent<Ingredient>().id + " is the ID of the falling ingredient");
        //Debug.Log(gameController.getRequiredIngID() + " is the id of the required ingredient");
        if (other.gameObject.GetComponent<Ingredient>().id == gameController.getRequiredIngID())
        {
            Destroy(other.gameObject);
            // Check if required item before running following line
            gameController.IncreaseIngCaught();
        }
    }
}
