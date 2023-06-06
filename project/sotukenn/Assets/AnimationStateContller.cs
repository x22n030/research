using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//キャラの向き状態を変更するコントローラー
public class AnimationStateContller : MonoBehaviour
{
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        //コントローラーをセットしたオブジェクトに紐づいている
        this.animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown)
        {
            //キー入力があればAnimatorにstateをセットする
            Vector2? action = this.actionKeyDown();
            if (action.HasValue)
            {
                setStateToAnimator(vector: action.Value);
                return;
            }
        }
        //入力からVector2インスタンスを生成
        Vector2 vector = new Vector2(
            (int)Input.GetAxis("Horizontal"),
            (int)Input.GetAxis("Vertical"));
    
        //キー入力が続きている場合は、入力から生成したVestor２を渡す
        //入力がなければnull
        setStateToAnimator(vector: vector != Vector2.zero ? vector : (Vector2?)null);

    }
    //Animatorに状態をセットする
    private void setStateToAnimator(Vector2? vector)
    {
        if (!vector.HasValue)
        {
            this.animator.speed = 0.0f;
            return;
        }

        Debug.Log(vector.Value);
        this.animator.speed = 1.0f;
        this.animator.SetFloat("x", vector.Value.x);
        this.animator.SetFloat("x", vector.Value.x);
    }
    //特定のキーの入力があればキーに合わせたVector2インスタンスを返す
    //なければnullを返す
    private Vector2? actionKeyDown()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow)) return Vector2.up;
        if (Input.GetKeyDown(KeyCode.LeftArrow)) return Vector2.left;
        if (Input.GetKeyDown(KeyCode.DownArrow)) return Vector2.down;
        if (Input.GetKeyDown(KeyCode.RightArrow)) return Vector2.right;
        return null;
    }
}
