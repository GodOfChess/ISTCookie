using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections.Generic;

public class SettingsScript : MonoBehaviour
{
    [SerializeField] int music, effects;
    public Text musicText, effectsText;
    public AudioSource musicPlay;
    public List<AudioSource> sounds = new List<AudioSource>();

    public void Start()
    {
        music = PlayerPrefs.GetInt("music");
        effects = PlayerPrefs.GetInt("effects");
        if (music == 1)
        {
            musicPlay.Play();
        }
        if (effects == 0)
        {
            foreach (AudioSource element in sounds)
            {
                element.enabled = false;
            }
        }
    }

        public void Update()
    {
        if (music == 1)
        {
            musicText.text = "Музыка : on";
        }
        else
        {
            musicText.text = "Музыка : off";
        }
        if (effects == 1)
        {
            effectsText.text = "Звуки : on";
        }
        else
        {
            effectsText.text = "Звуки : off";
        }
    }

    public void ToMenu()
    {
        SceneManager.LoadScene(0);
    }
    
    public void ControlMusic()
    {
        if (music == 1)
        {
            music = 0;
            musicPlay.Stop();
        }
        else
        {
            music = 1;
            musicPlay.Play();
        }
        PlayerPrefs.SetInt("music", music);
    }

    public void ControlEffects()
    {
        if (effects == 1)
        {
            effects = 0;
            foreach(AudioSource element in sounds)
            {
                element.enabled = false;
            }
        }
        else
        {
            effects = 1;
            foreach (AudioSource element in sounds)
            {
                element.enabled = true;
            }
        }
        PlayerPrefs.SetInt("effects", effects);
    }
}
