using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{

    int hp = 100;   // 体力
    int power = 25; // 攻撃力
    int mp = 53;    //MP
    int damage = 3; //ダメージ

    // Use this for initialization
    void Start()
    {

        // 配列を初期化する
        int[] array = { 34, 25, 52, 19, 82 };

        // 配列を順番に表示する
        for (int i = 0; i < 5; i++)
        {
            // 配列の要素を表示する
            Debug.Log(array[i]);
        }

        // 配列を逆順に表示する
        for (int y = 4; y > -1; y--)
        {
            // 配列の要素を表示する
            Debug.Log(array[y]);
        }
    }

    // 攻撃用の関数
    public void Attack()
    {
        Debug.Log(power + "のダメージを与えた");

        Debug.Log(damage + "のダメージを受けた。残りHPは" + hp + "だ!");
        // 残りhpを減らす
        hp -= damage;
    }

    // 魔法用の関数
    public void Magic()
    {
        if (mp >= 5)
        {
            mp -= 5;
            Debug.Log("魔法攻撃をした。残りMPは" + mp);
        }
        else
        {
            Debug.Log("MPが足りたため魔法が使えない。");
        }

        Debug.Log(damage + "のダメージを受けた。残りHPは" + hp + "だ!");
        // 残りhpを減らす
        hp -= damage;
    }
}