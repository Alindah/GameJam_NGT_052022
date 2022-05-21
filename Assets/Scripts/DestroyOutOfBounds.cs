using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    public float yBoundary = -5.0f;

    private void Update()
    {
        if (transform.position.y < yBoundary)
            Destroy(gameObject);
    }
}
