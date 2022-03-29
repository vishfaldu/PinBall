using UnityEngine;

public class Bouncer : MonoBehaviour
{
    public float hitForce = 1f;
    public float radius = 1f;
    public Rigidbody[] rb;
    //public Rigidbody rb;
    public GameObject[] Bouncers;


    void Start()
    {
        //rb = GetComponent<Rigidbody>();
       
        Bouncers = GameObject.FindGameObjectsWithTag("Bounce");
        rb = new Rigidbody[Bouncers.Length];

        for(int i = 0; i < Bouncers.Length; i++)
        {
            rb[i] = Bouncers[i].GetComponent<Rigidbody>();
            //Debug.Log(rb[i]);
        }
    }
    
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger?");
        for (int i = 0; i < Bouncers.Length; i++)
        {
            if (other.gameObject.tag == "Bounce")
            {
                rb[i].GetComponent<Rigidbody>().AddExplosionForce(hitForce, transform.position, 1, 0f, ForceMode.Impulse);
                //rb.AddExplosionForce(hitForce, transform.position, 1, 0f, ForceMode.Impulse);
                Debug.Log("You should bounce.");
                //Debug.Log(rb[i]);
            }
        }
    }
}
