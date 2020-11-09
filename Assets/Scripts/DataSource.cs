using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;
using System;

public class DataSource : MonoBehaviour
{
    [DllImport("testdllsarjam")]
    private static extern int funcjammer(double[] x,int y);

    // Start is called before the first frame update
    void Start()
    {
        double[] sarsingle = new double[4];
        sarsingle[0] = 112.66611111; //经度
        sarsingle[1] = 35.19555556; //纬度
        sarsingle[2] = 6000; //高度
        sarsingle[3] = 0.0; //航向（北偏东）
        try
        {
            Debug.Log(funcjammer(sarsingle, 4));
        }
        catch (Exception e){
            Debug.LogError(e.Message);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
