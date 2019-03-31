using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UniRx;

public class TimeViewerUniRX : MonoBehaviour
{
    [SerializeField] private TimeCounterUniRX timeCounter = null;
    [SerializeField] private Text counterText = null;

    private void Start()
    {
        timeCounter.OnTimeChanged.Subscribe(_time =>
        {
            counterText.text = _time.ToString();
        });
    }
}
