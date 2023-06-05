using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class LessonButton : MonoBehaviour
{
    Button button;

    public int lessonId;
    public string nextScene;
    [SerializeField]
    GameObject lessonGO;

    [SerializeField]
    LessonData lessonData;

    private void Awake()
    {
        button = GetComponent<Button>();

        button.onClick.AddListener(() => GoToLesson(lessonId));
    }

    private void Start()
    {
        lessonGO = Global.currentSkill.GetComponent<LessonHolder>().lessons[lessonId].gameObject;

        lessonData = lessonGO.GetComponent<LessonData>();

        transform.Find("Text (TMP)").gameObject.GetComponent<TextMeshProUGUI>().text = lessonData.ButtonTitle;
    }

    private void GoToLesson(int index)
    {
        Global.currentLessonId = index;
        Global.currentUnitId = 0;
        SceneManager.LoadScene(nextScene);
    }
}
