
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
        print("�Ǧ^ 10 ��k���G:" + ReturnTen());
        print("�ӫ~�`��:" + calculatePrice());
        Shoot("���y");            //�S���]�ðѼƷ|�H�w�]�Ȱ���
        Shoot("�q�y","������");  //�л\�Ѽ�
        Shoot("�B�y");            //�����w���G���~
        Shoot("���y","�զ⳷��");
        Shoot("���y",effect: "�զ⳷��"); //���y,������, ���w �ѼƦW�� : �զ⳷��
    }
    #region �T���C��]�w
    private void PrintColorTest()
    {
        print("<color=yellow>����T��</color>");
        print("<color=#003399>�Ŧ�T��</color>");
    }
    #endregion
    #region �Ǧ^���Ƴ]�w
    //�Ǧ^��k
    //�����f�t return
    private int ReturnTen()
    // �Ǧ^ ��� (��������������Ǧ^�����ۦP)
    {
        return 10;
    }
    #endregion
    #region  �ӫ~�����]�p
    public int countProduct = 10;
    public int countPrice = 99;
    private int calculatePrice()
    {
        return countProduct * countPrice;
    }
    #endregion
    #region �ޯ�]�p
    //�o�g���y�B�o�g�q�y
    //�o�g����
    private void ShootFire()
    {
        print("�o�g���y");
        print("���񭵮�");
    }
    private void ShootLighting()
    {
        print("�o�g�q�y");
        print("���񭵮�");
    }
    //�Ѽƻy�k : �Ѽ����� �ѼƦW�� ���w �w�]��
    //���w�]�Ȫ��Ѽƥ�����b�̥k��
    private void Shoot(string type,string sound = "������",string effect = "����")
    {
        print("�o�g:" + type);
        print("����:" + sound);
        print("�S��:" + effect);
    }
    // ��k���h�� overload
    // �w�q:
    //1. �ۦP�W�٪���k
    //2. �����P�ƶq���ѼƩΪ̤��P�������Ѽ�
    private void TestMethod(){

    }

    private void TestMethod(int number)
    {

    }
    #endregion

}
