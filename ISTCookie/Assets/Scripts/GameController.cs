using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    [SerializeField] int balance, gold;
    public Text balancetext, goldtext;
    

    public void Start()
    {
        balance = PlayerPrefs.GetInt("balance");
        gold = PlayerPrefs.GetInt("gold");
    }

    public void ButtonClick()
    {
        balance += 1;
        PlayerPrefs.SetInt("balance", balance);
    }

    public void ToAchievements()
    {
        SceneManager.LoadScene(1);
    }

    public void ToVK()
    {
        Application.OpenURL("https://vk.com/01ist");
    }

    public void ToShop()
    {
        SceneManager.LoadScene(2);
    }

    public void Update()
    {
        balancetext.text = balance.ToString();
        goldtext.text = gold.ToString();
    }
}
