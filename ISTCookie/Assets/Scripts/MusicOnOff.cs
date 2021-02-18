using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicOnOff : MonoBehaviour
{
    [SerializeField] int music, effects;
    public AudioSource musicPlay;
    public List<AudioSource> sounds = new List<AudioSource>();

    public void Start()
    {
        music = PlayerPrefs.GetInt("music");
        effects = PlayerPrefs.GetInt("effects");
        if (effects == 0)
        {
            foreach (AudioSource element in sounds)
            {
                element.enabled = false;
            }
        }
        else
        {
            foreach (AudioSource element in sounds)
            {
                element.enabled = true;
            }
        }
        if (music == 1)
        {
            musicPlay.Play();
        }
        else
        {
            musicPlay.Stop();
        }
    }
}
