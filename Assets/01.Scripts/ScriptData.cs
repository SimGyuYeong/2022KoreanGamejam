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
        yangScript.Add(new Script("아주 먼 옛날 아타마스라 , 불리는 왕이 살고 있었습니다.","1.mp3"));
        yangScript.Add(new Script("아타마스에게는 프릭소스와 헬레라는 두 자녀가 있었어요.","2.mp3"));
        yangScript.Add(new Script("프릭소스와 헬레의 어머니는 그들이 아주 어렸을 때 돌아가셨습니다.","3.mp3"));
        yangScript.Add(new Script("양어머니는 프릭소스와 헬레를 매우 미워해 괴롭히곤 했어요.","4.mp3"));
        yangScript.Add(new Script("전령의 신 헤르메스는 그들을 불쌍히 여겨","5.mp3"));
        yangScript.Add(new Script("날개 달린 황금 숫양을 내려보내 아이들을 구원합니다.","6.mp3"));
        yangScript.Add(new Script("제우스는 이 양의 공을 높게 사 별자리로 만들어 하늘로 올려보냈고","7.mp3"));
        yangScript.Add(new Script("그것이 지금의 양자리가 되었습니다.","8.mp3"));
    }

    void InitializeHwangso()
    {
        hwangsoScript.Add(new Script("아주 먼 옛날 에우로파라는 , 아름다운 공주가 살고 있었어요","1.mp3"));  
        hwangsoScript.Add(new Script("화창한 봄날 에우로파가 바닷가에서 놀고 있을 때", "2.mp3"));
        hwangsoScript.Add(new Script("근처를 산책하던 제우스가 우연히 에우로파를 보게 되었고","3.mp3"));
        hwangsoScript.Add(new Script("제우스는 에우로파의 아름다운 모습에 반해 사랑에 빠지게 되었답니다.","4.mp3"));
        hwangsoScript.Add(new Script("제우스는 눈처럼 하얀 커다란 소로 변하여 그녀에게 다가갔어요.","5.mp3"));
        hwangsoScript.Add(new Script("멋진 흰 소를 발견한 에우로파는 관심을 보이며 소에게 장난을 쳤습니다","6.mp3"));
        hwangsoScript.Add(new Script("에우로파는 소의 등에 올라탔고 소는 기다렸다는듯이 에우로파를 태우고 크레테 섬까지 헤엄쳐 갔어요.","7.mp3"));
        hwangsoScript.Add(new Script("크레테 섬에 도착한 소는 본래 모습인 제우스로 변해 에우로파에게 청혼하였고","8.mp3"));
        hwangsoScript.Add(new Script("에우로파를 아내로 맞이하게 되었답니다.","9.mp3"));
       
            
    }

    void Initializessangdongyi()
    {
        ssangdongyiScript.Add(new Script("아주 먼 옛날 카스트로와 , 폴룩스라는 우애 좋은 형제가 살고 있었습니다.","1.mp3"));
        ssangdongyiScript.Add(new Script("형인 카스트로는 말을 아주 잘 탔으며","2.mp3"));
        ssangdongyiScript.Add(new Script("동생인 폴룩스는 무기 다루기에 능하였고 불사의 몸이기도 했죠.","3.mp3"));
        ssangdongyiScript.Add(new Script("청년이 되어 두 형제는 많은 모험을 함께하게 됩니다.","4.mp3"));
        ssangdongyiScript.Add(new Script("그러나 어느 날 형인 , 카스트로가 심한 부상을 당해 결국 먼저 세상을 떠나게 됩니다.","5.mp3"));
        ssangdongyiScript.Add(new Script("폴룩스는 자신의 분신과도 같았던 카스트로의 죽음을 견딜 수 없었고","6.mp3"));
        ssangdongyiScript.Add(new Script("결국 제우스를 찾아가 자신도 함께 죽을 수 있게 해달라고 애원했습니다.","7.mp3"));
        ssangdongyiScript.Add(new Script("형제의 우애에 감동한 제우스는 이 우애를 영원히 기리기 위해 그들의 영혼을 하늘에 올렸고","8.mp3"));
        ssangdongyiScript.Add(new Script("그것이 지금의 쌍둥이자리가 되었습니다.","9.mp3"));

    }

    void Initializege()
    {
        geScript.Add(new Script("아주 먼 옛날 헤라라는 , 여신이 살고 있었습니다.","1.mp3"));
        geScript.Add(new Script("헤라는 영웅 헤라클레스를 매우 미워했어요.","2.mp3"));
        geScript.Add(new Script("헤라는 헤라클레스를 괴롭히기 위해 어려운 문제들을 해결하도록 시켰는데,", "3.mp3"));
        geScript.Add(new Script("그 중 하나가 바로 괴물 히드라를 죽이는 것이었습니다.","4.mp3"));
        geScript.Add(new Script("헤라는 히드라와 싸우는 헤라클레스를 방해하기 위해 게 한 마리를 보냈어요.","5.mp3"));
        geScript.Add(new Script("게는 헤라클레스의 발꿈치를 꼬집으며 헤라클레스를 방해했지만","6.mp3"));
        geScript.Add(new Script("결국 헤라클레스의 발에 짓밟혀 죽음을 맞이하게 됩니다.","7.mp3"));
        geScript.Add(new Script("이를 불쌍하게 여긴 헤라는 자신의 명령을 수행하다 죽은 게를 밤하)늘의 별자리로 만들었답니다.","8.mp3"));

    }

    void Initializesaza()
    {
        sazaScript.Add(new Script("아주 먼 옛날 포악한 , 괴물 네메아의 사자가 살고 있었어요.","1.mp3"));
        sazaScript.Add(new Script("네메아의 사자는 여러 사람들을 물어 죽이고 가축을 잡아먹으며 큰 피해를 끼쳤습니다.","2.mp3"));
        sazaScript.Add(new Script("영웅 헤라클레스는 네메아의 사자를 사냥하기 위해 길을 나서게 되었어요.","3.mp3"));
        sazaScript.Add(new Script("네메아의 사자를 마주친 헤라클레스는 사자와 혈투를 벌이지만","4.mp3"));
        sazaScript.Add(new Script("칼로도 창으로도 , 사자의 가죽을 뚫을 수는 없었습니다.","5.mp3"));
        sazaScript.Add(new Script("헤라클레스는 오랜 시간동안 네메아의 사자를 사냥하기 위해 노력했습니다.","6.mp3"));
        sazaScript.Add(new Script("오랜 싸움 끝에 헤라클레스는 네메아의 사자를 목 졸라 죽이는 데에 성공했고","7.mp3"));
        sazaScript.Add(new Script("제우스는 헤라클레스의 업적을 기리기 위해 네메아의 사자를 별자리로 만들었습니다","8.mp3"));
    }

    void InitializeCheonyeo()
    {
        cheonyeoScript.Add(new Script("아주 먼 옛날 아스트라이아라는 , 여신이 살고 있었어요.","1.mp3"));
        cheonyeoScript.Add(new Script("옛날에는 신과 사람들이 지상에서 함께 어울리며 살았지만","2.mp3"));
        cheonyeoScript.Add(new Script("사람들 사이에 분쟁과 싸움이 일어나기 시작했고 그, 모습에 실망한 신들은 지상을 버리고 하늘로 돌아가게 됩니다.","3.mp3"));
        cheonyeoScript.Add(new Script("그 중 아스트라이아 한명만은 인간을 믿어 지상에 남아있기로 결심했어요.","4.mp3"));
        cheonyeoScript.Add(new Script("아스트라이아는 인간들에게 열심히 정의를 알리며 지냈습니다.","5.mp3"));
        cheonyeoScript.Add(new Script("그러나 인간들은 여전히 거짓과 폭력을 일삼았어요.","6.mp3"));
        cheonyeoScript.Add(new Script("그를 지켜보던 아스트라이아는 끝내 참지 못하고 하늘나라로 올라가게 됩니다.","7.mp3"));
        cheonyeoScript.Add(new Script("이때 하늘로 돌아가던 아스트라이아의 모습이 지금의 처녀자리가 되었습니다.","8.mp3"));
    }

    void InitializeCheoncing()
    {
        cheonchingScript.Add(new Script("여신 아스트라이아는 늘 몸에 천칭을 지니고 다녔어요.","1.mp3"));
        cheonchingScript.Add(new Script("천칭은 인간의 선과 악을 재 운명을 결정하는 용도로 쓰이던 정의의 저울대입니다.","2.mp3"));
        cheonchingScript.Add(new Script("아스트라이아가 인간에 실망하여 하늘로 올라갈 때 자신의 , 천칭을 하늘에 걸어 놓았고","3.mp3"));
        cheonchingScript.Add(new Script("그것이 지금의 천칭자리가 되었습니다.","4.mp3"));
    }

    void InitializeJeongal()
    {
        jeongalScript.Add(new Script("아주 먼 옛날 오리온이라는 , 사냥꾼이 살고 있었어요.","1.mp3"));
        jeongalScript.Add(new Script("오리온은 매우 뛰어난 사냥 실력을 지닌 타고난 사냥꾼이었습니다.","2.mp3"));
        jeongalScript.Add(new Script("그 뛰어난 실력 덕에 오리온은 사냥의 여신 아르테미스와 친해지게 되었어요","3.mp3"));
        jeongalScript.Add(new Script("오리온은 아르테미스와 함께 사냥을 다니며 매우 자만에 빠지게 됩니다.","4.mp3"));
        jeongalScript.Add(new Script("오리온이 자만에 빠진 모습을 보고 화가 난 헤라는 오리온을 죽이기 위해 전갈을 보냈어요.","5.mp3"));
        jeongalScript.Add(new Script("헤라는 오리온을 죽인 공을 높게 사 전갈을 별자리로 만들어주었고","5.mp3"));
        jeongalScript.Add(new Script("그것이 지금의 전갈자리가 되었습니다.","6.mp3"));

    }

    void InitializeSasu()
    {
        sasuScript.Add(new Script("아주 먼 옛날 케이론이라는 , 현자가 살고 있었어요.","1.mp3"));
        sasuScript.Add(new Script("케이론은 온화하고 현명한 성품을 지니고 있었습니다.","2.mp3"));
        sasuScript.Add(new Script("현자라 칭송받던 케이론은 많은 영웅들을 교육하고 키워냈어요.","3.mp3"));
        sasuScript.Add(new Script("헤라클레스 아킬레우스 , 등 여러 영웅들이 케이론의 교육을 받았답니다.","4.mp3"));
        sasuScript.Add(new Script("제자인 헤라클레스는 켄타우로스와 싸움을 하던 중 그만 , 실수로 케이론에게 화살을 쏴 버리고 말았어요","5.mp3"));
        sasuScript.Add(new Script("케이론은 고통스러워하다 결국 죽음에 이르렀습니다","6.mp3"));
        sasuScript.Add(new Script("이를 안타깝게 여긴 제우스는 그를 하늘의 별자리로 만들어 주었고","7.mp3"));
        sasuScript.Add(new Script("그것이 지금의 사수자리가 되었습니다.","8.mp3"));

    }

    void InitializeYeomso()
    {
        yeomsoScript.Add(new Script("아주 먼 옛날 어느 날에 신들은 나일 강 주변에서 연회를 열었습니다","1.mp3"));
        yeomsoScript.Add(new Script("신들은 갈대 피리를 불기도 하고 춤을 , 추기도 하면서 즐겁게 연회를 즐겼어요.","2.mp3"));
        yeomsoScript.Add(new Script("그러나 연회 도중 갑자기 괴물 티폰이 나타났습니다.","3.mp3"));
        yeomsoScript.Add(new Script("괴물이 갑작스레 등장하자 신들은 놀라 제각기 여러 모습으로 변신하며 도망쳤어요.","4.mp3"));
        yeomsoScript.Add(new Script("그중 한 신이 강으로 도망칠 때 너무 , 급하게 변신하는 바람에 그만","5.mp3"));
        yeomsoScript.Add(new Script("상반신은 염소이고 하반신은 물고기인 모습이 되어버렸답니다.","6.mp3"));
        yeomsoScript.Add(new Script("그 우스꽝스러운 모습으로 헤엄치는 것을 재미있게 지켜본 제우스는 기념으로 그 모습을 하늘에 남겼고","6.mp3"));
        yeomsoScript.Add(new Script("그것이 지금의 염소자리가 되었습니다.","7.mp3"));

    }

    void InitializeMulbyeong()
    {
        mulbyeongScript.Add(new Script("아주 먼 옛날 헤베라는 , 여신이 살고 있었어요","1.mp3"));
        mulbyeongScript.Add(new Script("헤베는 신들을 위해 술을 따르는 일을 도맡아 하고 있었습니다.","2.mp3"));
        mulbyeongScript.Add(new Script("그러나 어느 날 헤베는 발목을 다치게 되고 술을 , 따르는 일을 계속하기 어려워졌어요.","3.mp3"));
        mulbyeongScript.Add(new Script("제우스는 헤베를 위해 독수리로 변해서 가니메데라는 소년을 납치해왔습니다.","4.mp3"));
        mulbyeongScript.Add(new Script("가니메데는 다친 헤베를 대신하여 술을 따르는 일을 하게 되었어요.","5.mp3"));
         mulbyeongScript.Add(new Script("이런 가니메데의 사연은 별자리로 만들어졌고","6.mp3"));
         mulbyeongScript.Add(new Script("그것이 지금의 물병자리가 되었습니다.","7.mp3"));
    }

    void InitializeMulgogi()
    {
        mulgogiScript.Add(new Script("아주 먼 옛날 여신 , 아프로디테와 그 아들 에로스가 살고 있었어요.","1.mp3"));
        mulgogiScript.Add(new Script("아프로디테와 에로스는 강을 건너다 괴물 티폰을 만나게 됩니다.","2.mp3"));
        mulgogiScript.Add(new Script("갑자기 나타난 티폰에 아프로디테와 에로스는 크게 놀랐어요.","3.mp3"));
        mulgogiScript.Add(new Script("그리고 재빨리 물고기로 변신해 도망쳤습니다.","4.mp3"));
        mulgogiScript.Add(new Script("아프로디테는 아들인 에로스를 잃어버리지 않기 위해 자신의 발과 에로스의 발을 끈으로 묶었어요","5.mp3"));
        mulgogiScript.Add(new Script("아프로디테는 이를 하늘에 기념하였고","6.mp3"));
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
