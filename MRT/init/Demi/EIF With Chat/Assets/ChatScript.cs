using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;



public class ChatScript : MonoBehaviour
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
        ReadFilePath = Application.dataPath + "/ChatString.txt";
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
        ChatBackground.transform.position = Camera.main.WorldToScreenPoint(transform.position + new Vector3(0, 10f, 0));
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
