using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using System;

public class TimeCounterUniRX : MonoBehaviour
{
    //イベントを発行する核となるインスタンス
    private Subject<int> timeSubject = new Subject<int>();

    //イベントの購読部分だけ公開
    public IObservable<int> OnTimeChanged
    {
        get
        {
            return timeSubject;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(TimeCoroutine());
    }

    IEnumerator TimeCoroutine()
    {
        var time = 100;
        while(time > 0)
        {
            time--;

            timeSubject.OnNext(time);
            yield return new WaitForSeconds(1);
        }
    }
}
