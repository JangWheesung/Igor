using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CameraMove : MonoBehaviour
{
    public bool InputView;
    private bool far = false;
    public Sign sign;
    public GameObject Tank;
    public Camera cam;
    // Start is called before the first frame update
    void Start()
    {
        Screen.SetResolution(1920, 1080, true);
    }

    void Update()
    {
        if (far == false)
        {
            transform.position = new Vector3(Tank.transform.position.x, Tank.transform.position.y + 10, -10);
        }
        if (far == true)
        {
            transform.position = new Vector3(Tank.transform.position.x + 60, Tank.transform.position.y + 18, -10);
        }
        if (InputView == true && cam.orthographicSize <= 15)
        {
            InputView = false;
            far = true;
            transform.position = new Vector3(Tank.transform.position.x + 60, Tank.transform.position.y + 18, -10);
            cam.DOOrthoSize(40, 02f).SetEase(Ease.OutExpo);
            InputView = false;
        }
        if (InputView == true && cam.orthographicSize >= 40)
        {
            InputView = false;
            far = false;
            transform.position = new Vector3(Tank.transform.position.x, Tank.transform.position.y + 10, -10);
            cam.DOOrthoSize(15, 02f).SetEase(Ease.OutExpo);
            InputView = false;
        }

        if (sign.clear == true)
        {
            far = false;
            transform.position = new Vector3(Tank.transform.position.x, Tank.transform.position.y + 10, -10);
            new WaitForSeconds(0.15f);
            cam.DOOrthoSize(15, 02f).SetEase(Ease.OutExpo);
        }
        InputView = false;
    }
}
