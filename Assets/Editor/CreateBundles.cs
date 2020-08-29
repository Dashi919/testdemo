using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;

public class CreateBundles : EditorWindow
{
    AssetBundle bundle;
   [MenuItem("Menu/SliderTest")]
    public static void LoadAssets()
    {
        EditorWindow.GetWindow<CreateBundles>().Show();
    }
    public float val = 100;
    public int int1;
    public float maxl;
    public float minl;

    public void OnGUI()
    {
       
    }

}
