using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerContoller : MonoBehaviour
{
    [SerializeField] public GameObject inventory;
    private Rigidbody2D rigidbody;
    private Vector2 direction;
    public float speedMove;
    private Vector2 changeDirection;

    private void Awake()
    {
        
        rigidbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        //inventory = GameObject.FindGameObjectWithTag("Inventory");
        direction.x = Input.GetAxis("Horizontal") * speedMove;
        direction.y = Input.GetAxis("Vertical") * speedMove;
        rigidbody.position +=direction * speedMove * Time.deltaTime;
        if (direction.x > 0)
        {
            changeDirection.x = 0.5f;
            changeDirection.y = 0.5f;
            transform.localScale = changeDirection;
        }
        if (direction.x<0)
        {
            changeDirection.x=-0.5f;
            changeDirection.y = 0.5f;
            transform.localScale = changeDirection;
        }
        if (Input.GetKey(KeyCode.F))
        {
            // Атакует врага
        }
        if (Input.GetKeyDown(KeyCode.I))
        {
            OpenCloseInv();
            
        }
    }
    private void OpenCloseInv() 
    {
        if (inventory.activeSelf == true)
        {
            inventory.SetActive(false);
        }
        else inventory.SetActive(true);
    }
}
