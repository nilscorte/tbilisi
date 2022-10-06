using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Ball : MonoBehaviour
    {
    public float speed = 5f;

    public TMP_Text score;
    private int scorePlayerOne = 0;
    private int scorePlayerTwo = 0;

    // Start is called before the first frame update
    void Start()
        {
        float sx = Random.Range(0, 2) == 0 ? -1 : 1;
        float sy = Random.Range(0, 2) == 0 ? -1 : 1;

        GetComponent<Rigidbody>().velocity = new Vector3(speed * sx, speed * sy, 0f);
        }

    // Update is called once per frame
    void Update()
        {
        if (this.transform.position.x < -9)
            {
            this.transform.position = new Vector3(0,0,0);
            scorePlayerOne++;
            score.text = scorePlayerOne + ":" + scorePlayerTwo;
            }
        else if (this.transform.position.x > 9)
            {
            this.transform.position = new Vector3(0, 0, 0);
            scorePlayerTwo++;
            score.text = scorePlayerOne + ":" + scorePlayerTwo;
            }
        }
    }
