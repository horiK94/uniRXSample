using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

public class OnNextAndSubScribe : MonoBehaviour
{
    Subject<string> subject = new Subject<string>();

    private void Start()
    {
        subject.Subscribe(msg => Debug.Log("Subscribe1" + msg));
        subject.Subscribe(msg => Debug.Log("Subscribe2" + msg));
        subject.Subscribe(msg => Debug.Log("Subscribe3" + msg));

        subject.OnNext("おはようから");       //登録されt関数をすべて行う
        subject.OnNext("お休みまで");
    }
}
