using UnityEngine;
/// <summary>
///  �ǲ߰j��
///  While�Bfor �о�
///  While do�Bforeach
/// </summary>
public class LearnLoop : MonoBehaviour
{
    private void Start()
    {
        //�j�� : ���ư���

        //While �j��y�k :
        // if (���L��) { �{�� } ����@��
        //While (���L��) { �{�� } ���ư��檽�쥬�L�Ȭ� false

        int count = 0;

        while (count < 5)
        {
            print("while �j��!" + count);
            count++;
        }

        // for(��l�� ; ���� ; �j�����᪺�B�z) { �{�� }
        for (int i = 0; i < 5; i++) 
        {
            print("for �j��!" + i);
        }
    }
}
