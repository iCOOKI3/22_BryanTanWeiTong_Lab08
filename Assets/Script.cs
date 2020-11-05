using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Script : MonoBehaviour
{

    public GameObject scoreText;

    float spacebar;

    // Start is called before the first frame update
    void Start()
    {
        scoreText.GetComponent<Text>().text = "Start Function";
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            spacebar++;
            scoreText.GetComponent<Text>().text = "SpaceBar:" + spacebar;
            print("Spacebar is pressed");
        }
    }
}
