using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class PenguinChat : MonoBehaviour
{

    string ReadFilePath;
    int ListIndex = 0;

    public List<string> ChatStringList = new List<string>();

    public GameObject BarPrefab;
    protected Image ChatBackground;
    protected Text ChatText;
    protected Button NextStringBtn;
    protected Button NextStringWithBtn;


    // Start is called before the first frame update
    void Start()
    {

        // 讀入劇本台詞檔案
        ReadFilePath = Application.dataPath + "/PenguinChatString.txt";
        ReadFile(ReadFilePath);

        // 在 Canvas 生成 ChatBackgroundWithBtn，底下有子物件：文字與按鈕
        ChatBackground =  Instantiate(BarPrefab, FindObjectOfType<Canvas>().transform).GetComponent<Image>();
        ChatText = ChatBackground.GetComponentInChildren<Text>();
        ChatText.text = null;
        NextStringWithBtn = ChatBackground.GetComponentInChildren<Button>();

        // 替按鈕新增監聽事件
        NextStringWithBtn.onClick.AddListener(Hello);
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(transform.position);
        //Debug.Log(ChatBackground.transform.position);
        //ChatBackground.transform.position = Camera.main.WorldToScreenPoint(transform.position + new Vector3(0, 10, 0));
        ChatBackground.transform.position = transform.position + new Vector3(0, 3, 0);
        //Vector3 move = GameObject.transform.eulerAngles;
        Vector3 temp = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y + 180, transform.eulerAngles.z);
        //ChatBackground.transform.eulerAngles = new eulerAngles();
        ChatBackground.transform.eulerAngles = temp;
        //ChatBackground.rotation = transform.rotation;
        Debug.Log("========================================");
        Debug.Log(ChatBackground.transform.eulerAngles.y);
        Debug.Log(transform.eulerAngles.x);
        Debug.Log(transform.eulerAngles.y);
        Debug.Log(transform.eulerAngles.z);
        Debug.Log(transform.rotation);
        ChatText.text = "哈哈哈哈";
        //ChatBackground.transform.position = Camera.main.WorldToScreenPoint(transform.position);

    }

    // 創建 StreamReader 來讀入 txt 檔案中的句子（以一行為單位）
    void ReadFile(string filePath)
    {
        StreamReader sReader = new StreamReader(filePath);
        while(!sReader.EndOfStream)
        {
            string line = sReader.ReadLine();
            ChatStringList.Add(line);
        }
        sReader.Close();
    }

    void Hello()
    {
        ChatText.text = ChatStringList[ListIndex];
        ListIndex++;
        Debug.Log("Hello Hello Hello");
    }
}