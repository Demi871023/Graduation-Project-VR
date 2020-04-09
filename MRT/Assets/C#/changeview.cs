using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changeview : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void moveleft()
    {
        transform.Translate(0.3f, 0, 0);
    }


    public void moveright()
    {
        transform.Translate(-0.3f, 0, 0);
    }

    public void gotoBusstation()
    {
        SceneManager.LoadScene("bus station");
    }

    public void gototB1()
    {
        SceneManager.LoadScene("B1");
    }

    public void gotoplatform()
    {
        SceneManager.LoadScene("platform");
    }

     public void gotoclassroom()
    {
        SceneManager.LoadScene("classroom");
    }
}
