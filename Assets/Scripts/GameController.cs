using UnityEngine.SceneManagement;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public ItemSpawner itemSpawner;
    public GameObject failScreen;
    public RequiredIngredientDisplay reqIngDisplay;

    [Header("Leveling")]
    public int level = 1;
    public int ingRequiredToLevelUp = 5;
    public float speedIntervalInc = 0.05f;
    public float maxSpeedMultiplier = 2.0f;
    public static bool gameIsPaused = false;

    private int ingCaught = 0;
    private float speedMultiplier = 1.0f;
    private int requiredIng;

    private void Start()
    {
        DesignateRequiredItem();
    }

    private void Update()
    {
        if (ingCaught >= ingRequiredToLevelUp)
            LevelUp();
    }

    private void LevelUp()
    {
        ingCaught = 0;
        level++;                                    // Increase the level by 1
        itemSpawner.IncreasePool();                 // Increase range of items being spawned

        // Increase the speed of items being dropped
        speedMultiplier = speedMultiplier + speedIntervalInc >= maxSpeedMultiplier ? maxSpeedMultiplier : speedMultiplier + speedIntervalInc;

        // Increase frequency of items appearing?
    }

    public void IncreaseIngCaught()
    {
        ingCaught++;
    }

    public float GetSpeedMultiplier()
    {
        return speedMultiplier;
    }

    public void DesignateRequiredItem() {
        requiredIng = Random.Range(0, itemSpawner.maxNumOfItemTypes);
        reqIngDisplay.DisplayReqIng();
    }

    public int GetRequiredIngID()
    {
        return requiredIng;
    }

    public void DisplayFailScreen()
    {
        //Called upon catching an incorrect item.
        PauseGame();
        failScreen.SetActive(true);
    }
    void PauseGame()
    {
        gameIsPaused = !gameIsPaused;
        if (gameIsPaused)
        {
            Time.timeScale = 0f;
        }
        else
        {
            Time.timeScale = 1;
        }
    }

    public void RestartGame() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        PauseGame();
    }
}
