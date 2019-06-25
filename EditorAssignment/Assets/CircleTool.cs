using UnityEngine;
using UnityEditor;

public class CircleTool : EditorWindow
{
    LineRenderer LineRenderer;
    GameObject GameObject;

    Vector3 Position;
    Color Color;
    int Segments;
    float Radius;
    float Width;

    [MenuItem("Window/CircleTool")]
    static void Init()
    {
        CircleTool window = (CircleTool)EditorWindow.GetWindow(typeof(CircleTool));
        window.Show();
        GetWindow<CircleTool>("CircleTool");
    }

    void OnGUI()
    {
        GUILayout.Label("Circle Settings.", EditorStyles.boldLabel);

        GameObject = (GameObject)EditorGUI.ObjectField(new Rect(3, 3, position.width - 6, 20), "Find Dependency", GameObject, typeof(GameObject));

        Position = EditorGUILayout.Vector3Field("Position", Position);
        Color = EditorGUILayout.ColorField("Color", Color);
        Segments = EditorGUILayout.IntField("Segments", Segments);
        Radius = EditorGUILayout.FloatField("Radius", Radius);
        Width = EditorGUILayout.FloatField("Width", Width);

        if (GUILayout.Button("DrawCircle"))
        {
            OnButtonPressed();
        }
    }

    void OnButtonPressed()
    {
        LineRenderer = GameObject.GetComponent<LineRenderer>();

        LineRenderer.SetPosition(0, Position);
        LineRenderer.startWidth = Width;
        LineRenderer.endWidth = Width;

        for (int i = 0; i < Segments; i++)
        {
        }
    }
}