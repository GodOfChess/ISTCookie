using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AchieveScript : MonoBehaviour
{
    private int allbalance;
    [SerializeField] Button SecondAch;
    [SerializeField] bool isSecond;

    public void Start()
    {
        allbalance = PlayerPrefs.GetInt("allbalance");
        isSecond = PlayerPrefs.GetInt("isSecond") == 1 ? true : false;
        if (allbalance>=10 && !isSecond)
        {
            SecondAch.interactable = true;
        }
        else
        {
            SecondAch.interactable = false;
        }
    }

    public void ToMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void SecondAchievement()
    {
        int balance = PlayerPrefs.GetInt("balance");
        balance += 10;
        PlayerPrefs.SetInt("balance", balance);
        isSecond = true;
        PlayerPrefs.SetInt("isSecond", isSecond ? 1 : 0);
        SecondAch.interactable = false;
    }
}
