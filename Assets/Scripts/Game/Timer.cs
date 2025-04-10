using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] TextMeshProUGUI timerText;
    public static float elapsedTime;

    public static int minutes;
    public static int seconds;

    // Update is called once per frame
    void Update()
    {
        elapsedTime += Time.deltaTime;
        minutes = Mathf.FloorToInt(elapsedTime / 60);
        seconds = Mathf.FloorToInt(elapsedTime % 60);

        timerText.text = string.Format("Time: {0:00}:{1:00}", minutes, seconds);
    }
}
