using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour
{
    [SerializeField] private Transform pfBullet;
   /* void Start()
    {
        GetComponent<GrowingPlatForm>().OnShoot += PlayerShootProjectiles_OnShoot;
    }

     private void PlayerShootProjectiles_OnShoot(object sender, GrowingPlatForm.OnShootEventArgs e)
    {
        //shoot
        Instantiate(pfBullet, e.gunEndPointPosition, Quaternion.identity);
    }*/
}
