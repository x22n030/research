using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    //�����A�C�e���̎���
    //�K�v�ȃA�C�e����񋓂���
    public enum ItemType
    {
        Leaf = 0,
        Key = 1,
        Sample = 2,
    }
    public ItemType item; //���̃A�C�e�������Ȃ̂�

    //�N���b�N���ꂽ��A��\���ɂȂ��ăA�C�e��Box�ɒǉ������
    //�^�C�~���O�F�N���b�N���ꂽ��
    //�����F
    //��\��
    //�A�C�e��Box�֒ǉ�

    private void Start()
    {
        //�Z�[�u�f�[�^���m�F���āA���łɎ����Ă���Ώ���
        bool hasThisItem = SaveManager.instance.GetItemData(item);
        if(hasThisItem == true)
        {
            gameObject.SetActive(false);

            ItemBox.instance.SetItem(item);
        }
        
    }


    //�^�C�~���O�F�N���b�N���ꂽ��
    public void OnThis()
    {
        //��\��
        gameObject.SetActive(false);
        // �A�C�e��Box�֒ǉ�:
        ItemBox.instance.SetItem(item);


    }

}
