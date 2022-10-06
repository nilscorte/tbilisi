using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bumper : MonoBehaviour
    {
    public GameObject Tracker1;
    public GameObject Tracker2;
    public bool isBumper1;
    public float speed = 5f;
    // Start is called before the first frame update
    void Start()
        {
        
        }

    // Update is called once per frame
    void Update()
        {
        if (isBumper1)
            {
            // transform.Translate(0f, Input.GetAxis("Vertical") * speed * Time.deltaTime, 0f);
            this.transform.position = new Vector3(this.transform.position.x, (Tracker1.transform.position.z-1.5f)*5, this.transform.position.z);
            }
        else
            {
            // transform.Translate(0f, Input.GetAxis("Vertical2") * speed * Time.deltaTime, 0f);
            this.transform.position = new Vector3(this.transform.position.x, (Tracker2.transform.position.z - 1.5f) * 5, this.transform.position.z);

            }
        }
    }
