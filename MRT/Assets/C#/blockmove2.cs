using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blockmove2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Update()
{
    gameObject.transform.localPosition -= new Vector3(-0.03f, 0.02f, 0);
    if (this.transform.localPosition.x > 0)
    {
        gameObject.transform.localPosition = new Vector3(-8.4f, 5.6f, 0);

    }
}
}
