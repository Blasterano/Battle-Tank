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
    
    public void Createtank(TankTypes tankType)
    {
        int tankId = (int)(tankType);
        TankModel tankModel=new TankModel(tankList[tankId].movementSpeed, tankList[tankId].rotationSpeed, tankList[tankId].tanktype, tankList[tankId].color);

        TankController tankController = new TankController(tankModel, tankView);
    }
}
