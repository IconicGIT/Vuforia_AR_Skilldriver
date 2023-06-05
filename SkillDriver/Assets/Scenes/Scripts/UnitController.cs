using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitController : MonoBehaviour
{
    [SerializeField]
    GameObject currentUnit;

    [SerializeField]
    Transform canvas;

    [SerializeField]
    GameObject navegationButtons;


    [SerializeField]
    List<GameObject> units;


    private void Awake()
    {
        if (units.Count > 0)
        {
            if (Global.currentUnitId > units.Count - 1) Global.currentUnitId = units.Count - 1;
            currentUnit = units[Global.currentUnitId];
        }
        UpdatePage();

        GameObject buttons = Instantiate(navegationButtons);
        buttons.transform.SetParent(canvas);

    }

    private void Update()
    {
        if (currentUnit == units[0])
        {
            gameObject.SetActive(false);
        }
        else if (!gameObject.activeSelf)
        {
            gameObject.SetActive(true);
        }
    }

    public void GoToNextUnit()
    {
        if (units.Count > 0 && currentUnit != units[units.Count - 1])
        {
            int index = units.FindIndex(go => go == currentUnit);
            currentUnit = units[index + 1];
            UpdatePage();
        }
        else
        {
            //finished
            print("Lesson finished!");
        }
    }

    public void GoToPreviousUnit()
    {
        if (units.Count > 0 && currentUnit != units[0])
        {
            int index = units.FindIndex(go => go == currentUnit);
            currentUnit = units[index - 1];
            UpdatePage();
        }
    }

    void UpdatePage()
    {
        foreach (GameObject unit in units)
        {
            if (unit != currentUnit && unit.activeSelf) unit.SetActive(false);
            if (unit == currentUnit && !unit.activeSelf) unit.SetActive(true);
        }
    }
    
}
