using UnityEngine;

public class Cauldron : MonoBehaviour
{
    public GameController gameController;
    public AudioManager audioManager;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.GetComponent<Ingredient>().GetId() == gameController.GetRequiredIngID())
        {
            //Successful catch results in caught items increment and reselection of required item. 
            gameController.IncreaseIngCaught();
            gameController.DesignateRequiredItem();
            audioManager.PlaySoundEffect(audioManager.correct);
        }
        else
        {
            // If player catches the wrong item x amount of times, display lose screen
            // Otherwise lose a life
            gameController.LoseLife();

            if (gameController.GetLives() <= 0)
            {
                gameController.DisplayFailScreen();
                audioManager.PlaySoundEffect(audioManager.fail);
            }
            else
            {
                audioManager.PlaySoundEffect(audioManager.wrong);
            }
        }

        // Destroy item
        Destroy(other.gameObject);
    }
}
