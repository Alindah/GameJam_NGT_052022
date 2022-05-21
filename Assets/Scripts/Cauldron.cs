using UnityEngine;

public class Cauldron : MonoBehaviour
{
    public GameController gameController;
    private const string ITEM_TAG = "item";

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log(other.gameObject.GetComponent<Ingredient>().id + " is the ID of the falling ingredient");
        Debug.Log(gameController.getRequiredIngID() + " is the id of the required ingredient");
        if (other.gameObject.GetComponent<Ingredient>().id == gameController.getRequiredIngID())
        {
            //Successful catch results in caught items increment and reselection of required item. 
            gameController.IncreaseIngCaught();
            gameController.DesignateRequiredItem();
        }
        else
        {
            //If the item is not required, enter failure state.
            Debug.Log("Wrong item: Failure");
        }
        //Always destroy item regardles
        Destroy(other.gameObject);
    }
}
