using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeCounter : MonoBehaviour
{
    //C言語で言うところの関数ポインタ
    /// <summary>
    /// イベントハンドラ(イベントメッセージの型定義)
    /// </summary>
    /// <param name="time"></param>
    public delegate void TimeEventHandler(int time);

    /*
     * デリゲートに対する「プロパティ」みたいなもの
     * ・デリゲート呼び出しはクラスの内部からのみ可能
     * 外部からはデリゲートの追加/
     * */
    /// <summary>
    /// 
    /// </summary>
    public event TimeEventHandler OnTimeChanged;

    private void Start()
    {
        StartCoroutine(TimeCountinue());
    }

    //何をするか決める関数部分を外部に決めてもらい、いつその関数を呼ぶかはeventを作成した側が呼ぶ
    /// <summary>
    /// カウントダウン
    /// </summary>
    /// <returns></returns>
    IEnumerator TimeCountinue()
    {
        var time = 100;
        while(time > 0)
        {
            time--;
            OnTimeChanged(time);

            yield return new WaitForSeconds(1);
        }
    }
}
