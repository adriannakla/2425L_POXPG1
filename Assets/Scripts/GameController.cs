using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public string Word = "after";
    public TextMeshProUGUI MainWord;
    public TextMeshProUGUI OurInput;
    public TextMeshProUGUI SubmittedInput;
    public TMP_InputField InputField;


    // Start is called before the first frame update
    void Start()
    {
        MainWord.text = Word;
    }

    public void OnInputChanged(string input)
    {
        OurInput.text = input;

    }

    public void OnClick()
    {
        SubmittedInput.text = OurInput.text;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
