using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitController : MonoBehaviour
{
    [SerializeField]
    GameObject currentUnit;
    
    [SerializeField]
    List<GameObject> units;


    private void Awake()
    {
        if (units.Count > 0)
        {
            currentUnit = units[0];
        }
        UpdatePage();
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

    void UpdatePage()
    {
        foreach (GameObject unit in units)
        {
            if (unit != currentUnit && unit.activeSelf) unit.SetActive(false);
            if (unit == currentUnit && !unit.activeSelf) unit.SetActive(true);
        }
    }
    
}
