using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AchieveScript : MonoBehaviour
{
    [SerializeField] Button FirstAch, SecondAch;
    [SerializeField] bool isFirst, isSecond;
    private int balance,gold;

    public void Start()
    {
        isFirst = PlayerPrefs.GetInt("isFirst") == 1 ? true : false;
        isSecond = PlayerPrefs.GetInt("isSecond") == 1 ? true : false;
        balance = PlayerPrefs.GetInt("balance");
        gold = PlayerPrefs.GetInt("gold");
        //первое достижение
        if (!isFirst)
        {
            FirstAch.interactable = true;
        }
        else
        {
            FirstAch.interactable = false;
        }
        //второе достижение
        if (balance >= 10000 && !isSecond)
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

    public void FirstAchievement()
    {
        balance = PlayerPrefs.GetInt("balance");
        gold = PlayerPrefs.GetInt("gold");
        balance += 10;
        gold += 5;
        PlayerPrefs.SetInt("balance", balance);
        PlayerPrefs.SetInt("gold", gold);
        isFirst = true;
        PlayerPrefs.SetInt("isFirst", isFirst ? 1 : 0);
        FirstAch.interactable = false;
    }

    public void SecondAchievement()
    {
        balance = PlayerPrefs.GetInt("balance");
        gold = PlayerPrefs.GetInt("gold");
        balance += 10000;
        gold += 100;
        PlayerPrefs.SetInt("balance", balance);
        PlayerPrefs.SetInt("gold", gold);
        isSecond = true;
        PlayerPrefs.SetInt("isSecond", isFirst ? 1 : 0);
        SecondAch.interactable = false;
    }
}
