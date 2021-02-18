using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeBg : MonoBehaviour
{
    public List<Sprite> images = new List<Sprite>();
    public GameObject background;
    private Image im;
    [SerializeField] private int count, changedbg;

    public void Start()
    {
        count = PlayerPrefs.GetInt("count");
        im = background.GetComponent<Image>();
        im.sprite = images[count];
    }

    public void ChangeBackground()
    {
        if (count >= 6)
        {
            count = 0;
        }
        else
        {
            count += 1;
            changedbg = 1;
            PlayerPrefs.SetInt("changedbg", changedbg);
        }
        im.sprite = images[count];
        PlayerPrefs.SetInt("count", count);
    }
}
