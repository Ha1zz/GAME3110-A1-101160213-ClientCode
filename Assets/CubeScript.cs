using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
//using System.Runtime.Remoting.Messaging;
using UnityEngine;
using Debug = UnityEngine.Debug;

public class CubeScript : MonoBehaviour
{

    public string cubeid = "";
    public float speed = 4;
    NetworkMan network;

    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("Cube ID: " + cubeid);
        network = GameObject.Find("NetworkMan").GetComponent<NetworkMan>();
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Cube ID: " + cubeid);
        //Debug.Log("My Name: " + gameObject.name);
        if (gameObject.name == network.myCubeid)
        {
            if (Input.GetKey(KeyCode.W))
            {
                transform.Translate(Vector3.forward * Time.deltaTime * speed);
            }

            if (Input.GetKey(KeyCode.S))
            {
                transform.Translate(-Vector3.forward * Time.deltaTime * speed);
            }

            if (Input.GetKey(KeyCode.A))
            {
                transform.Translate(Vector3.left * Time.deltaTime * speed);
            }

            if (Input.GetKey(KeyCode.D))
            {
                transform.Translate(-Vector3.left * Time.deltaTime * speed);
            }
        }
    }

    public void SelfDestruct()
    {
        Destroy(this.gameObject);
    }
}
