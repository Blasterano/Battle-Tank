using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankSpawner : MonoBehaviour
{
    [System.Serializable]
    public class Tank
    {
        public float movementSpeed;
        public float rotationSpeed;

        public TankTypes tanktype;

        public Material color;

    }

    public List<Tank> tankList;

    public TankView tankView;

    // Start is called before the first frame update
    void Start()
    {
        Createtank();
    }

    private void Createtank()
    {
        TankModel tankModel=new TankModel(tankList[1].movementSpeed, tankList[1].rotationSpeed, tankList[1].tanktype, tankList[1].color);

        TankController tankController = new TankController(tankModel, tankView);
    }
}
