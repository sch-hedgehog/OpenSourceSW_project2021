using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public GameObject OverText; // Game Clear 텍스트
    public GameObject OverText1;// Game Clear 텍스트
    public GameObject OverText2;// Game Clear 텍스트
    public GameObject OverText3;// Game Clear 텍스트
    public GameObject OverText4;// 패패 텍스트
    public GameObject block;    // 첫번째 맵의 벽
    public GameObject block1;   // 두번째 맵의 벽
    public GameObject Enemy;    // 첫번째 맵의 적 선언
    public GameObject Enemy1;   // 두번째 맵의 적 선언
    public GameObject Player;   // 플레이어 선언
    public GameObject item;     // 아이템 선언

    public GameObject clover;   // 힌트 클로버 18개 선언
    public GameObject clover1;
    public GameObject clover2;
    public GameObject clover3;
    public GameObject clover4;
    public GameObject clover5;
    public GameObject clover6;
    public GameObject clover7;
    public GameObject clover8;
    public GameObject clover9;
    public GameObject clover10;
    public GameObject clover11;
    public GameObject clover12;
    public GameObject clover13;
    public GameObject clover14;
    public GameObject clover15;
    public GameObject clover16;
    public GameObject clover17;

    public float movespeed = 5f; // 캐릭터가 움직이는 속도와 움직임 설정
    public Rigidbody2D maze; 
    Vector2 movement; 

    void Start()
    {
        //unity 창에서 힌트 클로버, 두번째 미로의 벽, 두번째 미로의 적, 게임 패패 및 게임 클리어 텍스트를 
        //비활성화 처리한 후 코딩을 진행하였습니다
    }
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal"); // 수평이동
        movement.y = Input.GetAxisRaw("Vertical");   // 수직이동
    }
    private void FixedUpdate()
    {
        maze.MovePosition(maze.position + movement * movespeed * Time.fixedDeltaTime); // 속도 설정
    }

    private void OnCollisionEnter2D(Collision2D other) // 충돌 시 기능
    {
        if (other.gameObject.tag == "End")          //검정색 end 벽과 충돌 시 게임클리어 텍스트 호출
        {
            OverText.SetActive(true);
            movespeed = 0;
        }
        else if (other.gameObject.tag == "End(1)")  //비밀문 밖의 투명벽과 충돌 시 게임클리어 텍스트 호출
        {
            OverText1.SetActive(true);
            movespeed = 0;
        }
        else if (other.gameObject.tag == "End(2)")  //비밀문 밖의 투명벽과 충돌 시 게임클리어 텍스트 호출
        {
            OverText2.SetActive(true);
            movespeed = 0;
        }
        else if (other.gameObject.tag == "End(3)")  //비밀문 밖의 투명벽과 충돌 시 게임클리어 텍스트 호출
        {
            OverText3.SetActive(true);
            movespeed = 0;
        }
        else if (other.gameObject.tag == "ff")     //특수 장치와 충돌 시 
        {
            block.SetActive(false); //첫번째 미로 벽 비활성화
            Enemy.SetActive(false); //첫번쨰 미로 적 비활성화
            item.SetActive(false);  //아이템 비활성화
            block1.SetActive(true); //두번째 미로 벽 활성화
            Enemy1.SetActive(true); //두번째 미로 적 활성화
        }

        else if (other.gameObject.tag == "over") // 적과 충돌 시
        {
            Destroy(this.gameObject);  //player가 사라짐
            OverText4.SetActive(true); //패패 텍스트 활성화
        }
        else if (other.gameObject.name == "item") //item이라고 이름 붙여진 오브젝트와 충돌 시
        {
            Destroy(other.gameObject); //아이템을 획득하였으니 아이템이 사라짐
            clover.SetActive(true); // 힌트 클로버 18개 활성화
            clover1.SetActive(true);
            clover2.SetActive(true);
            clover3.SetActive(true);
            clover4.SetActive(true);
            clover5.SetActive(true);
            clover6.SetActive(true);
            clover7.SetActive(true);
            clover8.SetActive(true);
            clover9.SetActive(true);
            clover10.SetActive(true);
            clover11.SetActive(true);
            clover12.SetActive(true);
            clover13.SetActive(true);
            clover14.SetActive(true);
            clover15.SetActive(true);
            clover16.SetActive(true);
            clover17.SetActive(true);

        }
        else if (other.gameObject.tag == "clover") // 힌트 클로버 18개와 충돌 시
        {
                Destroy(other.gameObject); //힌트 클로버가 사라짐
        }
        else if (other.gameObject.tag == "clover1")
        {
            Destroy(other.gameObject);     //힌트 클로버가 사라짐
        }
        else if (other.gameObject.tag == "clover2")
        {
            Destroy(other.gameObject);     //힌트 클로버가 사라짐
        }
        else if (other.gameObject.tag == "clover3")
        {
            Destroy(other.gameObject);     //힌트 클로버가 사라짐
        }
        else if (other.gameObject.tag == "clover4")
        {
            Destroy(other.gameObject);     //힌트 클로버가 사라짐
        }
        else if (other.gameObject.tag == "clover5")
        {
            Destroy(other.gameObject);     //힌트 클로버가 사라짐
        }
        else if (other.gameObject.tag == "clover6")
        {
            Destroy(other.gameObject);     //힌트 클로버가 사라짐
        }
        else if (other.gameObject.tag == "clover7")
        {
            Destroy(other.gameObject);     //힌트 클로버가 사라짐
        }
        else if (other.gameObject.tag == "clover8")
        {
            Destroy(other.gameObject);     //힌트 클로버가 사라짐
        }
        else if (other.gameObject.tag == "clover9")
        {
            Destroy(other.gameObject);     //힌트 클로버가 사라짐
        }
        else if (other.gameObject.tag == "clover10")
        {
            Destroy(other.gameObject);     //힌트 클로버가 사라짐
        }
        else if (other.gameObject.tag == "clover11")
        {
            Destroy(other.gameObject);     //힌트 클로버가 사라짐
        }
        else if (other.gameObject.tag == "clover12")
        {
            Destroy(other.gameObject);     //힌트 클로버가 사라짐
        }
        else if (other.gameObject.tag == "clover13")
        {
            Destroy(other.gameObject);     //힌트 클로버가 사라짐
        }
        else if (other.gameObject.tag == "clover14")
        {
            Destroy(other.gameObject);     //힌트 클로버가 사라짐
        }
        else if (other.gameObject.tag == "clover15")
        {
            Destroy(other.gameObject);     //힌트 클로버가 사라짐
        }
        else if (other.gameObject.tag == "clover16")
        {
            Destroy(other.gameObject);     //힌트 클로버가 사라짐
        }
        else if (other.gameObject.tag == "clover17")
        {
            Destroy(other.gameObject);     //힌트 클로버가 사라짐
        }
    }
}