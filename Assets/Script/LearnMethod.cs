
using UnityEngine;

public class LearnMethod : MonoBehaviour
{
    //��k�y�k
    //�Ǧ^���� ��k�ۭq�W�� () {��k���e}
    //�L�Ǧ^ void
    //��k�W�� Unity �ߺD�Τj�g�}�Y
    private void Test()
    {
        // ��X (��X�W��)
        print("���o�AWord");
    }


    //�ۭq��k
    //�ݭn�I�s�~�|�h����

    //Unity ���J�f
    //�}�l�ƥ�(�Ŧ�W��)
    //����C����|����@��
    //��l�Ƴ]�w:��l���B�A�T���R����
    private void Start() 
    {
        //�I�s��k
        //��k�W��();
        Test();
        PrintColorTest();
    }
    private void PrintColorTest()
    {
        print("<color=yellow>����T��</color>");
        print("<color=#003399>�Ŧ�T��</color>");
    }


}
