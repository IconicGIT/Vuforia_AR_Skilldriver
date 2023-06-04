using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LessonController : MonoBehaviour
{
    [SerializeField]
    GameObject canvas;

    GameObject lessonGo;
    private void Awake()
    {
        LessonHolder lessonList = Global.currentSkill.gameObject.GetComponent<LessonHolder>();
        for (int i = 0; i < lessonList.lessons.Count; i++)
        {
            if (i == Global.currentLessonId)
            {

                print("do");
                lessonGo = Instantiate(lessonList.lessons[Global.currentLessonId]);

                lessonGo.transform.parent = canvas.transform;
            }
        }
    }

    private void Start()
    {
        lessonGo.transform.position = Vector3.zero;
    }
}
