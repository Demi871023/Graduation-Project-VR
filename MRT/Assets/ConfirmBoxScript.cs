using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class ConfirmBoxScript : MonoBehaviour
{

    public GameObject BarPrefab;			// ConfirmBox 1
    protected Image ChatBackground;			// ConfirmBox 1 Background
    protected Text ChatText;				// ConfirmBox 1 Text
    protected Button NextStringBtnSure;		// ConfirmBox 1 Sure
    protected Button NextStringBtnCancel; 	// ConfirmBox 1 Cancel

    public GameObject ConfirmBoxEmpty;




    public void Show()
    {
    	Debug.Log("ConfirmBoxScript");
    	ChatBackground =  Instantiate(BarPrefab, FindObjectOfType<Canvas>().transform).GetComponent<Image>();
        ChatText = ChatBackground.GetComponentInChildren<Text>();
        ChatText.text = null;

        NextStringBtnSure = ChatBackground.GetComponentInChildren<Button>();
        //NextStringBtnCancel.GetComponentInChildren<Text>() = "取消";
        Debug.Log(NextStringBtnSure.name);
    	//NextStringBtnSure = ChatBackground.GetComponentInChildren<Button>();
    }

    void Start()
    {
        
    }

    
    void Update()
    {
        if(ChatBackground != null) {
        	//Debug.Log(transform.position);
            Vector3 temp = new Vector3(ConfirmBoxEmpty.transform.eulerAngles.x, ConfirmBoxEmpty.transform.eulerAngles.y, ConfirmBoxEmpty.transform.eulerAngles.z);
            ChatBackground.transform.position = temp + new Vector3(30.8f, 2.8f, 10f); 
            
        }
    }
}
