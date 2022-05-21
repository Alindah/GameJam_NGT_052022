using UnityEngine;

public class GameController : MonoBehaviour
{
    public ItemSpawner itemSpawner;
    public int level = 1;
    public int ingRequiredToLevelUp = 5;
    public float speedIntervalInc = 0.05f;
    public float maxSpeedMultiplier = 2.0f;

    private int ingCaught = 0;
    private float speedMultiplier = 1.0f;

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
}
