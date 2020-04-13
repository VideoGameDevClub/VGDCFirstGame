using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    public float bulletForce = 20f;

    public int maxAmmo = 20;
    public int currAmmo;

    public ammoBar ammoBar;

    public float refillTime = 1.0f;
    public float refillCounter;

    private void Start()
    {
        refillCounter = refillTime;
        ammoBar.setMaxAmmo(maxAmmo);
        currAmmo = maxAmmo;
    }

    // Update is called once per frame
    void Update()
    {
        ammoBar.setAmmo(currAmmo);

        if (Input.GetButtonDown("Fire1") && currAmmo > 0)
        {
            Shoot();
        }

        //refill ammo
        if (refillCounter <= refillTime && refillCounter > 0)
        {
            refillCounter -= Time.deltaTime;
        }
        else if(refillCounter <= 0)
        {
            refillCounter = refillTime;
            if(currAmmo < maxAmmo)
                currAmmo++;
        }

    }

    void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);

        currAmmo--;
        ammoBar.setAmmo(currAmmo);
    }
}
