using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StageUnlock : MonoBehaviour
{
    public SpriteRenderer TwoStageImage;
    public SpriteRenderer ThreeStageImage;
    public SpriteRenderer FourStageImage;
    public Image TwoStageBlind;
    public Image ThreeStageBlind;
    public Image FourStageBlind;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Color color4 = FourStageImage.color;
        FourStageImage.color = color4;
        color4.r = 100;
        color4.b = 100;
        color4.g = 100;
        Color color3 = ThreeStageImage.color;
        ThreeStageImage.color = color3;
        color3.r = 100;
        color3.b = 100;
        color3.g = 100;
        Color color2 = TwoStageImage.color;
        TwoStageImage.color = color2;
        color2.r = 100;
        color2.b = 100;
        color2.g = 100;
        if (PlayerPrefs.GetInt("2", 0) == 1)
        {
            color2.r = 255;
            color2.b = 255;
            color2.g = 255;
            TwoStageImage.color = color2;
            TwoStageBlind.enabled = false;
        }
        if (PlayerPrefs.GetInt("3", 0) == 1)
        {
            color3.r = 255;
            color3.b = 255;
            color3.g = 255;
            ThreeStageImage.color = color3;
            ThreeStageBlind.enabled = false;
        }
        if (PlayerPrefs.GetInt("4", 0) == 1)
        {
            color4.r = 255;
            color4.b = 255;
            color4.g = 255;
            FourStageImage.color = color4;
            FourStageBlind.enabled = false;
        }
    }
}
