using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    [SerializeField] private GameObject obstacle;
    [SerializeField] private Camera camera;
    [SerializeField] private GameObject ball;

    Vector3 CPos = new Vector3(0, 0, -2);
    bool begin = true;
    // Start is called before the first frame update
    void Start()
    {
        obstacle.GetComponent<Rigidbody>().useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (begin)
        {
            StartCoroutine(WaitForStart(3f));
        }
        else
        {
            camera.transform.position = new Vector3(ball.transform.position.x, ball.transform.position.y, ball.transform.position.z) + CPos;
        }
    }

    public void EnableObstacle()
    {
        obstacle.GetComponent<Rigidbody>().useGravity = true;
    }

    IEnumerator WaitForStart(float sec)
    {
        yield return new WaitForSeconds(sec);
        begin = false;
    }

    public bool isStart()
    {
        return !begin;
    }
}
