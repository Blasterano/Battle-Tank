using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankSelection : MonoBehaviour
{
    public TankSpawner tankSpawner;

    public void BlueTank()
    {
        tankSpawner.Createtank(TankTypes.Blue);
        gameObject.SetActive(false);
    }
    public void GreenTank()
    {
        tankSpawner.Createtank(TankTypes.Green);
        gameObject.SetActive(false);
    }
    public void RedTank()
    {
        tankSpawner.Createtank(TankTypes.Red);
        gameObject.SetActive(false);
    }
}
