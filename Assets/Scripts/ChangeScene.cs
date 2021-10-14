using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{

    public void SceneChange1()
    {
        SceneManager.LoadScene("Stage1");
    }

    public void SceneChange2()
    {
        SceneManager.LoadScene("Stage2");
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
