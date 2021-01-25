using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class AnimationController : MonoBehaviour
{

    Animator anim;
    Rigidbody playerRB;

    public GameObject projectile;
    public Transform projectileSpawnPos;
    private Vector3 targetPos;
    

    int jumpHash = Animator.StringToHash("Jump");
    int xHash = Animator.StringToHash("X");
    int yHash = Animator.StringToHash("Y");
    int randomHash = Animator.StringToHash("Random");

    int takeAim = Animator.StringToHash("TakeAim");
    int hold = Animator.StringToHash("Hold");
    int fire = Animator.StringToHash("Fire");
    int cancelAttack = Animator.StringToHash("CancelAttack");

    public int amountOfIdleAnimationss = 3;

    int counter = 0;
    float prevNr = 0;
    float currentNr = 0;
    float lerping;
    float timeElapsed = 0;
    float lerpDuration = 3f;

    bool isAttackStarted = false;
    bool isHolding = false;

    GameObject projectileRef;

    //int runHash = Animator.StringToHash("Jump");

    public void Start()
    {
        anim = transform.GetComponent<Animator>();
        playerRB = GameObject.Find("Player").GetComponent<Rigidbody>();
        //anim.SetLayerWeight(1, 0);
        anim.SetFloat(randomHash, 1);

        targetPos = GameObject.Find("CrossHair").GetComponent<RangedHitPoint>().missleTarget;
    }



    // Update is called once per frame
    void Update()
    {
        

        //if (timeElapsed < lerpDuration)
        //{
        //    prevNr = lerping;
        //    lerping = Mathf.Lerp(prevNr, currentNr, timeElapsed / lerpDuration);
        //    Debug.Log(lerping);
        //
        //    anim.SetFloat(randomHash, lerping);
        //    timeElapsed += Time.deltaTime;
        //}
        //else
        //{
        //    timeElapsed = 0;
        //}

        if (Input.GetMouseButtonDown(0))
        {
            anim.SetLayerWeight(1, 1);
            isAttackStarted = true;
            anim.SetTrigger(takeAim);
            //anim.SetTrigger(hold);

            projectileRef = Instantiate(projectile, projectileSpawnPos);
            projectileRef.GetComponent<Arrow>().parentTrans = projectileSpawnPos;
        }
        //else
        //{
        //    anim.SetTrigger(cancelAttack);
        //}
        if (isAttackStarted)
        {
            anim.SetLayerWeight(1, 1);
            if (Input.GetMouseButton(0))
            {
                //anim.ResetTrigger(takeAim);
                anim.SetTrigger(hold);
                isHolding = true;
                
            }
            if (Input.GetMouseButton(3))
            {
                anim.SetTrigger(cancelAttack);
                isHolding = false;
                isAttackStarted = false;
                Destroy(projectileRef);
                //anim.SetLayerWeight(1, 0);
            }
        }
        
            if (Input.GetMouseButtonUp(0) && (isAttackStarted || isHolding))
            {
                anim.SetTrigger(fire);                
                anim.SetTrigger(cancelAttack);
                isHolding = false;
                isAttackStarted = false;

            //Setting the target of the Arrow
            targetPos = GameObject.Find("CrossHair").GetComponent<RangedHitPoint>().missleTarget;
            
            //Refactor this into a seperate script
            projectileRef.transform.SetParent(null);
            projectileRef.GetComponent<Arrow>().parentTrans = null;
            projectileRef.GetComponent<Arrow>().Fire(targetPos);
                
        }
            if (Input.GetMouseButton(3))
            {
                anim.SetTrigger(cancelAttack);
                isHolding = false;
                isAttackStarted = false;
                Destroy(projectileRef);
            //anim.SetLayerWeight(1, 0);
        }

        
        


        if (anim != null)
        {

            float y  = Input.GetAxis("Vertical");
            float x = Input.GetAxis("Horizontal");

            if (Input.GetKey(KeyCode.LeftShift))
            {
                x = Mathf.Clamp(x, -1f, 1f);
                y = Mathf.Clamp(y, -1f, 1f);
            }
            else
            {

                x = Mathf.Clamp(x, -0.5f, 0.5f);
                y = Mathf.Clamp(y, -0.5f, 0.5f);
            }

            //Debug.Log("X " + x + "|| Y " + y);

            anim.SetFloat(xHash, x);
            anim.SetFloat(yHash, y);

            float move = playerRB.velocity.magnitude;

            anim.SetFloat("Speed", move);

            //Debug.Log(move);

            if (Input.GetKeyDown(KeyCode.Space))
            {
                anim.SetTrigger(jumpHash);
            }

          

            if (Input.GetKey(KeyCode.A))
            {
                anim.SetBool("StrafeRight", true);

            }
          


        }



    }

    public void FixedUpdate()
    {

        //anim.SetFloat(randomHash, 1);


        //3 seconds
        //if (counter < 450)
        //{
        //    counter++;
        //}
        //else
        //{
        //    //prevNr = lerping;
        //    Random.InitState(System.DateTime.Now.Millisecond);
        //    var rand = Random.Range(0, amountOfIdleAnimationss);
        //    currentNr = rand;            
        //    counter = 0;
        //}
    }
}
