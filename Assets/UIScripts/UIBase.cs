using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIBase : MonoBehaviour
{

    public UIBase root;

    public virtual void Toggle()
    {
        if (gameObject.activeInHierarchy)
        {
            Hide();
        }
        else
        {
            Show();
        }
    }

    public virtual void Show()
    {
        var uiElements = root.GetComponentsInChildren<UIBase>();
        foreach(var elementUi in uiElements)
        {
            elementUi.gameObject.SetActive(true);
            if (elementUi == this) break;
        }
    }

    public virtual void Hide()
    {
        var uiElements = root.GetComponentsInChildren<UIBase>();
        foreach (var elementUi in uiElements)
        {
            elementUi.gameObject.SetActive(false);
            if (elementUi == this) break;
        }
    }
}
