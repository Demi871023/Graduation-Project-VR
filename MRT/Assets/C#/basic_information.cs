using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System.Text;
using System;
using UnityEngine.SceneManagement;

public class basic_information : MonoBehaviour
{
    string username,userage,usersex;
    string year,mouth,day;
    

    public void name(Text nameText)
    {
    	username = nameText.text;
    }

    public void getyear(Text ageText)
    {
    	year = ageText.text;
    }

    public void getmouth(Text ageText)
    {
        mouth = ageText.text;
    }

    public void getday(Text ageText)
    {
        day = ageText.text;

        writefile();
    }

    void writefile() 
    {
    	

    	//create folder
    	string path = "../file/" + username;

    	while(Directory.Exists(path))
    	{
    		path = path + "I";
    	}

    	Directory.CreateDirectory(path);


    	// create file
    	path = path + "/基本資料.txt" ;
    	FileStream file = File.Open(path , FileMode.OpenOrCreate,FileAccess.ReadWrite);

        //birthday to age
        DateTime dt = DateTime.Now;
        userage = year + "-" + mouth + "-" + day;
        DateTime dt1 = Convert.ToDateTime(userage);
        DateTime dt2 = Convert.ToDateTime(dt.ToShortDateString().ToString());
        TimeSpan span = dt2.Subtract(dt1);
        int dayDiff = span.Days + 1;
        dayDiff /= 365;


    	// write file
	    StreamWriter writer = new StreamWriter(file);

        writer.Write("姓名 : ");
        writer.WriteLine(username);
        writer.Write("生日 : ");
        writer.WriteLine(userage);
        writer.Write("年紀 : ");
        writer.WriteLine(dayDiff);
        writer.Write("性別 : ");
        writer.WriteLine(usersex);
  

        writer.Close();
    	

    }

    public void sex_b(bool sex)
    {
    	Debug.Log(sex);

    	if(sex == true)
    	{
    		usersex = "男生";
    	}

    	else
    	{
    		usersex = "女生";
    	}
    }

   public void sex_g(bool sex)
    {
    	Debug.Log(sex);

    	if(sex == true)
    	{
    		usersex = "女生";    		
    	}

    	else
    	{
    		usersex = "男生";

    	}
    }

    public void gotoinit()
    {
    	SceneManager.LoadScene(4);
    }
}
