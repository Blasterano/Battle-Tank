using UnityEngine;

public class TankModel : MonoBehaviour
{
    private TankController tankController;

    public Material color;

    public float movementSpeed;
    public float rotationSpeed;

    public TankTypes tankTypes;

    public TankModel(float _movement, float _rotation, TankTypes tank, Material _color)
    {
        movementSpeed = _movement;
        rotationSpeed = _rotation;
        tankTypes = tank;
        color = _color;
    }

    public void SetTankController(TankController _tankController)
    {
        tankController = _tankController;
    }
}
