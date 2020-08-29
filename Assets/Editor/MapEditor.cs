using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;



public class MapEditor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    [MenuItem("Menu/Test #W" )]
    private static void Test()
    {
        Debug.Log("Hello World");
    }

    [ContextMenu("PrintHello")]
    public void Print()
    {
        Debug.Log("Hello");
    }
}
