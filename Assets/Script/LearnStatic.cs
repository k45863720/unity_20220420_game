using UnityEngine;
/// <summary>
/// �ǲ� �R�A API
/// �R�A static
/// </summary>
public class LearnStatic : MonoBehaviour
{
    private void Start()
    {
        // �R�A�ݩ� static properties
        // 1. ���o get
        // 2. ���o�R�A�ݩʻy�k:
        // ���O�W��.�R�A�ݩʦW��
        print("�H����:" + Random.value);
        print("�ù��e��:" + Screen.width);
        print("��P�v:" + Mathf.PI);

        // 2. �]�w set (Read Only ����]�w)
    }
}