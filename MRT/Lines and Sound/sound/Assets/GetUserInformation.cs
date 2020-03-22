using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GetUserInformation : MonoBehaviour
{

    public ToggleGroup GenderRadioButton;
    //public InputField UserName;
    protected Button StartBtn;


    // Start is called before the first frame update
    void Start()
    {
        GenderRadioButton = GetComponent<ToggleGroup>();
        //UserName = FindObjectOfType<Canvas>().GetComponent<InputField>();
        StartBtn = GetComponent<Button>();
        //SelectToggle(1);

        //StartBtn.onClick.AddListener(Click);

        //Debug.Log("Check");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Click()
    {
        //UserName.text = "Hi";
        Debug.Log("Click");
    }

    /*public void SelectToggle(int id)
    {
        var toggles = GenderRadioButton.GetComponentInChildren<Toggles>();
        toggles[id].isOn = true;
    }*/
}
