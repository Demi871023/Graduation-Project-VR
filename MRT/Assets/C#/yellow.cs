using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yellow : MonoBehaviour
{
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.localPosition -= new Vector3(0.03f, 0, 0);
        if (this.transform.localPosition.x <= -0.4)
        {
            gameObject.transform.localPosition = new Vector3(2.6f, 0, 0);

        }
    }
}
