using TMPro;
using UnityEngine;

public class DisplayScore : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI finalScoreText;

    public static float elapsedTime;

    private static int score;
    public static float finalScore;

    void Start()
    {
        elapsedTime = Timer.elapsedTime;
        score = Score.score;

        finalScore = score * 10 / (elapsedTime / 60);
        finalScore = (int)finalScore;
    }

    void Update()
    {
        finalScoreText.text = string.Format("Final Score: {0}", finalScore);
    }
}
