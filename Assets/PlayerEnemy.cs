using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerEnemy : MonoBehaviour
{
    //移動スピード変数を宣言
    public float speed;

    //弾を撃つ間隔の変数を宣言
    public float shotDelay;

    //弾のプレハブの変数を宣言
    public GameObject EnemyBullet;

    //弾の作成 Shotメソッド
    public void Shot(Transform origin)
    {
      Instantiate(EnemyBullet, origin.position, origin.rotation);

    }
    
    //機体、敵の移動メソッド
    public void Move(Vector2 direction)
    {
        GetComponent<Rigidbody2D>().velocity = direction * speed;
    
    }

}

