using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Global : MonoBehaviour
{

    [SerializeField]
    public static Skill currentSkill;

    [SerializeField]
    public static List<Skill> skills;

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);

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
}

