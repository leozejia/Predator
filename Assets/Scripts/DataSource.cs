using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;

public class DataSource : MonoBehaviour
{
    [DllImport("testdllsarjam")]
    private static extern int funcjammer(double[] x, int y);

    // Start is called before the first frame update
    void Start()
    {
        double[] x = { 112.66611111, 35.19555556, 6000, 0.0 };
        //Debug.Log(funcjammer(x, 4));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
