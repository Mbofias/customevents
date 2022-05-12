using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using CustomEvents;

[CustomEditor(typeof(CustomEvents.Event), editorForChildClasses: true)]
public class EventEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        GUI.enabled = Application.isPlaying;

        CustomEvents.Event myEvent = target as CustomEvents.Event;
        if (GUILayout.Button("Trigger"))
            myEvent.TriggerEvent();
    }
}
