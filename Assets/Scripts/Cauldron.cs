using UnityEngine;

public class Cauldron : MonoBehaviour
{
    private const string ITEM_TAG = "item";

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log(other.tag);
        if (other.tag == ITEM_TAG)
            Destroy(other.gameObject);
    }
}
