using UnityEngine.SceneManagement;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public ItemSpawner itemSpawner;
    public GameObject failScreen;

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
        Debug.Log(requiredIng + " is the required item");
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

        Debug.Log("we are at level " + level);
        Debug.Log("item speed multiplier: " + speedMultiplier);
    }

    public void IncreaseIngCaught()
    {
        ingCaught++;
        Debug.Log("caught " + ingCaught + " ingredients");
    }

    public float GetSpeedMultiplier()
    {
        return speedMultiplier;
    }

    public void DesignateRequiredItem() {
        requiredIng = Random.Range(0, itemSpawner.maxNumOfItemTypes);
        //itemSpawner.itemPool[randomIndex]
        //Instantiate(itemPool[randomIndex], new Vector2(8, itemPool[randomIndex].transform.position.y), Quaternion.identity, transform);
    }

    public int GetRequiredIngID()
    {
        return requiredIng;
    }

    public void DisplayFailScreen()
    {
        //Called upon catching an incorrect item.
        Debug.Log("Wrong item: Failure\nPausing Game");
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
