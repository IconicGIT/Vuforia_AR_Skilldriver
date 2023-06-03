using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PageControllerCaller : MonoBehaviour
{
    public void GoTo(string sceneName)
    {
        PageController.GoTo(sceneName);
    }

    public void SetCurrentSkill(int skillNumber)
    {
        if (skillNumber > 0 && skillNumber < Global.skills.Count)
            Global.currentSkill = Global.skills[skillNumber];
        

    }
}
