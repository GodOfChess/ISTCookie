using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    [SerializeField] int balance;
    [SerializeField] int allbalance;
    public Text balancetext;
    
    public void Start()
    {
        balance = PlayerPrefs.GetInt("balance");
        allbalance = PlayerPrefs.GetInt("allbalance");
    }

    public void ButtonClick()
    {
        balance += 1;
        allbalance += 1;
        PlayerPrefs.SetInt("balance", balance);
        PlayerPrefs.SetInt("allbalance", allbalance);
    }

    public void ToAchievements()
    {
        SceneManager.LoadScene(1);
    }

    public void Update()
    {
        balancetext.text = balance.ToString();
    }
}
