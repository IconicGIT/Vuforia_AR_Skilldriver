using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AR_Page_Controller : MonoBehaviour
{
    [SerializeField]
    GameObject shownModel;

    [SerializeField]
    GameObject target;


    private void Awake()
    {
        shownModel = Instantiate(Global.currentAR_Model);
        shownModel.transform.SetParent(target.transform);
        shownModel.transform.position.Set(0, 1, 0);
        
    }

    public void GrowModel()
    {
        shownModel.transform.localScale += shownModel.transform.localScale * 0.1f;
    }

    public void ReduceModel()
    {
        shownModel.transform.localScale -= shownModel.transform.localScale * 0.1f;
    }
}
