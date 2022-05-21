using UnityEngine;

public class Witch : MonoBehaviour
{
    public float movementSpeed = 20f;
    public float maxDistanceFromCenter = 10.0f;

    public float horizontalInput { get; private set; }

    // Update is called once per frame
    void Update()
    {
        //Get player input
        horizontalInput = Input.GetAxis("Horizontal");
        
        if (Input.GetButton("Horizontal")) {
            if (Mathf.Abs(transform.position.x) < maxDistanceFromCenter) {
                transform.Translate(Vector2.right * horizontalInput * Time.deltaTime * movementSpeed);
            }
            if (Mathf.Abs(transform.position.x) >= maxDistanceFromCenter) {
                transform.Translate(Vector2.left * horizontalInput * Time.deltaTime * movementSpeed);
            }
        }
    }
}
