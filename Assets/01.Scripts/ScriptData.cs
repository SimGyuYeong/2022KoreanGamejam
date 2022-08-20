using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptData : MonoBehaviour
{
    private List<Script> yangScript = new List<Script>();
    private List<Script> hwangsoScript = new List<Script>();
    private List<Script> ssangdongyiScript = new List<Script>();
    private List<Script> geScript = new List<Script>();
    private List<Script> sazaScript = new List<Script>();
    private List<Script> cheonyeoScript = new List<Script>();
    private List<Script> cheonchingScript = new List<Script>();
    private List<Script> jeongalScript = new List<Script>();
    private List<Script> sasuScript = new List<Script>();
    private List<Script> yeomsoScript = new List<Script>();
    private List<Script> mulbyeongScript = new List<Script>();
    private List<Script> mulgogiScript = new List<Script>();

    public List<Script> YangScript => yangScript;

    public List<Script> HwangsoScript => hwangsoScript;

    public List<Script> SsangdongyiScript => ssangdongyiScript;

    public List<Script> GeScript => geScript;

    public List<Script> SazaScript => sazaScript;

    public List<Script> CheonyeoScript => cheonyeoScript;

    public List<Script> CheonchingScript => cheonchingScript;

    public List<Script> JeongalScript => jeongalScript;

    public List<Script> SasuScript => sasuScript;

    public List<Script> YeomsoScript => yeomsoScript;

    public List<Script> MulbyeongScript => mulbyeongScript;

    public List<Script> MulgogiScript => mulgogiScript;

    void InitializeYang()
    {
        yangScript.Add(new Script("���� �� ���� ��Ÿ������ , �Ҹ��� ���� ��� �־����ϴ�.","1.mp3"));
        yangScript.Add(new Script("��Ÿ�������Դ� �����ҽ��� �ﷹ��� �� �ڳడ �־����.","2.mp3"));
        yangScript.Add(new Script("�����ҽ��� �ﷹ�� ��Ӵϴ� �׵��� ���� ����� �� ���ư��̽��ϴ�.","3.mp3"));
        yangScript.Add(new Script("���Ӵϴ� �����ҽ��� �ﷹ�� �ſ� �̿��� �������� �߾��.","4.mp3"));
        yangScript.Add(new Script("������ �� �츣�޽��� �׵��� �ҽ��� ����","5.mp3"));
        yangScript.Add(new Script("���� �޸� Ȳ�� ������ �������� ���̵��� �����մϴ�.","6.mp3"));
        yangScript.Add(new Script("���콺�� �� ���� ���� ���� �� ���ڸ��� ����� �ϴ÷� �÷����°�","7.mp3"));
        yangScript.Add(new Script("�װ��� ������ ���ڸ��� �Ǿ����ϴ�.","8.mp3"));
    }

    void InitializeHwangso()
    {
        hwangsoScript.Add(new Script("���� �� ���� ������Ķ�� , �Ƹ��ٿ� ���ְ� ��� �־����","1.mp3"));  
        hwangsoScript.Add(new Script("ȭâ�� ���� ������İ� �ٴ尡���� ��� ���� ��", "2.mp3"));
        hwangsoScript.Add(new Script("��ó�� ��å�ϴ� ���콺�� �쿬�� ������ĸ� ���� �Ǿ���","3.mp3"));
        hwangsoScript.Add(new Script("���콺�� ��������� �Ƹ��ٿ� ����� ���� ����� ������ �Ǿ���ϴ�.","4.mp3"));
        hwangsoScript.Add(new Script("���콺�� ��ó�� �Ͼ� Ŀ�ٶ� �ҷ� ���Ͽ� �׳࿡�� �ٰ������.","5.mp3"));
        hwangsoScript.Add(new Script("���� �� �Ҹ� �߰��� ������Ĵ� ������ ���̸� �ҿ��� �峭�� �ƽ��ϴ�","6.mp3"));
        hwangsoScript.Add(new Script("������Ĵ� ���� � �ö����� �Ҵ� ��ٷȴٴµ��� ������ĸ� �¿�� ũ���� ������ ����� �����.","7.mp3"));
        hwangsoScript.Add(new Script("ũ���� ���� ������ �Ҵ� ���� ����� ���콺�� ���� ������Ŀ��� ûȥ�Ͽ���","8.mp3"));
        hwangsoScript.Add(new Script("������ĸ� �Ƴ��� �����ϰ� �Ǿ���ϴ�.","9.mp3"));
       
            
    }

    void Initializessangdongyi()
    {
        ssangdongyiScript.Add(new Script("���� �� ���� ī��Ʈ�ο� , ���轺��� ��� ���� ������ ��� �־����ϴ�.","1.mp3"));
        ssangdongyiScript.Add(new Script("���� ī��Ʈ�δ� ���� ���� �� ������","2.mp3"));
        ssangdongyiScript.Add(new Script("������ ���轺�� ���� �ٷ�⿡ ���Ͽ��� �һ��� ���̱⵵ ����.","3.mp3"));
        ssangdongyiScript.Add(new Script("û���� �Ǿ� �� ������ ���� ������ �Բ��ϰ� �˴ϴ�.","4.mp3"));
        ssangdongyiScript.Add(new Script("�׷��� ��� �� ���� , ī��Ʈ�ΰ� ���� �λ��� ���� �ᱹ ���� ������ ������ �˴ϴ�.","5.mp3"));
        ssangdongyiScript.Add(new Script("���轺�� �ڽ��� �нŰ��� ���Ҵ� ī��Ʈ���� ������ �ߵ� �� ������","6.mp3"));
        ssangdongyiScript.Add(new Script("�ᱹ ���콺�� ã�ư� �ڽŵ� �Բ� ���� �� �ְ� �ش޶�� �ֿ��߽��ϴ�.","7.mp3"));
        ssangdongyiScript.Add(new Script("������ ��ֿ� ������ ���콺�� �� ��ָ� ������ �⸮�� ���� �׵��� ��ȥ�� �ϴÿ� �÷Ȱ�","8.mp3"));
        ssangdongyiScript.Add(new Script("�װ��� ������ �ֵ����ڸ��� �Ǿ����ϴ�.","9.mp3"));

    }

    void Initializege()
    {
        geScript.Add(new Script("���� �� ���� ����� , ������ ��� �־����ϴ�.","1.mp3"));
        geScript.Add(new Script("���� ���� ���Ŭ������ �ſ� �̿��߾��.","2.mp3"));
        geScript.Add(new Script("���� ���Ŭ������ �������� ���� ����� �������� �ذ��ϵ��� ���״µ�,", "3.mp3"));
        geScript.Add(new Script("�� �� �ϳ��� �ٷ� ���� ����� ���̴� ���̾����ϴ�.","4.mp3"));
        geScript.Add(new Script("���� ������ �ο�� ���Ŭ������ �����ϱ� ���� �� �� ������ ���¾��.","5.mp3"));
        geScript.Add(new Script("�Դ� ���Ŭ������ �߲�ġ�� �������� ���Ŭ������ ����������","6.mp3"));
        geScript.Add(new Script("�ᱹ ���Ŭ������ �߿� ������ ������ �����ϰ� �˴ϴ�.","7.mp3"));
        geScript.Add(new Script("�̸� �ҽ��ϰ� ���� ���� �ڽ��� ����� �����ϴ� ���� �Ը� ����)���� ���ڸ��� �������ϴ�.","8.mp3"));

    }

    void Initializesaza()
    {
        sazaScript.Add(new Script("���� �� ���� ������ , ���� �׸޾��� ���ڰ� ��� �־����.","1.mp3"));
        sazaScript.Add(new Script("�׸޾��� ���ڴ� ���� ������� ���� ���̰� ������ ��Ƹ����� ū ���ظ� ���ƽ��ϴ�.","2.mp3"));
        sazaScript.Add(new Script("���� ���Ŭ������ �׸޾��� ���ڸ� ����ϱ� ���� ���� ������ �Ǿ����.","3.mp3"));
        sazaScript.Add(new Script("�׸޾��� ���ڸ� ����ģ ���Ŭ������ ���ڿ� ������ ��������","4.mp3"));
        sazaScript.Add(new Script("Į�ε� â���ε� , ������ ������ ���� ���� �������ϴ�.","5.mp3"));
        sazaScript.Add(new Script("���Ŭ������ ���� �ð����� �׸޾��� ���ڸ� ����ϱ� ���� ����߽��ϴ�.","6.mp3"));
        sazaScript.Add(new Script("���� �ο� ���� ���Ŭ������ �׸޾��� ���ڸ� �� ���� ���̴� ���� �����߰�","7.mp3"));
        sazaScript.Add(new Script("���콺�� ���Ŭ������ ������ �⸮�� ���� �׸޾��� ���ڸ� ���ڸ��� ��������ϴ�","8.mp3"));
    }

    void InitializeCheonyeo()
    {
        cheonyeoScript.Add(new Script("���� �� ���� �ƽ�Ʈ���̾ƶ�� , ������ ��� �־����.","1.mp3"));
        cheonyeoScript.Add(new Script("�������� �Ű� ������� ���󿡼� �Բ� ��︮�� �������","2.mp3"));
        cheonyeoScript.Add(new Script("����� ���̿� ����� �ο��� �Ͼ�� �����߰� ��, ����� �Ǹ��� �ŵ��� ������ ������ �ϴ÷� ���ư��� �˴ϴ�.","3.mp3"));
        cheonyeoScript.Add(new Script("�� �� �ƽ�Ʈ���̾� �Ѹ��� �ΰ��� �Ͼ� ���� �����ֱ�� ����߾��.","4.mp3"));
        cheonyeoScript.Add(new Script("�ƽ�Ʈ���̾ƴ� �ΰ��鿡�� ������ ���Ǹ� �˸��� ���½��ϴ�.","5.mp3"));
        cheonyeoScript.Add(new Script("�׷��� �ΰ����� ������ ������ ������ �ϻ�Ҿ��.","6.mp3"));
        cheonyeoScript.Add(new Script("�׸� ���Ѻ��� �ƽ�Ʈ���̾ƴ� ���� ���� ���ϰ� �ϴó���� �ö󰡰� �˴ϴ�.","7.mp3"));
        cheonyeoScript.Add(new Script("�̶� �ϴ÷� ���ư��� �ƽ�Ʈ���̾��� ����� ������ ó���ڸ��� �Ǿ����ϴ�.","8.mp3"));
    }

    void InitializeCheoncing()
    {
        cheonchingScript.Add(new Script("���� �ƽ�Ʈ���̾ƴ� �� ���� õĪ�� ���ϰ� �ٳ���.","1.mp3"));
        cheonchingScript.Add(new Script("õĪ�� �ΰ��� ���� ���� �� ����� �����ϴ� �뵵�� ���̴� ������ ������Դϴ�.","2.mp3"));
        cheonchingScript.Add(new Script("�ƽ�Ʈ���̾ư� �ΰ��� �Ǹ��Ͽ� �ϴ÷� �ö� �� �ڽ��� , õĪ�� �ϴÿ� �ɾ� ���Ұ�","3.mp3"));
        cheonchingScript.Add(new Script("�װ��� ������ õĪ�ڸ��� �Ǿ����ϴ�.","4.mp3"));
    }

    void InitializeJeongal()
    {
        jeongalScript.Add(new Script("���� �� ���� �������̶�� , ��ɲ��� ��� �־����.","1.mp3"));
        jeongalScript.Add(new Script("�������� �ſ� �پ ��� �Ƿ��� ���� Ÿ�� ��ɲ��̾����ϴ�.","2.mp3"));
        jeongalScript.Add(new Script("�� �پ �Ƿ� ���� �������� ����� ���� �Ƹ��׹̽��� ģ������ �Ǿ����","3.mp3"));
        jeongalScript.Add(new Script("�������� �Ƹ��׹̽��� �Բ� ����� �ٴϸ� �ſ� �ڸ��� ������ �˴ϴ�.","4.mp3"));
        jeongalScript.Add(new Script("�������� �ڸ��� ���� ����� ���� ȭ�� �� ���� �������� ���̱� ���� ������ ���¾��.","5.mp3"));
        jeongalScript.Add(new Script("���� �������� ���� ���� ���� �� ������ ���ڸ��� ������־���","5.mp3"));
        jeongalScript.Add(new Script("�װ��� ������ �����ڸ��� �Ǿ����ϴ�.","6.mp3"));

    }

    void InitializeSasu()
    {
        sasuScript.Add(new Script("���� �� ���� ���̷��̶�� , ���ڰ� ��� �־����.","1.mp3"));
        sasuScript.Add(new Script("���̷��� ��ȭ�ϰ� ������ ��ǰ�� ���ϰ� �־����ϴ�.","2.mp3"));
        sasuScript.Add(new Script("���ڶ� Ī�۹޴� ���̷��� ���� �������� �����ϰ� Ű���¾��.","3.mp3"));
        sasuScript.Add(new Script("���Ŭ���� ��ų���콺 , �� ���� �������� ���̷��� ������ �޾Ҵ�ϴ�.","4.mp3"));
        sasuScript.Add(new Script("������ ���Ŭ������ ��Ÿ��ν��� �ο��� �ϴ� �� �׸� , �Ǽ��� ���̷п��� ȭ���� �� ������ ���Ҿ��","5.mp3"));
        sasuScript.Add(new Script("���̷��� ���뽺�����ϴ� �ᱹ ������ �̸������ϴ�","6.mp3"));
        sasuScript.Add(new Script("�̸� ��Ÿ���� ���� ���콺�� �׸� �ϴ��� ���ڸ��� ����� �־���","7.mp3"));
        sasuScript.Add(new Script("�װ��� ������ ����ڸ��� �Ǿ����ϴ�.","8.mp3"));

    }

    void InitializeYeomso()
    {
        yeomsoScript.Add(new Script("���� �� ���� ��� ���� �ŵ��� ���� �� �ֺ����� ��ȸ�� �������ϴ�","1.mp3"));
        yeomsoScript.Add(new Script("�ŵ��� ���� �Ǹ��� �ұ⵵ �ϰ� ���� , �߱⵵ �ϸ鼭 ��̰� ��ȸ�� �����.","2.mp3"));
        yeomsoScript.Add(new Script("�׷��� ��ȸ ���� ���ڱ� ���� Ƽ���� ��Ÿ�����ϴ�.","3.mp3"));
        yeomsoScript.Add(new Script("������ ���۽��� �������� �ŵ��� ��� ������ ���� ������� �����ϸ� �����ƾ��.","4.mp3"));
        yeomsoScript.Add(new Script("���� �� ���� ������ ����ĥ �� �ʹ� , ���ϰ� �����ϴ� �ٶ��� �׸�","5.mp3"));
        yeomsoScript.Add(new Script("��ݽ��� �����̰� �Ϲݽ��� ������� ����� �Ǿ���ȴ�ϴ�.","6.mp3"));
        yeomsoScript.Add(new Script("�� �콺�ν����� ������� ���ġ�� ���� ����ְ� ���Ѻ� ���콺�� ������� �� ����� �ϴÿ� �����","6.mp3"));
        yeomsoScript.Add(new Script("�װ��� ������ �����ڸ��� �Ǿ����ϴ�.","7.mp3"));

    }

    void InitializeMulbyeong()
    {
        mulbyeongScript.Add(new Script("���� �� ���� �캣��� , ������ ��� �־����","1.mp3"));
        mulbyeongScript.Add(new Script("�캣�� �ŵ��� ���� ���� ������ ���� ���þ� �ϰ� �־����ϴ�.","2.mp3"));
        mulbyeongScript.Add(new Script("�׷��� ��� �� �캣�� �߸��� ��ġ�� �ǰ� ���� , ������ ���� ����ϱ� ����������.","3.mp3"));
        mulbyeongScript.Add(new Script("���콺�� �캣�� ���� �������� ���ؼ� ���ϸ޵���� �ҳ��� ��ġ�ؿԽ��ϴ�.","4.mp3"));
        mulbyeongScript.Add(new Script("���ϸ޵��� ��ģ �캣�� ����Ͽ� ���� ������ ���� �ϰ� �Ǿ����.","5.mp3"));
         mulbyeongScript.Add(new Script("�̷� ���ϸ޵��� �翬�� ���ڸ��� ���������","6.mp3"));
         mulbyeongScript.Add(new Script("�װ��� ������ �����ڸ��� �Ǿ����ϴ�.","7.mp3"));
    }

    void InitializeMulgogi()
    {
        mulgogiScript.Add(new Script("���� �� ���� ���� , �����ε��׿� �� �Ƶ� ���ν��� ��� �־����.","1.mp3"));
        mulgogiScript.Add(new Script("�����ε��׿� ���ν��� ���� �ǳʴ� ���� Ƽ���� ������ �˴ϴ�.","2.mp3"));
        mulgogiScript.Add(new Script("���ڱ� ��Ÿ�� Ƽ���� �����ε��׿� ���ν��� ũ�� ������.","3.mp3"));
        mulgogiScript.Add(new Script("�׸��� �绡�� ������ ������ �����ƽ��ϴ�.","4.mp3"));
        mulgogiScript.Add(new Script("�����ε��״� �Ƶ��� ���ν��� �Ҿ������ �ʱ� ���� �ڽ��� �߰� ���ν��� ���� ������ �������","5.mp3"));
        mulgogiScript.Add(new Script("�����ε��״� �̸� �ϴÿ� ����Ͽ���","6.mp3"));
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
