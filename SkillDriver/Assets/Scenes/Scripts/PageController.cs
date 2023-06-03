using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PageController : MonoBehaviour
{

    // Start is called before the first frame update
    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }



    public static void GoTo(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
