using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreText;
    public static int score;
    int maxScore;
    
    void Start()
    {
        maxScore = GameObject.FindGameObjectsWithTag("Collectable").Length;
    }

    void Update()
    {
        score = maxScore - GameObject.FindGameObjectsWithTag("Collectable").Length;

        scoreText.text = string.Format("Score: {0}", score);
         
        if (score == maxScore)
        {
            SceneManager.LoadSceneAsync("WinGame");
            Time.timeScale = 0;
        }
    }

}