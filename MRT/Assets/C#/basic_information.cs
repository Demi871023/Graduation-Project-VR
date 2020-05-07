using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System.Text;
using UnityEngine.Networking;
using System;
using UnityEngine.SceneManagement;

public class basic_information : MonoBehaviour
{
    public Text error,year,mouth,day,name,gender,noise;
    int age ;
    
    
    public void ONclick()
    {

        error.text = "";
        var flag = 0;
        flag = noempty();
        
        if(flag != 1)
        {
            if(colculatedage())
            {   
                //寫進資料夾
                writefile();
                //寫進server
                StartCoroutine("sendtoserver");
            }
            else
            {
                error.text += "你的年齡很酷喔~再仔細看看有沒有錯吧\n";
            }
        }   
    }

    bool colculatedage()
    {
        DateTime dt = DateTime.Now;
        string userage = year.text + "-" + mouth.text + "-" + day.text;
        DateTime dt1 = Convert.ToDateTime(userage);
        DateTime dt2 = Convert.ToDateTime(dt.ToShortDateString().ToString());
        TimeSpan span = dt2.Subtract(dt1);
        int dayDiff= span.Days + 1;
        dayDiff /= 365;

        if(dayDiff >=0 && dayDiff　<=100 && year.text.Length == 4)
        {
            age = dayDiff;
            return true;
        }
        else if(dayDiff >=0 && dayDiff　<=100 && year.text.Length == 2)
        {
            age = dayDiff-11;
            return true;
        }
        else
            return false;

    }

    int noempty()
    {
        int flag = 0;

        // 性別判斷
        if(name.text == "")
        {
            error.text += "你的名字是空的喔~\n";
            flag = 1;
        }

        // 性別判斷
        if(gender.text == "")
        {
            error.text += "性別要填喔~\n";
            flag =1;
        }
        if(gender.text != "男" && gender.text != "女")
        {
            error.text += "幫我按照格式填喔~\n男 或 女\n";
            flag = 1;
        }

        // 日期判斷
        if(year.text == "" || mouth.text == "" || day.text == "" )
        {
            error.text += "你的生日沒有填完整喔~\n";
            flag = 1;
        }

        //年的判斷
        int temp = -1;
        try{
            temp = int.Parse(year.text);
        }catch(Exception e)
        {
            error.text += "年分的格式是數字喔~\n";
            flag = 1;
        }

        // 月的判斷
        temp = -1;
        try{
           temp = int.Parse(mouth.text);
        }catch(Exception e)
        {
            error.text += "月份的格式是數字喔~\n";
            flag = 1;
        }


        if((temp <=0 || temp >=13 )&& temp != -1)
        {
            error.text += "月份超出範圍了喔~\n";
            flag = 1;
        }


        // 日的判斷
        temp = -1;
        try{
           temp = int.Parse(day.text);
        }catch(Exception e)
        {
            error.text += "日期的格式是數字喔~\n";
            flag = 1;
        }
        if((temp <=0 || temp >=33) && temp != -1)
        {
            error.text += "日期超出範圍了喔~\n";
            flag = 1;
        }

        // 噪音忍受度判斷
        float tmp = -1;
        try{
            tmp = float.Parse(noise.text);
        }catch(Exception e)
        {
             error.text += "噪音的格式是數字或小數喔~\n";
             flag = 1;
        }
        if(noise.text == "")
        {
            error.text += "噪音忍受度也要填喔~\n";
            flag = 1;
        }

        if((tmp <0 || tmp >10) && tmp != -1)
        {
            error.text += "噪音超出範圍了喔~\n";
            flag = 1;
        }
        return flag;
    }

   void  writefile() 
    {
    	

    	//create folder
    	string path = "../file/" + name.text;

    	while(Directory.Exists(path))
    	{
    		path = path + "I";
    	}

    	Directory.CreateDirectory(path);
    	// create file
    	path = path + "/基本資料.txt" ;
    	FileStream file = File.Open(path , FileMode.OpenOrCreate,FileAccess.ReadWrite);

    	// write txt
	    StreamWriter writer = new StreamWriter(file);
        writer.Write("姓名 : ");
        writer.WriteLine(name.text);
        writer.Write("年 : ");
        writer.WriteLine(year.text);
        writer.Write("月 : ");
        writer.WriteLine(mouth.text);
        writer.Write("日 : ");
        writer.WriteLine(day.text);
        writer.Write("年紀 : ");
        writer.WriteLine(age);
        writer.Write("性別 : ");
        writer.WriteLine(gender.text);
        writer.Close();
    	

    }

    IEnumerator sendtoserver()
    {
        WWWForm form = new WWWForm();
        form.AddField("name", name.text);
        form.AddField("age",age);
        form.AddField("year",year.text);
        form.AddField("mouth",mouth.text);
        form.AddField("day",day.text);
        form.AddField("sex",gender.text);
        form.AddField("noise",noise.text);

        UnityWebRequest www = UnityWebRequest.Post("http://140.136.150.92:3000/login/loginpost",form);

        yield return www.SendWebRequest();

        if (www.isNetworkError || www.isHttpError)
        {
            Debug.Log(www.error);
        }
        else
        {
            string tt = www.downloadHandler.text;
            string[] word = tt.Split('\"',':',',','}');
            
           
            /*
            Debug.Log("4 : "+word[4]); //user_name
            Debug.Log("9 : "+word[9]); //progress_scene
            Debug.Log("13 : "+word[13]); //progress_problem
            Debug.Log("17 : "+word[17]); //x
            Debug.Log("21 : "+word[21]); //y
            Debug.Log("25 : "+word[25]); //z
            */

            if(word[9] == "1")
            {
                Application.LoadLevel(4);
            }

        }
    
    }
}
