using UnityEngine;

public class Pin : MonoBehaviour
{
    HingeJoint hinge;
    [SerializeField] float restPos = 0f;
    [SerializeField] float pressedPos = 70f;
    [SerializeField] float hitForce = 10000f;
    [SerializeField] float Damper = 150f;

    public string inputName;

    void Start()
    {
        hinge = GetComponent<HingeJoint>();
        hinge.useSpring = true;
    }

    void Update()
    {
        JointSpring spring = new JointSpring();
        spring.spring = hitForce;
        spring.damper = Damper;

        if (Input.GetAxis(inputName) == 1)
            spring.targetPosition = pressedPos;
        else
            spring.targetPosition = restPos;

        hinge.spring = spring;
        //hinge.useLimits = true;
        
    }
}
