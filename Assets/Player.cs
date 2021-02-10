using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    float x = 0.0f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            x += 3.0f * Time.deltaTime;
        }
        transform.localPosition = new Vector3(x, 0, 0);
    }
}
