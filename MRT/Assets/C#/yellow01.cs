using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yellow01 : MonoBehaviour
{
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.localPosition -= new Vector3(-0.03f, 0.02f, 0);
        if (this.transform.localPosition.x >0.2)
        {
            gameObject.transform.localPosition = new Vector3(-8.2f, 5.62f, 0);

        }
    }
}
