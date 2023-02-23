using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIInputKeys : MonoBehaviour
{
    public List<KeyBinding> keyMapping = new List<KeyBinding>();

    private void Update()
    {
        foreach(var keyMapped in keyMapping)
        {
            if (Input.GetKeyDown(keyMapped.key))
            {
                keyMapped.uiPanel.Toggle();
            }
        }
    }
}

[System.Serializable]
public class KeyBinding
{
    public UIBase uiPanel;
    public KeyCode key;
}
