using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class GameManager : MonoBehaviour
{
    public Sign sign;
    public Image image;
    public PlayerMove playerMove;
    public PlayerHP playerHP;
    public Fire fire;
    public Turret turret;
    public GunFire gunFire;
    public BackGroundMove backGroundMove;
    public CameraMove cameraMove;
    public GameObject MenuImage;
    public GameObject BigGunIcon;
    public GameObject SmallGunIcon;
    public SpriteRenderer BigGunSprite;
    public SpriteRenderer SmallGunSprite;
    public bool InputGun;
    public bool BigGun = true;
    public bool IconMove = false;
    //
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        GunScript();
    }

    // Update is called once per frame
    void Update()
    {
        MainGunChange();
        GameOver();
        Menujjajan();
    }
    private void Menujjajan()
    {
        if (MenuImage.activeSelf == true)
        {
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;
        }
    }
    void GameOver()
    {
        if (playerHP.HP <= 0 || sign.clear == true)
        {
            fire.enabled = false;
            turret.enabled = false;
            gunFire.enabled = false;
            playerMove.enabled = false;
            playerHP.enabled = false;
            backGroundMove.enabled = false;
            cameraMove.enabled = false;

            if (Input.GetKeyDown(KeyCode.E))
            {
                image.gameObject.SetActive(true);
                StartCoroutine(Black());
            }
        }
    }
    void MainGunChange()
    {
        if (InputGun == true && IconMove == false)
        {
            InputGun = false;
            switch (BigGun)
            {
                case true:
                    BigGun = false;
                    break;
                case false:
                    BigGun = true;
                    break;
            }
            GunScript();
        }
    }
    void GunScript()
    {
        Sequence mySequence = DOTween.Sequence();
        if (BigGun == true)
        {
            IconMove = true;
            BigGunSprite.sortingOrder = 2;
            SmallGunSprite.sortingOrder = 1;
            mySequence.Append(BigGunIcon.transform.DOLocalMove(new Vector2(302, 85), 1).SetEase(Ease.OutExpo)).Join(SmallGunIcon.transform.DOLocalMove(new Vector2(313, 97), 1).SetEase(Ease.OutExpo))
            .OnComplete(() =>
            {

                IconMove = false;
                InputGun = false;

            });
            fire.InputFire = false;
            gunFire.InputFire = false;
            gunFire.enabled = false;
            fire.enabled = true;
            turret.enabled = true;
        }
        else if (BigGun == false)
        {
            IconMove = true;
            BigGunSprite.sortingOrder = 1;
            SmallGunSprite.sortingOrder = 2;
            mySequence.Append(BigGunIcon.transform.DOLocalMove(new Vector2(313, 97), 1).SetEase(Ease.OutExpo)).Join(SmallGunIcon.transform.DOLocalMove(new Vector2(302, 85), 1).SetEase(Ease.OutExpo))
            .OnComplete(() =>
            {

                IconMove = false;
                InputGun = false;

            });
            fire.InputFire = false;
            gunFire.InputFire = false;
            gunFire.enabled = true;
            fire.enabled = false;
            turret.enabled = false;
        }
    }
    IEnumerator Black()
    {
        Color color = image.color;
        image.color = color;
        for (int i = 0; image.color.a < 1; i++)
        {
            color.a += 0.01f;
            image.color = color;
            yield return new WaitForSeconds(0.01f);
        }
        SceneManager.LoadScene("Stage");
    }
}
