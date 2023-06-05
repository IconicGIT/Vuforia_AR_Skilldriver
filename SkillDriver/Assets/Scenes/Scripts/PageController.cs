using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PageController : MonoBehaviour
{

    // Start is called before the first frame update
    private void Awake()
    {
        GameObject copy = GameObject.Find("PageController");
        if (copy != gameObject && copy != null)
        {
            //print("found PageController");
            Destroy(gameObject);
        }

        DontDestroyOnLoad(this.gameObject);
    }



    public static void GoTo(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
