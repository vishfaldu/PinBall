using UnityEngine;

public class LoadBall : MonoBehaviour
{
    GameObject pinball;
    private void Start()
    {
        pinball = Resources.Load("Ball") as GameObject;
        pinball = Instantiate(pinball, new Vector3(-1.25f, -0.1f, -1), Quaternion.identity);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            Debug.Log("You should destroy.");
            Destroy(pinball);

            pinball = Instantiate(pinball, new Vector3(-1.25f, -0.1f, -1), Quaternion.identity);
        }
    }
}
