using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] Slider volumeSlider;
    void Start()
    {
        if(!PlayerPrefs.HasKey("Volume"))
        {
            PlayerPrefs.SetFloat("Volume", 1);
            Load();
        }

        else
        {
            Load();
        }
    }

    // Update is called once per frame
    public void ChangeVolume()
    {
        AudioListener.volume = volumeSlider.value;
        Save();
    }

    private void Load()
    {
        volumeSlider.value = PlayerPrefs.GetFloat("Volume");
    }

    private void Save()
    {
        PlayerPrefs.SetFloat("Volume", volumeSlider.value);
    }
}
