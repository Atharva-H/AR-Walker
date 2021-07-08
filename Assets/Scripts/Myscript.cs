using UnityEngine;
using UnityEngine.EventSystems;

public class Myscript : MonoBehaviour
{

    protected Joystick joystick;
    private Rigidbody rb;
    private Animation anim;



    // Start is called before the first frame update
    void Start()
    {
        joystick = FindObjectOfType<Joystick>();
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animation>();

    }

    // Update is called once per frame
    void Update()
    {
        float x = joystick.Horizontal;
        float z = joystick.Vertical;


         Vector3 movement = new Vector3(x, 0, z);
         rb.velocity = movement;

        if (x != 0 && z != 0)
        {
            transform.eulerAngles = new Vector3(transform.eulerAngles.x, Mathf.Atan2(x, z) * Mathf.Rad2Deg, transform.eulerAngles.z); 
        }



        if (x != 0 || z != 0)
        {
            anim.Play("walk");
        }
        else
        {
            anim.Play("idle");
        }

        

    }
}
