using UnityEngine;
using UnityEngine.UI;

public class Ball : MonoBehaviour
{
    public Button btn;
    public GameObject ball;
    Camera cam;

    void Start()
    {

    }

    void Update()
    {
        btn.transform.Translate(Vector3.up);
        //Debug.Log(ball.transform.position);
        Debug.Log(btn.transform.position);
    }
}
