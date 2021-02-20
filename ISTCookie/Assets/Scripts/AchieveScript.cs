using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AchieveScript : MonoBehaviour
{
    [SerializeField] Button FirstAch, SecondAch, ThirdAch, FourthAch, FifthAch, SixthAch;
    [SerializeField] bool isFirst, isSecond, isThird, isFourth, changedbg, isFifth, isSixth;
    [SerializeField] int balance,gold, upgradecount;

    public void Start()
    {
        isFirst = PlayerPrefs.GetInt("isFirst") == 1 ? true : false;
        isSecond = PlayerPrefs.GetInt("isSecond") == 1 ? true : false;
        isThird = PlayerPrefs.GetInt("isThird") == 1 ? true : false;
        isFourth = PlayerPrefs.GetInt("isFourth") == 1 ? true : false;
        isFifth = PlayerPrefs.GetInt("isFifth") == 1 ? true : false;
        isSixth = PlayerPrefs.GetInt("isSixth") == 1 ? true : false;
        changedbg = PlayerPrefs.GetInt("changedbg") == 1 ? true : false;
        upgradecount = PlayerPrefs.GetInt("upgradecount");
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
        //третье достижение
        if (!isThird && upgradecount >= 1000)
        {
            ThirdAch.interactable = true;
        } 
        else
        {
            ThirdAch.interactable = false;
        }
        //четвертое достижение
        if (!isFourth && changedbg)
        {
            FourthAch.interactable = true;
        }
        else
        {
            FourthAch.interactable = false;
        }
        //пятое достижение
        if (!isFifth)
        {
            FifthAch.interactable = true;
        }
        else
        {
            FifthAch.interactable = false;
        }
        //шестое достижение
        if (!isSixth && balance >= 1000000000)
        {
            SixthAch.interactable = true;
        }
        else
        {
            SixthAch.interactable = false;
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

    public void ThirdAchievement()
    {
        balance = PlayerPrefs.GetInt("balance");
        gold = PlayerPrefs.GetInt("gold");
        balance += 1000000;
        gold += 500;
        PlayerPrefs.SetInt("balance", balance);
        PlayerPrefs.SetInt("gold", gold);
        isSecond = true;
        PlayerPrefs.SetInt("isThird", isThird ? 1 : 0);
        ThirdAch.interactable = false;
    }

    public void FourthAchievement()
    {
        balance = PlayerPrefs.GetInt("balance");
        gold = PlayerPrefs.GetInt("gold");
        balance += 500;
        gold += 10;
        PlayerPrefs.SetInt("balance", balance);
        PlayerPrefs.SetInt("gold", gold);
        isFourth = true;
        PlayerPrefs.SetInt("isFourth", isFourth ? 1 : 0);
        FourthAch.interactable = false;
    }

    public void FifthAchievement()
    {
        Application.OpenURL("https://play.google.com/store");
        balance = PlayerPrefs.GetInt("balance");
        gold = PlayerPrefs.GetInt("gold");
        balance += 500;
        gold += 10;
        PlayerPrefs.SetInt("balance", balance);
        PlayerPrefs.SetInt("gold", gold);
        isFifth = true;
        PlayerPrefs.SetInt("isFifth", isFifth ? 1 : 0);
        FifthAch.interactable = false;
    }

    public void SixthAchievement()
    {
        isSixth = true;
        PlayerPrefs.SetInt("isSixth", isSixth ? 1 : 0);
        SixthAch.interactable = false;
    }
}
