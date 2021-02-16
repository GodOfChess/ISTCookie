using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AchieveScript : MonoBehaviour
{
    [SerializeField] Button FirstAch;
    [SerializeField] bool isFirst;

    public void Start()
    {
        isFirst = PlayerPrefs.GetInt("isFirst") == 1 ? true : false;
        if (!isFirst)
        {
            FirstAch.interactable = true;
        }
        else
        {
            FirstAch.interactable = false;
        }
    }

    public void ToMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void FirstAchievement()
    {
        int balance = PlayerPrefs.GetInt("balance");
        int gold = PlayerPrefs.GetInt("gold");
        balance += 10;
        gold += 5;
        PlayerPrefs.SetInt("balance", balance);
        PlayerPrefs.SetInt("gold", gold);
        isFirst = true;
        PlayerPrefs.SetInt("isFirst", isFirst ? 1 : 0);
        FirstAch.interactable = false;
    }
}
