using UnityEngine;

public class DropItem : MonoBehaviour
{
    public float speed = 5.0f;

    private void Update()
    {
        transform.Translate(Vector2.down * Time.deltaTime * speed);
    }
}
