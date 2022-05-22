using UnityEngine;

public class Cauldron : MonoBehaviour
{
    public GameController gameController;

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log(other.gameObject.GetComponent<Ingredient>().GetId() + " is the ID of the falling ingredient");
        Debug.Log(gameController.GetRequiredIngID() + " is the id of the required ingredient");
        if (other.gameObject.GetComponent<Ingredient>().GetId() == gameController.GetRequiredIngID())
        {
            //Successful catch results in caught items increment and reselection of required item. 
            gameController.IncreaseIngCaught();
            gameController.DesignateRequiredItem();
        }
        else
        {
            //If the item is not required, enter failure state.
            gameController.DisplayFailScreen();
        }
        //Always destroy item regardles
        Destroy(other.gameObject);
    }
}
