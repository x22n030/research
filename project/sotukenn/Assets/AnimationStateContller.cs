using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//�L�����̌�����Ԃ�ύX����R���g���[���[
public class AnimationStateContller : MonoBehaviour
{
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        //�R���g���[���[���Z�b�g�����I�u�W�F�N�g�ɕR�Â��Ă���
        this.animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown)
        {
            //�L�[���͂������Animator��state���Z�b�g����
            Vector2? action = this.actionKeyDown();
            if (action.HasValue)
            {
                setStateToAnimator(vector: action.Value);
                return;
            }
        }
        //���͂���Vector2�C���X�^���X�𐶐�
        Vector2 vector = new Vector2(
            (int)Input.GetAxis("Horizontal"),
            (int)Input.GetAxis("Vertical"));
    
        //�L�[���͂������Ă���ꍇ�́A���͂��琶������Vestor�Q��n��
        //���͂��Ȃ����null
        setStateToAnimator(vector: vector != Vector2.zero ? vector : (Vector2?)null);

    }
    //Animator�ɏ�Ԃ��Z�b�g����
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
    //����̃L�[�̓��͂�����΃L�[�ɍ��킹��Vector2�C���X�^���X��Ԃ�
    //�Ȃ����null��Ԃ�
    private Vector2? actionKeyDown()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow)) return Vector2.up;
        if (Input.GetKeyDown(KeyCode.LeftArrow)) return Vector2.left;
        if (Input.GetKeyDown(KeyCode.DownArrow)) return Vector2.down;
        if (Input.GetKeyDown(KeyCode.RightArrow)) return Vector2.right;
        return null;
    }
}
