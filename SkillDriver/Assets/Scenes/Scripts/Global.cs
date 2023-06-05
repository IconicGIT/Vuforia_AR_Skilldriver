using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Global : MonoBehaviour
{

    public static GameObject currentSkill;

    public static List<GameObject> skills;

    public List<GameObject> skillPresets;

    public static int currentLessonId;
    public static int currentUnitId;

    public static GameObject currentAR_Model;


    private void Awake()
    {
        GameObject copy = GameObject.Find("Global");
        if (copy != gameObject && copy != null)
        {
            //print("found Global");
            Destroy(gameObject);
        }

        DontDestroyOnLoad(this.gameObject);

        skills = new List<GameObject>();

        foreach (GameObject item in skillPresets)
        {
            skills.Add(item);

        }




        if (skills.Count > 0)
        {
            currentSkill = skills[0];
        }
    }

    




   
}

public class Skill : MonoBehaviour
{
    [SerializeField]
    private string skillName;

    public string GetName()
    {
        return skillName;
    }

    public void SetName(string name)
    {
        skillName = name;
    }
}

