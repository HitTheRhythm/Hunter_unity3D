using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class WeaponController : MonoBehaviour
{
    public GameObject bulletPre;
    public Transform bulletPos;
    private float timer;

    public Transform bulletPoint;
    public Slider hp;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetButton("Fire1")&&(Time.time-timer>0.1f))
        {   
            GameObject go = Instantiate(bulletPre, bulletPos.position, bulletPos.rotation);
            Rigidbody rd = go.GetComponent<Rigidbody>();
            timer = Time.time;
            go.transform.SetParent(bulletPoint);
            Destroy(go, 2);
            go.name = "Bullet";
           // rd.velocity = new Vector3(-1, 0, 0) * 10;

        }

        if (hp.value<=0)
        {
            GameManager.Instance.overPanel.SetActive(true);
            Destroy(gameObject);
            Time.timeScale = 0;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            hp.value -= 0.1f;
        }
    }
}
