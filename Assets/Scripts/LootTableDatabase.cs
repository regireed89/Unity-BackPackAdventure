using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEditor;
using UnityEngine;


public class LootTableDatabase : EditorWindow
{
    public static string path;
    [MenuItem("Tools/LoootTableDatabase")]
    static void Init()
    {
        var window = EditorWindow.GetWindow(typeof(LootTableDatabase));
        window.Show();
        path = Application.dataPath;
    }
    private GUIStyle Header = new GUIStyle();
    public List<LootTable> tables = new List<LootTable>();

    private void OnGUI()
    {
        Header.alignment = TextAnchor.UpperCenter;
        Header.fontStyle = FontStyle.BoldAndItalic;
        Header.fontSize = 50;
        Header.normal.textColor = Color.cyan;
        GUILayout.Label("You shouldnt be here...", Header);
        GUILayout.Space(25);
        if (GUILayout.Button("This is a Button"))
        { }
        EditorGUILayout.LabelField("", path);
    }

}
