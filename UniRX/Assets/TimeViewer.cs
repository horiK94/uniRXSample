using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeViewer : MonoBehaviour
{
    [SerializeField] private TimeCounter timeCounter = null;
    [SerializeField] private Text text = null;

    private void Start()
    {
        timeCounter.OnTimeChanged += (time) =>
        {
            text.text = time.ToString();
        };
    }
}
