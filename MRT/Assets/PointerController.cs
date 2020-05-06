using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.Extras;
using UnityEngine.UI;
using System.IO;

public class PointerController : SteamVR_LaserPointer
{

    // string ReadFilePath;
    // public MoleAttackChat MoleTemp;
    // int ListIndex = 0;

    // public List<string> ChatStringList = new List<string>();

    //public GameObject BarPrefab;
    //public GameObject Sheep;
    // protected Image ChatBackground;
    // protected Text ChatText;
    // protected Button NextStringBtn;
    // protected Button NextStringWithBtn;
    public GameObject ConfirmBoxEmpty;

    Transform previousContact = null;
    protected int Inited = 0;

    public string ELFName = "";

    void jumochat(GameObject obj)
    {
        Debug.Log("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        Debug.Log(obj.tag);
        ELFName = obj.tag;

        ConfirmBoxScript ConfirmBox = ConfirmBoxEmpty.GetComponent(typeof(ConfirmBoxScript)) as ConfirmBoxScript;
        ConfirmBox.Show();
        //ChatScript chat = obj.GetComponent(typeof(ChatScript)) as ChatScript;
        //chat.Show(obj.tag);

  //       ChatBackground = Instantiate(BarPrefab, FindObjectOfType<Canvas>().transform).GetComponent<Image>();
		// ChatBackground.transform.position = obj.transform.position + new Vector3(0, 1.2f, 0);
  // 		Vector3 temp = new Vector3(obj.transform.eulerAngles.x, obj.transform.eulerAngles.y + 180, obj.transform.eulerAngles.z);
  // 		ChatBackground.transform.eulerAngles = temp;
  // 		ChatText.text = "哈哈哈";

        // float dist = 100f;

        // Ray raycast = new Ray(transform.position, transform.forward);
        // RaycastHit hit;
        // bool bHit = Physics.Raycast(raycast, out hit);


        // PointerEventArgs argsClick = new PointerEventArgs();
        // argsClick.fromInputSource = pose.inputSource;
        // argsClick.distance = hit.distance;
        // argsClick.flags = 0;
        // argsClick.target = hit.transform;

    	 // //得到指向的的物体
      //   GameObject objtarget = argsClick.target;
      //   //判断物体的Tag是不是Obj 或者是判断是不是可以拾取的物体
      //   if (argsClick..Equals("Object"))
      //   {
      //       //用全局变量targert记录这个物体
      //       targert = objtarget;
      //       print("catch");
      //   }

        // Debug.Log(argsClick);

        // OnPointerClick(argsClick);

    }

    void WriteProfileELF(string user_name, string ELF_Name)
    {
        Debug.Log(user_name);
        Debug.Log(ELF_Name);
    }
    

    public override void OnPointerClick(PointerEventArgs e)
    {
        base.OnPointerClick(e);

        // Debug.Log("Click");


        switch(e.target.gameObject.tag) {


            case "Sheep":
            case "Penguin":
            case "MoleAttack":
            case "LoveDuck":
            case "Cat":
                Debug.Log(e.target.gameObject.tag);
                jumochat(e.target.gameObject);
                break;
            case "ConfirmBoxSureButton":
                //string name = "劉品萱";
                WriteProfileELF("name", ELFName);
                break;
            default:
                return;
        }

        // if(e.target.gameObject.tag == "Sheep")
        // {
        //     Debug.Log("Click Sheep");
        //     jumochat(e.target.gameObject);

        //     // Destroy(e.target.gameObject);
        // }
        // if(e.target.gameObject.tag == "Penguin")
        // {
        //     Debug.Log("Click Penguin");
        //     //Destroy(e.target.gameObject);
        // }
        // if(e.target.gameObject.tag == "MoleAttack")
        // {
        //     Debug.Log("Click MoleAttack");
        //     //Destroy(e.target.gameObject);
        // }
        // if(e.target.gameObject.tag == "LoveDuck")
        // {
        //     Debug.Log("Click LoveDuck");
        //     //Destroy(e.target.gameObject);
        // }
        // if(e.target.gameObject.tag == "Cat")
        // {
        //     Debug.Log("Click Cat");
        //     //Destroy(e.target.gameObject);
        // }
        // if(e.target.gameObject.tag == "ChatBoxButton")
        // {
        // 	Debug.Log("Click Button");
        // 	//Hello();
        // 	// MoleTemp.Print();
        // }
        
    }

    /*void Hello()
    {
        ChatText.text = ChatStringList[ListIndex];
        ListIndex++;
        Debug.Log("Hello Hello Hello");
    }*/
}