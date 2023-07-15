using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Kaisa : MonoBehaviour
{
    [SerializeField] float flapstrength;
    public Rigidbody2D mRigidBody;
    public LogicManager logic;
    public bool BoolsActive = true;

    // Start is called before the first frame update
    void Start()
    {
        //로직 받아서 실행할 수 있는 함수
        gameObject.name= "Bird";
        logic =GameObject.FindGameObjectWithTag("logic").GetComponent<LogicManager>();
    }

    // Update is called once per frame
    void Update()
    {
        // 스페이스바로 이동하는 함수
        if(Input.GetKeyDown(KeyCode.Space))
        {
            mRigidBody.velocity = Vector2.up*6;
        }
        
    }
    //파이프 터치하면 게임오버 함수
    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        BoolsActive=false;
    }
    
    //화면 밖으로 나가면 게임오버 함수
    private void OnBecameInvisible()
    {
        logic.gameOver();
        BoolsActive=false;
    }

}
