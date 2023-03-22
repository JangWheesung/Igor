using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    private PlayerMove playerMove;
    private Turret turret;
    private Fire fire;
    private GunFire gunFire;
    private BackGroundMove backGroundMove;
    private CameraMove cameraMove;
    private GameManager gameManager;
    void Start()
    {
        playerMove = GameObject.FindWithTag("Player").GetComponent<PlayerMove>();
        turret = GameObject.FindWithTag("Player").transform.GetChild(2).GetComponent<Turret>();
        fire = GameObject.FindWithTag("Player").transform.GetChild(2).GetChild(0).GetChild(0).GetComponent<Fire>();
        gunFire = GameObject.FindWithTag("Player").transform.GetChild(3).GetComponent<GunFire>();
        backGroundMove = GameObject.Find("BackGround").GetComponent<BackGroundMove>();
        cameraMove = GameObject.FindWithTag("MainCamera").GetComponent<CameraMove>();
        gameManager = GameObject.FindWithTag("GameManager").GetComponent<GameManager>();
    }
    public void LeftDown()
    {
        backGroundMove.InputLeft = true;
        playerMove.InputLeft = true;
    }
    public void RightDown()
    {
        backGroundMove.InputRight = true;
        playerMove.InputRight = true;
    }
    public void LeftUp()
    {
        backGroundMove.InputLeft = false;
        playerMove.InputLeft = false;
    }
    public void RightUp()
    {
        backGroundMove.InputRight = false;
        playerMove.InputRight = false;
    }
    public void UpDwon()
    {
        turret.InputUp = true;
        gunFire.InputUp = true;
    }
    public void UpUp()
    {
        turret.InputUp = false;
        gunFire.InputUp = false;
    }
    public void DownDwon()
    {
        turret.InputDown = true;
        gunFire.InputDown = true;
    }
    public void DownUp()
    {
        turret.InputDown = false;
        gunFire.InputDown = false;
    }
    public void FireDown()
    {
        if(fire.reset > 10f)
            fire.InputFire = true;
    }
    public void FireUp()
    {
        fire.InputFire = false;
    }
    public void GunFireDown()
    {
        if (gunFire.reset > 10f)
            gunFire.InputFire = true;
    }
    public void GunFireUp()
    {
        gunFire.InputFire = false;
    }
    public void GunDown()
    {
        gameManager.InputGun = true;
    }
    public void ViewDown()
    {
        cameraMove.InputView = true;
    }
    public void ViewUp()
    {
        cameraMove.InputView = false;
    }
}
