using UnityEngine;

public class Spring : MonoBehaviour
{
    SpringJoint spring = new SpringJoint();
    public Rigidbody rb;

    [SerializeField]
    float springStrength = 100f;
    [SerializeField]
    float power = 10f;

    float timePressed;
    bool isReady;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        //spring = GetComponent<SpringJoint>();
        //spring.spring = springStrength;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            Debug.Log("HIT");
            isReady = true;
        }
    }

    private void Update()
    {
        if (isReady)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                timePressed = Time.time;
                Debug.Log("pressed");
                SpringCompressed();
            }
            else if (Input.GetKeyUp(KeyCode.Space))
            {
                timePressed = Time.time - timePressed;
                Debug.Log("released");
                Debug.Log(timePressed);
                SpringReleased();
            }
        }
    }


    void SpringCompressed()
    {
        //springStrength += timePressed * power;
        springStrength += Time.deltaTime * power;
    }

    void SpringReleased()
    {
        rb.AddForce(Vector3.back * springStrength);
    }
}