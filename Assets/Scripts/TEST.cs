using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Leo;
using System.Runtime.InteropServices;

public class TEST : MonoBehaviour
{
    public Path path = null;

    [DllImport("TestDLL")]
    private static extern long dlltest();

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(dlltest());
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            path.SetPath("Satellite");
        }
        else if(Input.GetKeyDown(KeyCode.B))
        {
            path.SetPath("Predator");
        }
    }
}