using UnityEngine;

public class Ingredient : MonoBehaviour
{
    public int id;
    public float speed = 5.0f;

    private GameController gameController;
    private const string GAMECONTROLLER_NAME = "GameController";

    private void Start()
    {
        gameController = GameObject.Find(GAMECONTROLLER_NAME).GetComponent<GameController>();
    }

    private void Update()
    {
        transform.Translate(Vector2.down * Time.deltaTime * speed * gameController.GetSpeedMultiplier());
    }
}
