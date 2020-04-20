using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class objectB : MonoBehaviour
{
    private void OnMouseDown()       //滑鼠按下
    {
        Destroy(this.gameObject);
        
    }
    private void OnMouseEnter()       //滑鼠移入物體
    {
        this.transform.localScale = new Vector3(1.2f, 1.2f, 1.2f);
        
    }
    private void OnMouseExit()         //滑鼠移出
    {
        
        this.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
    }
}
