using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CalculatorUI : MonoBehaviour
{
    public Text displayText;

    void Start()
    {

        Calculator.intance.OnInput += OnInput;
        
        Calculator.intance.OnInputSound += OnInputSound;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnInputSound(int soundIndex)
    {
        
    }
    public void OnInput(string input)
    {
        
        Debug.Log(input);
        displayText.text = input;
    }
}
