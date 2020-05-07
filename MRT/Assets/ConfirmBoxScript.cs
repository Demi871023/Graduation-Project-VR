using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class ConfirmBoxScript : MonoBehaviour
{

    public GameObject BarPrefab;            // ConfirmBox 1
    public Canvas CanvasHead;
    protected Image ChatBackground;         // ConfirmBox 1 Background
    protected Text ChatText;                // ConfirmBox 1 Text
    protected Button SureBtn;       // ConfirmBox 1 Sure
    protected Button CancelBtn;     // ConfirmBox 1 Cancel

    public GameObject ConfirmBoxEmpty;

    
    public Button[] GetButtonArray;
    public Button[] GetButtonArray2;




    public void Show()
    {


        Canvas[] GetCanvasArray = GameObject.FindObjectsOfType<Canvas>();
        
        for(var i = 0 ; i < GetCanvasArray.Length ; i++)
        {
            //Debug.Log(GetCanvasArray[i].gameObject.name);
            if(GetCanvasArray[i].gameObject.name == "CanvasHead")
            {
                CanvasHead = GetCanvasArray[i];
                Debug.Log(i);

            }
        }

        Debug.Log("ConfirmBoxScript");
        ChatBackground =  Instantiate(BarPrefab, CanvasHead.transform).GetComponent<Image>();
        ChatText = ChatBackground.GetComponentInChildren<Text>();
        ChatText.text = null;

        GetButtonArray = GameObject.FindObjectsOfType<Button>();
        for(var j = 0 ; j < GetButtonArray.Length ; j++)
        {
            // index = 1
            if(GetButtonArray[j].gameObject.name == "SureButton")
            {
                SureBtn = GetButtonArray[j];
                Debug.Log(j);
                Debug.Log(GetButtonArray[j].gameObject.name);
            }
            // index = 0
            if(GetButtonArray[j].gameObject.name == "CancelButton")
            {
                CancelBtn = GetButtonArray[j];
                Debug.Log(j);
                Debug.Log(GetButtonArray[j].gameObject.name);
            }
        }

        //NextStringBtnSure = ChatBackground.GetComponentInChildren<Button>();
        //NextStringBtnCancel.GetComponentInChildren<Text>() = "取消";
        //Debug.Log(NextStringBtnSure.name);
        //NextStringBtnSure = ChatBackground.GetComponentInChildren<Button>();
    }

    void Start()
    {
        
    }

    
    void Update()
    {
        GetButtonArray2 = GameObject.FindObjectsOfType<Button>();
        for(var j = 0 ; j < GetButtonArray2.Length ; j++)
        {
            // index = 1
            if(GetButtonArray2[j].gameObject.name == "SureButton")
            {
                SureBtn = GetButtonArray2[j];
                SureBtn.GetComponentInChildren<Text>().text = "確認";
                //Debug.Log(j);
                //Debug.Log(GetButtonArray2[j].gameObject.name);
            }
            // index = 0
            if(GetButtonArray2[j].gameObject.name == "CancelButton")
            {
                CancelBtn = GetButtonArray2[j];
                //Debug.Log(j);
                //Debug.Log(GetButtonArray2[j].gameObject.name);
            }
        }
    }
}
