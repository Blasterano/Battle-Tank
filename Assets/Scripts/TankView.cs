using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankView : MonoBehaviour
{
    private TankController tankController;

    private float movement;
    private float rotation;

    public Rigidbody rb;
    public MeshRenderer[] childs;

    // Start is called before the first frame update
    void Start()
    {
        GameObject cam = GameObject.Find("Main Camera");
        cam.transform.SetParent(transform);
        cam.transform.position = new Vector3(0, 3.0f, -4.0f);
    }

    // Update is called once per frame
    void Update()
    {
        Movement();

        tankController.Move(movement, tankController.GetTankModel().movementSpeed);
        tankController.Rotation(rotation, tankController.GetTankModel().rotationSpeed);
    }
    public void SetTankController(TankController _tankController)
    {
        tankController = _tankController;
    }

    private void Movement()
    {
        movement = Input.GetAxis("Vertical");
        rotation = Input.GetAxis("Horizontal");
    }

    public Rigidbody GetRigidbody()
    {
        return rb;
    }

    public void ChangeColor(Material color)
    {
        foreach(MeshRenderer child in childs)
        { 
            child.material = color;
        }
    }
}
