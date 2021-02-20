using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Advertisements;

public class ShopScript : MonoBehaviour
{
    [SerializeField] int automoney, upgradecount, balance, gold;
    [SerializeField] Button BalanceButton, GoldButton;

    public void Start()
    {
        automoney = PlayerPrefs.GetInt("automoney");
        upgradecount = PlayerPrefs.GetInt("upgradecount");
        balance = PlayerPrefs.GetInt("balance");
        gold = PlayerPrefs.GetInt("gold");

        if (Advertisement.isSupported)
        {
            Advertisement.Initialize("4018925", false);
        }
    }

    public void UpgradewithMoney()
    {
            automoney += 1;
            upgradecount += 1;
            balance -= 500;
            PlayerPrefs.SetInt("balance", balance);
            PlayerPrefs.SetInt("automoney", automoney);
            PlayerPrefs.SetInt("upgradecount", upgradecount);
    }

    public void UpgradewithGold()
    {
        automoney += 5;
        upgradecount += 1;
        gold -= 50;
        PlayerPrefs.SetInt("gold", gold);
        PlayerPrefs.SetInt("automoney", automoney);
        PlayerPrefs.SetInt("upgradecount", upgradecount);
    }

    public void ToMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void GetMoney()
    {
        if (Advertisement.IsReady())
        {
            Advertisement.Show("rewardedVideo");
            balance += 100;
            PlayerPrefs.SetInt("balance", balance);
        }
    }

    public void GetGold()
    {
        if (Advertisement.IsReady())
        {
            Advertisement.Show("rewardedVideo");
            gold += 10;
            PlayerPrefs.SetInt("gold", gold);
        }
    }

    public void Update()
    {

        if (balance >= 500)
        {
            BalanceButton.interactable = true;
        }
        else
        {
            BalanceButton.interactable = false;
        }

        if (gold >= 50)
        {
            GoldButton.interactable = true;
        }
        else
        {
            GoldButton.interactable = false;
        }
    }
}
