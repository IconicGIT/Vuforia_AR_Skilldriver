using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LessonController : MonoBehaviour
{
    [SerializeField]
    GameObject canvas;

    [SerializeField]
    GameObject ARbutton;

    GameObject lessonGo;
    private void Awake()
    {
        LessonHolder lessonList = Global.currentSkill.gameObject.GetComponent<LessonHolder>();
        for (int i = 0; i < lessonList.lessons.Count; i++)
        {
            if (i == Global.currentLessonId)
            {

                lessonGo = Instantiate(lessonList.lessons[Global.currentLessonId]);

                lessonGo.transform.parent = canvas.transform;
                lessonGo.GetComponent<RectTransform>().localPosition = Vector3.zero;
            }
        }

        GameObject arButton = Instantiate(ARbutton);
        ARbutton.transform.position.Set(88, 127, 0);

    }

}
