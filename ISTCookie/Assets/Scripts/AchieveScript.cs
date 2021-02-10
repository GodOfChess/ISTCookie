using UnityEngine;
using UnityEngine.UI;

public class AchieveScript : MonoBehaviour
{
    private int allbalance;
    public Text welcomeText;

    public void Start()
    {
        allbalance = PlayerPrefs.GetInt("allbalance");
        welcomeText.text = "Всего очков : " + allbalance.ToString();
    }
}
