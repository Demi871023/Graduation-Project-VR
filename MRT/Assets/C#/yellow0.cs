using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yellow0 : MonoBehaviour
{
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.localPosition -= new Vector3(-0.03f, 0, 0);
        if (this.transform.localPosition.x >= 2.6)
        {
            gameObject.transform.localPosition = new Vector3(0.02f, 0, 0);

        }
    }
}
