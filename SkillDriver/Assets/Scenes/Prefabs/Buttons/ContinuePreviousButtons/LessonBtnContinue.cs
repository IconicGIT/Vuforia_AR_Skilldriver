using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class LessonBtnContinue : MonoBehaviour
{

    Button button;

    [SerializeField]
    UnitController unitController;


    private void Awake()
    {
        unitController = GameObject.Find("UnitController").GetComponent<UnitController>();

        button = GetComponent<Button>();

        button.onClick.AddListener(unitController.GoToNextUnit);
    }

}
