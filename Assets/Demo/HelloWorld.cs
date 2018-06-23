﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    public HelloWorld()
    {

    }

    public HelloWorld(int x, int y, int z)
    {

    }

    public HelloWorld(int x, int y, int z, int w, params object[] param)
    {
        Debug.LogFormat("x:{0} y:{1} z:{2} w:{3}", x, y, z, w);
    }

    List<string> onTexts = new List<string>();

    private void Awake()
    {
#if USE_HOT
        wxb.hotMgr.Init();
#endif

        Debug.LogFormat("GetValue:{0}", GetValue);

        int refValue = 0;
        int outValue = 0;
        Test(ref refValue, out outValue);
        Debug.LogFormat("ref value:{0} out value:{1}", refValue, outValue);
    }

    void Test(ref int refValue, out int outValue)
    {
        refValue = 100;
        outValue = 200;
    }

    public int GetValue
    {
        get
        {
            return 0;
        }
    }

    void Start()
    {
        onTexts.Add("HelloWorld Start()");
    }

    void OnEnable()
    {
        onTexts.Add("HelloWorld OnEnable()");
    }

    void OnDisable()
    {
        onTexts.Add("HelloWorld OnDisable()");
    }

    private void OnGUI()
    {
        foreach (var ator in onTexts)
            GUILayout.Label(ator);
    }
}