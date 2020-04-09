using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIController : MonoBehaviour {
    // public Text outText;
     public UnityEngine.UI.Text outText;

// public void OnButtonClicked()
//     {
        
//             outText.text = " clicked, 按鈕1";
//     }
 	public void OnButtonClicked(Button but) {
        // if (outText != null) {
        //     outText.text = "<b>Last Interaction:</b>\nUI Button clicked";
        // }

 		//outText.text = "<b>Last Interaction:</b>\nUI Button clicked";
 		SceneManager.LoadScene("classroom");


        /*if("Button".Equals(but.name) )
        {
        	 outText.text = "<b>Last Interaction:</b>\nUI Button clicked";
        }

        if("Button (1)".Equals(but.name))
        {
        	SceneManager.LoadScene("selection_all");
        }*/
    }

 	// public void Clicked() {
  //       if (outText != null) {
            
  //       }
  //   }
}

//UIController