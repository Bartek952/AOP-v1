using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class this2newscene : MonoBehaviour
{
    public float logoAnimationTime = 10f;
    private float timer = 0f;
    public string NewSceneName = "mainMenu";
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer >= 10)
        {
            SceneManager.LoadScene(NewSceneName);
        }
    }
}
