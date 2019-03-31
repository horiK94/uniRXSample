using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

public class Where : MonoBehaviour
{
    Subject<string> subject = new Subject<string>();

    private void Start()
    {
        subject.Where(x => x.Equals("Player"))
            .Subscribe(col => Debug.Log(string.Format("{0}と衝突しました", col.ToString())));

        subject.OnNext("Enemy");
        subject.OnNext("Player");
        subject.OnNext("Enemy");
        subject.OnNext("Player");
    }
}
