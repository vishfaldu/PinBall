using UnityEngine;

public class test : MonoBehaviour
{
    public float hitForce = 1f;
    public float radius = 1f;
    public GameObject prefabBall;
    public Rigidbody rb;

    void Start()
    {
        prefabBall = Resources.Load("Ball") as GameObject;
        rb = prefabBall.GetComponent<Rigidbody>();
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            rb.AddExplosionForce(hitForce, transform.position, 1, 0f, ForceMode.Impulse);
            Debug.Log("You should bounce.");
        }
    }
}
