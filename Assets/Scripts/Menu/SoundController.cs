using UnityEngine;
using UnityEngine.UI;

public class SoundController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private bool soundState = true;
    [SerializeField] private AudioSource backgroundMusic;

    [SerializeField] private Sprite soundOnSprite;
    [SerializeField] private Sprite soundOffSprite;

    [SerializeField] private Image muteImage;

    public void TurnOnOff()
    {
        soundState = !soundState;
        backgroundMusic.enabled = soundState;

        if (soundState)
        {
            muteImage.sprite = soundOnSprite;
        }
        else
        {
            muteImage.sprite = soundOffSprite;
        }
    }

    public void MusicVolume(float value)
    {
        backgroundMusic.volume = value;
    }
}
