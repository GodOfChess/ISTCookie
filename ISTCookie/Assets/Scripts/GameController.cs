using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    [SerializeField] int balance;
    public Text balancetext;
    
    public void ButtonClick()
    {
        balance += 1;
    }
    public void Update()
    {
        balancetext.text = balance.ToString();
    }
}
