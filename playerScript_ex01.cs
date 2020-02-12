using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerScript_ex01 : MonoBehaviour
{
    private float MOE_finished;
    [SerializeField] GameObject finish_obj;
    [SerializeField] GameObject other_obj_1;
    [SerializeField] GameObject other_obj_2;


    // Start is called before the first frame update
    void Start()
    {
        MOE_finished = 0.05f;
    }

    bool isFinished()
    {
        if (Mathf.Abs(transform.position.x - finish_obj.transform.position.x) <= MOE_finished &&
                Mathf.Abs(transform.position.y - finish_obj.transform.position.y) <= MOE_finished)
            return true;
        return false;
    }

    void goToNextScene(string name)
    {
        if (name.Equals("ex01"))
            SceneManager.LoadScene("ex02");
        else if (name.Equals("ex02"))
            SceneManager.LoadScene("ex03");
        else
            Debug.Log("You have finished the game!\n");
    }

    // Update is called once per frame
    void Update()
    {
        if (isFinished() && other_obj_1.GetComponent<playerScript_ex01>().isFinished()
                 && other_obj_2.GetComponent<playerScript_ex01>().isFinished())
            goToNextScene(SceneManager.GetActiveScene().name);
    }
}
