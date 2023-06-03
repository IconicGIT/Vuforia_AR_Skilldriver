using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillBuilder : MonoBehaviour
{
    [SerializeField]
    GameObject canvas;
    [SerializeField]
    List<GameObject> skillPresets;

    
    private void Awake()
    {
        print("curret skill: " + Global.currentSkill);

        for (int i = 0; i < Global.skills.Count; i++)
        {
            if (Global.currentSkill == Global.skills[i])
            {
                SpawnSkillInCanvas(i);

            }
        }
    }

    void SpawnSkillInCanvas(int skillIndex)
    {

        if (skillIndex > skillPresets.Count)
        {
            Debug.LogError("index out of bounds");
        }
        else
        {
            if (skillPresets[skillIndex])
            {
                GameObject skill = Instantiate(skillPresets[skillIndex]);

                skill.transform.parent = canvas.transform;
                skill.transform.position = Vector3.zero;
            }
            else
            {
                Debug.LogError("Missing skill at index" + skillIndex);
            }
            
        }
        
    }
}
