using UnityEngine;

public class Cauldron : MonoBehaviour
{
    public GameController gameController;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.GetComponent<Ingredient>().GetId() == gameController.GetRequiredIngID())
        {
            //Successful catch results in caught items increment and reselection of required item. 
            gameController.IncreaseIngCaught();
            gameController.DesignateRequiredItem();
        }
        else
        {
            // If player catches the wrong item x amount of times, display lose screen
            // Otherwise lose a life
            if (gameController.GetLives() <= 0)
                gameController.DisplayFailScreen();
            else
                gameController.LoseLife();
        }

        //Always destroy item regardles
        Destroy(other.gameObject);
    }
}
