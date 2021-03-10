using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    float x = -10.0f;           // X座標
    int score = 0;              // スコア

    public GameObject goal;     // ゴールオブジェクト

    // 毎フレーム実行される
    void Update()
    {
        // 右矢印が押されている場合
        if (Input.GetKey(KeyCode.RightArrow))
        {
            // 右に移動
            x += 5.0f * Time.deltaTime;
        }
        // 左矢印が押されている場合
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            // 左に移動
            x -= 5.0f * Time.deltaTime;
        }

        // 位置を更新
        transform.localPosition = new Vector3(x, 0, 0);
    }

    // 当たり判定が検出されたときに実行される
    private void OnTriggerEnter(Collider other)
    {
        // ゴールと接触した場合
        if (other.gameObject == goal)
        {
            // スコアを加算
            score++;

            // スタート地点に戻る
            x = -10.0f;
        }
        else
        {
            // ゲームオーバー（自機を消す）
            Destroy(gameObject);
        }
    }
}
