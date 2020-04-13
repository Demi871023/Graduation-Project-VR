using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class basicinformation : MonoBehaviour
{
    public Text playerName;////(1)

    public void EnterPlayerName(Text enterText){////(2)
        playerName.text = enterText.text;////(3)

        writefile(enterText);

    }

    void writefile(Text enterText)
    {
    	string path = "C:/Users/user/Desktop/inputTXT.txt";

        StreamWriter writer = new StreamWriter(path,true);

        writer.Write("Name : ");
        writer.WriteLine(enterText.text);
        writer.Close();
    }
}
