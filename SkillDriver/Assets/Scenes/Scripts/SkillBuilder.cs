using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class SkillBuilder : MonoBehaviour
{
    [SerializeField]
    GameObject canvas;

    [SerializeField]
    Transform LessonButtonsCanvas;

    [SerializeField]
    GameObject LessonButtonPreset;

    [SerializeField]
    string nextScene;

    GameObject skillGO;

    private void Awake()
    {

        for (int i = 0; i < Global.skills.Count; i++)
        {
            if (Global.currentSkill == Global.skills[i])
            {
                SpawnSkillInCanvas(i);
                //print("spawning skill: " + Global.skills[i].name + " index: " + i);
            }
        }

        LessonButtonsCanvas = skillGO.transform.Find("LessonButtons");

        LessonHolder lessonList = Global.currentSkill.gameObject.GetComponent<LessonHolder>();

        for (int i = 0; i < lessonList.lessons.Count; i++)
        {
            GameObject button = PrefabUtility.InstantiatePrefab(LessonButtonPreset) as GameObject;
            PrefabUtility.UnpackPrefabInstance(button, PrefabUnpackMode.Completely, InteractionMode.AutomatedAction);

            LessonButton buttonData = button.GetComponent<LessonButton>();

            buttonData.lessonId = i;
            buttonData.nextScene = nextScene;

            button.transform.SetParent(LessonButtonsCanvas);
        }
    }

    void SpawnSkillInCanvas(int skillIndex)
    {

        if (skillIndex > Global.skills.Count)
        {
            Debug.LogError("index out of bounds");
        }
        else
        {
            if (Global.skills[skillIndex] != null)
            {
                skillGO = PrefabUtility.InstantiatePrefab(Global.skills[skillIndex]) as GameObject;
                PrefabUtility.UnpackPrefabInstance(skillGO, PrefabUnpackMode.Completely, InteractionMode.AutomatedAction);
                //print("spawning skill 1: " + Global.skills[skillIndex].name + " index: " + skillIndex);

                skillGO.transform.parent = canvas.transform;
                skillGO.transform.position = Vector3.zero;
            }
            else
            {
                Debug.LogError("Missing skill at index" + skillIndex);
            }

        }

    }
    public void SetLessonId(int id)
    {
        Global.currentLessonId = id;
    }
   
}
