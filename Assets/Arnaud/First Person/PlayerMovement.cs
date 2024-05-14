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
    public LayerMask Place1Mask;
    public LayerMask Encaissement;
    public LayerMask Carton;

    public GameObject icamera;
    public float rangePickUp;

    public GameObject Shop;
    public GameObject cameraUI;
    public GameObject Pc;
    public GameObject ObjetInHand;


    public bool itempickup = false;
    public bool itemPickuped = false;
    public bool itemDroped = false;

    public bool cartonpickup = false;
    public bool cartonPickuped = false;
    public bool cartonDroped = false;

    public bool UIOn = false;

    public float pushPower = 2.0F;

    private float forceMagnitude;

    public GameObject Caisse;

    
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
        Debug.DrawRay(icamera.transform.position, icamera.transform.TransformDirection(Vector3.forward) * rangePickUp, Color.red);



        if (Physics.Raycast(icamera.transform.position, icamera.transform.TransformDirection(Vector3.forward), out hit, rangePickUp, InteractibleMask))
        {
            if(Input.GetMouseButtonDown(0))
            {
                Cursor.lockState = CursorLockMode.None;
                cameraUI.SetActive(true);
                Shop.SetActive(true);
                Pc.SetActive(true);
                UIOn = true;
            }
        }
        
        if(Input.GetKeyDown(KeyCode.Escape) && UIOn == true)
        {
            Shop.SetActive(false);
            cameraUI.SetActive(false);
            Pc.SetActive(false);
            UIOn = false;

            Cursor.lockState = CursorLockMode.Locked;
        }
        
       
        
        if (Physics.Raycast(icamera.transform.position, icamera.transform.TransformDirection(Vector3.forward), out hit, rangePickUp, ItemMask))
        {
            if (Input.GetMouseButtonDown(0))
            {
                if(itempickup == false)
                {
                    hit.transform.GetComponent<ItemPickup>().PickUp();
                    ObjetInHand = hit.transform.gameObject;
                    itemPickuped = true;
                }
                
                if(itempickup == true)
                {
                    hit.transform.GetComponent<ItemPickup>().Drop();
                    ObjetInHand = null;
                    itemDroped = true;
                }

                if(itemPickuped == true)
                {
                    itempickup = true;
                    itemPickuped = false;
                }

                if(itemDroped == true)
                {
                    itempickup = false;
                    itemDroped = false;
                }
            }
        }

        if (Physics.Raycast(icamera.transform.position, icamera.transform.TransformDirection(Vector3.forward), out hit, rangePickUp, Carton))
        {
            
            if (Input.GetMouseButtonDown(0))
            {
                
                if(cartonpickup == false)
                {
                    hit.transform.GetComponent<ItemPickup>().PickUp();
                    ObjetInHand = hit.transform.gameObject;
                    cartonPickuped = true;
                }
                
                if(cartonpickup == true)
                {
                    hit.transform.GetComponent<ItemPickup>().Drop();
                    ObjetInHand = null;
                    cartonDroped = true;
                }

                if(cartonPickuped == true)
                {
                    cartonpickup = true;
                    cartonPickuped = false;
                }

                if(cartonDroped == true)
                {
                    cartonpickup = false;
                    cartonDroped = false;
                }
            }
        }

        

        if (Physics.Raycast(icamera.transform.position, icamera.transform.TransformDirection(Vector3.forward), out hit, rangePickUp, Place1Mask))
        {
            if(Input.GetKeyDown(KeyCode.E))
            {
                if(itempickup == false)
                {    
                    hit.transform.GetComponent<Armoire>().take();
                    itemPickuped = true;
                }

                if(itempickup == true)
                {
                    hit.transform.GetComponent<Armoire>().place();
                    ObjetInHand = null;
                    itemDroped = true;
                }

                if(itemPickuped == true)
                {
                    itempickup = true;
                    itemPickuped = false;
                }

                if(itemDroped == true)
                {
                    itempickup = false;
                    itemDroped = false;
                }
                
            }

            if (Physics.Raycast(icamera.transform.position, icamera.transform.TransformDirection(Vector3.forward), out hit, rangePickUp, ItemMask) )
            {
                ObjetInHand = hit.transform.gameObject;
            }
        }

        if (Physics.Raycast(icamera.transform.position, icamera.transform.TransformDirection(Vector3.forward), out hit, rangePickUp, Encaissement))
        {
            if (Input.GetMouseButtonDown(0))
            {
                Caisse.GetComponent<Caisse>().Encaissement();
            }
           
        }

        if (Physics.Raycast(icamera.transform.position, icamera.transform.TransformDirection(Vector3.forward), out hit, rangePickUp, Carton))
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                hit.transform.GetComponent<Carton>().Ouverture();
                ObjetInHand = null;
                cartonDroped = true;

                if(cartonDroped == true)
                {
                    cartonpickup = false;
                    cartonDroped = false;
                }
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
