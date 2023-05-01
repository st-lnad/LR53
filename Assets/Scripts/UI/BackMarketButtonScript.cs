using UnityEngine;
using UnityEngine.UI;

public class BackMarketButtonScript : MonoBehaviour
{
    public InputField Buy0;
    public InputField Buy1;
    public InputField Buy2;
    public InputField Buy3;
    public InputField Buy4;
    public InputField Buy5;
    public InputField Buy6;
    public InputField Sell0;
    public InputField Sell1;
    public InputField Sell2;
    public InputField Sell3;
    public InputField Sell4;
    public InputField Sell5;
    public InputField Sell6;
    public void OnClick()
    {
        Buy0.text = 0.ToString();
        Buy1.text = 0.ToString();
        Buy2.text = 0.ToString();
        Buy3.text = 0.ToString();
        Buy4.text = 0.ToString();
        Buy5.text = 0.ToString();
        Buy6.text = 0.ToString();
        Sell0.text = 0.ToString();
        Sell1.text = 0.ToString();
        Sell2.text = 0.ToString();
        Sell3.text = 0.ToString();
        Sell4.text = 0.ToString();
        Sell5.text = 0.ToString();
        Sell6.text = 0.ToString();
    }
}
