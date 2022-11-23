using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine;

public class Pistol : Weapon
{
    public override void Charge(List<Transform> shootPoints)
    {
        int shootPointIndex = Random.RandomRange(0, shootPoints.Count);

        Instantiate(Bullet, shootPoints[shootPointIndex].position, Quaternion.identity);
    }
}
