using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class Courotines : MonoBehaviour
{
    public UnityEvent repeatEvent;
    public UnityEvent onStart;
    public UnityEvent onEndEvent;
    public UnityEvent realStart, playRepeatingEvent;

    public IntData countdownObj;
    public int countDownSecs;
    public float seconds = 2f;
    public float second = 1f;
    public WaitForSeconds wfs, wfss;
    public WaitForFixedUpdate wffu;

    public bool canRun;

    public IEnumerator Start()
    {
        wfss = new WaitForSeconds(seconds);
        wfs = new WaitForSeconds(second);
        wffu = new WaitForFixedUpdate();
        realStart.Invoke();
        yield break;
    }

    public void DownCounterStart()
    {
        StartCoroutine(DownCounter());
    }
    
    IEnumerator DownCounter()
    {
        onStart.Invoke();
        //Debug.Log("Start");

        while (countDownSecs >= 2)
        {
            yield return wfs;
            repeatEvent.Invoke();
            Debug.Log(repeatEvent);
            countDownSecs = countdownObj.number;
        }

        yield return wfs;
        onEndEvent.Invoke();
        //Debug.Log("End");
    }

    public void RepeatUntilFalseStart()
    {
        canRun = true;
        StartCoroutine(RepeatUntilFalse());
    }

    IEnumerator RepeatUntilFalse()
    {
        while (canRun == true)
        {
            yield return wfss;
            playRepeatingEvent.Invoke();
            //Debug.Log("Repeat Until False Running");
        }
    }
}
