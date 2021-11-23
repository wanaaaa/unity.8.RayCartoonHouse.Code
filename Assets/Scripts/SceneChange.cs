using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    void SceneOne()
    {
        Debug.Log(77777777);
        SceneManager.LoadScene("WanCartoonHouse");
    }
}
