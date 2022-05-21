using UnityEngine;

public class GameController : MonoBehaviour
{
    public ItemSpawner itemSpawner;
    public int level = 1;
    public int ingRequiredToLevelUp = 5;

    private int ingCaught = 0;

    private void Update()
    {
        if (ingCaught >= ingRequiredToLevelUp)
            LevelUp();
    }

    private void LevelUp()
    {
        ingCaught = 0;
        level++;    // Increase the level by 1
        itemSpawner.IncreasePool();     // Increase range of items being spawned
        // Increase the speed of items being dropped
        // Increase frequency of items appearing?
        Debug.Log("we are at level " + level);
    }

    public void IncreaseIngCaught()
    {
        ingCaught++;
        Debug.Log("caught " + ingCaught + " ingredients");
    }
}
