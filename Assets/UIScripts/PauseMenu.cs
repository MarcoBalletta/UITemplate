using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : UIBase
{
    public override void Show()
    {
        base.Show();
        Time.timeScale = 0;
    }

    public override void Hide()
    {
        base.Hide();
        Time.timeScale = 1;
    }
}
