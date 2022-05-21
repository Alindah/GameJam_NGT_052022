using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float movementSpeed = 20f;
    public float maxDistanceFromCenter = 10.0f;
    public float horizontalInput { get; private set; }
    private bool facingRight = false;

    // Update is called once per frame
    void Update()
    {
        //Get player input
        horizontalInput = Input.GetAxis("Horizontal");

        if ((horizontalInput < 0 && facingRight) || (horizontalInput > 0 && !facingRight))
        {
            flip();
            facingRight = !facingRight;
        }

        if (Input.GetButton("Horizontal")) {
            if (Mathf.Abs(transform.position.x) < maxDistanceFromCenter) {
                transform.Translate(Vector2.right * horizontalInput * Time.deltaTime * movementSpeed);
            }
            if (Mathf.Abs(transform.position.x) >= maxDistanceFromCenter) {
                transform.Translate(Vector2.left * horizontalInput * Time.deltaTime * movementSpeed);
            }
        }
    }

    private void flip()
    {
        transform.localScale = new Vector2(-transform.localScale.x, transform.localScale.y);
    }
}
