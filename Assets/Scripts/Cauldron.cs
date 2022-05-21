using UnityEngine;

public class Cauldron : MonoBehaviour
{
    public GameController gameController;
    private const string ITEM_TAG = "item";

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == ITEM_TAG)
        {
            Destroy(other.gameObject);
            // Check if required item before running following line
            gameController.IncreaseIngCaught();
        }
    }
}
