using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Test2))]
public class Test : Editor
{
   public SerializedObject seO;
   public SerializedProperty enum1;
   public SerializedProperty int1;
   public SerializedProperty float1;
   public SerializedProperty str1;


    public void OnEnable()
    {
        this.seO = new SerializedObject(target);
        this.enum1 = seO.FindProperty("enum1");
        this.int1 = seO.FindProperty("int1");
        this.float1 = seO.FindProperty("float1");
        this.str1 = seO.FindProperty("str1");
    }

    public override void OnInspectorGUI()
    {
        this.seO.Update();
        EditorGUILayout.PropertyField(this.enum1);
        switch (this.enum1.enumValueIndex)
        {
            case 0:
                EditorGUILayout.PropertyField(this.int1);
                break;
            case 1:
                EditorGUILayout.PropertyField(this.float1);
                break;
            case 2:
                EditorGUILayout.PropertyField(this.str1);
                break;
        }
        this.seO.ApplyModifiedProperties();
    }
}
