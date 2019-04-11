using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    //PlayerEnemy playerEnemyコンポーネント
    PlayerEnemy playerEnemy;

    IEnumerator Start()
    {
        //PlayerEnemy コンポーネント取得
        playerEnemy = GetComponent<PlayerEnemy>();

        //ローカル座標のY軸のマイナス方向に移動する。
        playerEnemy.Move(transform.up * -1);

        while (true)
        {
            //子要素を全て取得する
            for(int i = 0; i < transform.childCount; i++) {

                Transform ShotPosition = transform.GetChild(i);

                //ShotPositionの位置/角度で弾を撃つ
                playerEnemy.Shot(ShotPosition);

            }
            //shotDelay秒待つ
            yield return new WaitForSeconds(playerEnemy.shotDelay);

             
        }

    }

}
