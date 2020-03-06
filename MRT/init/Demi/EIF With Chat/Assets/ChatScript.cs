using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

String[] ChatString;

public class ChatScript : MonoBehaviour
{

    public GameObject BarPrefab;
    protected Image ChatBackground;
    protected Text ChatText;
    //protected Button NextStringBtn;


    // Start is called before the first frame update
    void Start()
    {
        // 在按下 play 時取得 ChatBackground 和 ChatText
        ChatBackground =  Instantiate(BarPrefab, FindObjectOfType<Canvas>().transform).GetComponent<Image>();
        ChatText = new List<Text>(ChatBackground.GetComponentsInChildren<Text>()).Find(img => img != ChatBackground);
        
        //NextStringBtn = BarPrefab.GetComponent<Button>();
        //NextStringBtn = FindObjectOfType<Canvas>().GetComponent<Button>();
        //NextStringBtn.onClick.AddListener(NextStr);
        //NextString = new List<Button>(ChatBackground.GetComponentsInChildren<BUtton>()).Find(img => img != ChatBackground);
        //NextString.onClick.AddListener(NextStr);
    }

    // Update is called once per frame
    void Update()
    {
        ChatText.text = "安扭哈誰優";
        ChatBackground.transform.position = Camera.main.WorldToScreenPoint(transform.position + new Vector3(0, 2f, 0));
    }

    void NextStr()
    {
        //Debug.Log("Just Test");
        ChatText.text = "哈哈哈哈哈哈";
    }
}
