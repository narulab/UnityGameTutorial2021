using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    float y = 12.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 下に移動
        y -= 10.0f * Time.deltaTime;

        // 位置を更新
        transform.localPosition = new Vector3(0, y, 0);
    }
}
