using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class OpenLevels : MonoBehaviour {

    public void OpenL1() {
        SceneManager.LoadScene(1);
    }

    public void OpenL2()
    {
        SceneManager.LoadScene(2);
    }
}
