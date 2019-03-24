using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Calculator : MonoBehaviour
{
    public InputField inputField1;
    public InputField inputField2;
    public Text resultText;

    void Start()
    {
        resultText.text = "0";
    }

    public void Add()
    {
        int number1 = int.Parse(inputField1.text);
        int number2 = int.Parse(inputField2.text);
        resultText.text = (number1 + number2).ToString();
    }

    public void Subtract()
    {
        int number1 = int.Parse(inputField1.text);
        int number2 = int.Parse(inputField2.text);
        resultText.text = (number1 - number2).ToString();
    }

    public void Multiply()
    {
        int number1 = int.Parse(inputField1.text);
        int number2 = int.Parse(inputField2.text);
        resultText.text = (number1 * number2).ToString();
    }

    public void Divide()
    {
        int number1 = int.Parse(inputField1.text);
        int number2 = int.Parse(inputField2.text);
        resultText.text = (number1 / number2).ToString();
    }
}
