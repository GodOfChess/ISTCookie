using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class GameController : MonoBehaviour
{
    [SerializeField] int balance, gold, automoney;
    public Text balancetext, goldtext;
    

    public void Start()
    {
        balance = PlayerPrefs.GetInt("balance");
        gold = PlayerPrefs.GetInt("gold");
        automoney = PlayerPrefs.GetInt("automoney");
        StartCoroutine(AutoMoney());
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
        SceneManager.LoadScene(3);
    }

    public void ToSettings()
    {
        SceneManager.LoadScene(2);
    }

    public void Update()
    {
        balancetext.text = balance.ToString();
        goldtext.text = gold.ToString();
    }

    private IEnumerator AutoMoney()
    {
        balance += automoney;
        PlayerPrefs.SetInt("balance", balance);
        yield return new WaitForSeconds(1f);
        StartCoroutine(AutoMoney());
    }
}
