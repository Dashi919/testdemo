using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;

[Serializable]
public class Test2 
{
    [DllImport("TestDLL")]
    public static extern int Add(int a, int b);
         
}
