using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    private int scoreCounter = 0;
    [SerializeField]
    private TextMeshProUGUI score;

    void Start()
    {
        score.text = "Score: " + scoreCounter;
    }

    public void addToScore()
    {
        scoreCounter++;
        score.text = "Score: " + scoreCounter;
    }
}
