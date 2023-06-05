using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PageControllerCaller : MonoBehaviour
{
    public void GoTo(string sceneName)
    {
        PageController.GoTo(sceneName);
    }

    public void SetCurrentSkill(GameObject skill)
    {
        foreach (GameObject item in Global.skills)
        {
            if (item.name.CompareTo(skill.name) == 0)
            {
                Global.currentSkill = item;
                //print("current skill: " + Global.currentSkill.name);
            }
        }
    }
}
