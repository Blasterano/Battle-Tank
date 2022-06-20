using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankSpawner : MonoBehaviour
{
    public TankView tankView;

    // Start is called before the first frame update
    void Start()
    {
        Createtank();
    }

    private void Createtank()
    {
        TankModel tankModel=new TankModel(30,20);

        TankController tankController = new TankController(tankModel, tankView);
    }
}
