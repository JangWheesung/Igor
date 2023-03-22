using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTurret : MonoBehaviour
{
    public double angle;
    public Vector3 distance_x;
    public Vector3 distance_y;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 player_pos = GameObject.FindWithTag("PlayerTurret").transform.position; // 플레이어 위치 가져옴
        distance_x = transform.position - new Vector3(player_pos.x, 0, 0); // 플레이어와 적(이 스크립트)의 x의 거리계산
        distance_y = transform.position - new Vector3(0, player_pos.y, 0);
        double distance_z = Math.Sqrt(Math.Pow(distance_x.x, 2) + Math.Pow(distance_y.y, 2)); // a ^ 2 + b ^ 2 = c ^ 2
        angle = (distance_x.x * 0.3f - (distance_y.y * 2f)) / 2; // 두 오브젝트의 변위에 높이를 적절히 조절, 알아서 값 조절하세요
        transform.rotation = Quaternion.Euler(0, 0, -(float)angle);//왼쪽으로 쏠 시 -angle로
    }
}
