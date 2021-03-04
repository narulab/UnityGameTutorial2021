using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    float x = 0.0f;
    float y = 12.0f;
    float speed = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 下に移動
        y -= speed * Time.deltaTime;

        // 地面より下に行った場合
        if (y < 0.0f)
        {
            // 位置をリセット
            x = Random.Range(-8.0f, 8.0f);
            y = 12.0f;
            speed = Random.Range(5.0f, 15.0f);
        }

        // 位置を更新
        transform.localPosition = new Vector3(x, y, 0);
    }
}
