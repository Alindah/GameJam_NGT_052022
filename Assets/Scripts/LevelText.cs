using UnityEngine;
using TMPro;

public class LevelText : MonoBehaviour
{
    private TMP_Text level_TextComponent;

    // Start is called before the first frame update
    void Start()
    {
        level_TextComponent = GetComponent<TMP_Text>();
    }

    public void UpdateLevelText(int level)
    {
        string newLevelString = "LEVEL: " + level;
        level_TextComponent.text = newLevelString;
    }
}
