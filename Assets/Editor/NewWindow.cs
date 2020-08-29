using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class NewWindow : EditorWindow
{
    [MenuItem("Menu/ShowWindow")]
    public static void ShowWindow()
    {
        NewWindow.GetWindow<NewWindow>().Show();
    }

    public string user = "";
    public string password = "";
    public void OnGUI()
    {
        EditorGUILayout.LabelField("请输入用户名");
       user = EditorGUILayout.TextField(user);
        EditorGUILayout.LabelField("请输入密码");
        password = EditorGUILayout.PasswordField(password);
        if (GUILayout.Button("登陆"))
        {
            if(user == "Dashi" && password == "123456")
            {
                Debug.Log("登陆成功");
            }
            else
            {
                Debug.Log("登陆失败") ;
            }
        }
    }

}
