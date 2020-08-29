using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    AssetBundle bundle;
  
    public  void Start()
    {
        StartCoroutine(AssetsLoad());

     
     }
    IEnumerator AssetsLoad()
    {
        string dir = "Assets/AsserBundles/1.unity3d/1.unity3d.manifest";
        bundle = AssetBundle.LoadFromFile("Assets/AsserBundles/1.unity3d");
        yield return null;
        string[] names = bundle.GetAllAssetNames();
        foreach (string str in names)
        {
            Debug.Log(str);
        }

    }
}
