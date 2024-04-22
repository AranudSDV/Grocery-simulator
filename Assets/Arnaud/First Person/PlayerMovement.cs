using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //Movement
    public CharacterController controller;

    public float gravity = -9.81f;
    public float speed = 12f;
    public float jumpHeight = 3f;

    Vector3 velocity;

    public Transform groundCheck;
    public float groundDIstance = 0.4f;
    public LayerMask groundMask;
    bool isGrounded;

    public LayerMask InteractibleMask;
    public LayerMask ItemMask;

    public GameObject icamera;
    public float rangePickUp;

    public GameObject Shop;
    public GameObject cameraUI;
    public GameObject Pc;


    public bool itempickup = false;

    public float pushPower = 2.0F;

    [SerializeField]
    private float forceMagnitude;
    
    

    
    void Update()
    {

        isGrounded = Physics.CheckSphere(groundCheck.position, groundDIstance, groundMask);

        if(isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);

        velocity.y += gravity * Time.deltaTime;

        if(Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }


        controller.Move(velocity * Time.deltaTime);


        RaycastHit hit;


        if (Physics.Raycast(icamera.transform.position, icamera.transform.TransformDirection(Vector3.forward), out hit, rangePickUp, InteractibleMask))
        {
            if(Input.GetMouseButtonDown(0))
            {
                Cursor.lockState = CursorLockMode.None;
                cameraUI.SetActive(true);
                Shop.SetActive(true);
                Pc.SetActive(true);
            }
        }
        
         if(Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("EChappe UI");
            Shop.SetActive(false);
            cameraUI.SetActive(false);
            Pc.SetActive(false);

            Cursor.lockState = CursorLockMode.Locked;
        }
        
        if (Physics.Raycast(icamera.transform.position, icamera.transform.TransformDirection(Vector3.forward), out hit, rangePickUp, ItemMask) && Input.GetMouseButtonDown(0) && itempickup == true)
        {
            hit.transform.GetComponent<ItemPickup>().Drop();
            itempickup = false; 
            
        }
        
        if (Physics.Raycast(icamera.transform.position, icamera.transform.TransformDirection(Vector3.forward), out hit, rangePickUp, ItemMask) && itempickup == false)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                hit.transform.GetComponent<ItemPickup>().PickUp();
                itempickup = true;
                
            }

           
        }

        

       

        
        


    }

    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        Rigidbody body = hit.collider.attachedRigidbody;

        
        if (body == null || body.isKinematic)
            return;

        if (hit.moveDirection.y < -0.3f)
            return;

        
        Vector3 pushDir = new Vector3(hit.moveDirection.x, 0, hit.moveDirection.z);

        body.velocity = pushDir * pushPower;
    }
    
}
