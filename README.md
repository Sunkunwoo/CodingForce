# CodingForce Project
</br>

- 이 게임은 닷지 게임을 참고하여 만들어진 슈팅 게임입니다.
- 3개의 스테이지가 있으며 보스를 깨면 엔딩 장면이 연출됩니다.
- 게임의 주 컨텐츠는 적의 탄을 피하며 발사되는 탄을 적에게 맞추는 게임입니다.
- 게임의 주요 스토리는 “한 매니저님께서 월급이 밀리게 되어 밀린 월급을 되찾기 위해 코딩 포스를 출동”시키는 이야기입니다.

## 프롤로그

- 누군가 한 매니저님의 월급을 납치했다!
  월급을 구출하기 위해 한 매니저님은 코딩포스를 출격시킨다!
  적은 한 매니저님의 월급을 들고 날라 우주로 도망가게 되고 그 뒤를 쫓게 되는 코딩포스!
  가라! 코딩포스! 적을 혼내주고 한 매니저님의 월급을 되찾아라!

## 팀 소개

* 파워레인조!! -코딩포스-
  - RED 장영준(팀장)
  - BLUE 김준호
  - PINK 선건우
  - YELLOW 우승준
  - BLACK 유준영

</br>

## 주요 기능

* 캐릭터 선택
    - 타이틀 화면에서 로비로 넘어가면 존재하는 파워레인저들이 존재합니다.
    - 선택된 캐릭터는 움직입니다.
    - 선택되지 않은 캐릭터는 어두워지며 움직이지 않고 대기합니다.
* 캐릭터 이동
    - 이동은 WASD 키를 이용한 이동과 ↑←↓→ 키를 이용한 이동이 동시에 가능합니다.
* 캐릭터 공격
    - 캐릭터의 공격은 자동으로 발사되며 마우스 포인터를 기준으로 발사가 됩니다.
* 각종 능력이 있는 과일들
    - 쉴드, 공격력 증가, Boom 등 여러가지 과일들이 존재하며 이를 먹을 시 효과가 발휘됩니다.
* 무작위 위치에서 내려오는 적
    - 위에서 생성되는 무작위 위치의 적들이 내려오기 시작하며 어느 정도 내려온다면 무작위 위치에서 멈추게 됩니다.
    - 이 적들은 공격을 감행하며 이 공격을 받게 되면 체력이 떨어집니다.
* 적을 일정 수 이상 쓰러트리면 나오는 보스
    - 일정 수 이상의 적을 쓰러트리게 된다면 보스가 출현합니다.
* 보스를 쓰러트리면 넘어가는 스테이지 및 엔딩 크레딧
    - 보스를 쓰러트린다면 다음 스테이지로 넘어가며, 3스테이지의 보스를 쓰러트릴 시 엔딩 크레딧으로 넘어가게 됩니다.

</br>

##  사용 기술

  * Unity
  * C# 스크립트

</br>

## 구현한 과제

  * 필수
    - 게임 화면
    - 캐릭터
    - 총알과 공격
    - 충돌 감지
    - 게임 로직

  * 선택
    - 게임 난이도 조절
    - 아이템 시스템
    - 특수 능력
    - 시각적 효과
    - 사운드 효과

  * 그 외
    - 타이틀 화면 구현
    - 엔딩 크레딧 구현
    - 캐릭터(전투기)의 정면(얼굴)에서 나가도록 에임 포인트 설정
    - 게임 난이도 별로 각각 다른 맵 설정

</br>

## 문제 해결

*장영준
  - 각종 총알 모양을 잡는 스크립트에 겹치는 내용을 ShootManager로 만들어서 각자 상속 시켜봤는데 작동이 잘 안되는 부분이 있어 그 부분이 막혔었습니다.(결국 Spin Shoot은 삭제했습니다.) 2. player 오브젝트의 Player Shoot 을 enabled을 이용하여 비 활성화 했음에도 총알 발사가 지속되어 난관을 겪었었는데 InvokeRepeating같은 경우 스크립트가 비활성화 되어도 계속 작동하므로 CancelInvoke를 사용해야 됬습니다.

*김준호
  - 원래 처음에는 게임이 시작될 때 GameManager의 Start함수에 Instantiate(player)로 player의 객체를 생성하고 Lobby에서 그 생성된 객체에 sprite를 바꾸기 위해 접근하는 방식으로 구현했었다.선택될 때마다 해당 sprite도 잘 받아오고 문제 없었지만그 sprite를 player sprite의 값에 넣는 부분에서 계속 오류가 발생했다. Title에서부터 정해진 sprite가 stage에서도 계속 이어지는 오류였다.문제 원인은 Instantiate로 객체 생성을 Lobby 전에 함으로써 player객체가 이미 생성되고생성된 객체가 아닌 생성되기 전 객체 정보에 값을 계속해서 변경해줬기 떄문에생성한 객체의 값에 접근하지 못했고 따라서 player객체의 sprite를 변경하지 못했던 것이다.이러한 문제를 발견하고 기존 게임이 시작되면 Instantiate하던 부분을 지우고 Lobby Scene에 시작버튼이 눌리면 Instantiate하도록 수정해줘서 오류를 해결할 수 있었다.
  
*선건우
  - 타이틀에 일부 오브젝트를 미리 생성해둘시 리트라이시마다 타이틀 화면으로 돌아가거나 생성되자마자 탄막을 발사하는 현상과 관련 객채들이 중첩되어 생성되는 현상 해당 현상 수정을 위해서 게임오버시 관련된 객채가 모두 파괴되게 설정 및 새로 생성되는 오브젝트가 서로 연결이 잘되게하기 위해서 ( 특히 유저UI부분이 새로 생성된 플레이어를 제대로 참조하지 못하는 현상이있었습니다. ) Player를 참조하는 UI부분은 Tag를 통해서 플레이어를 찾고 플레이어의 정보를 받아오게 수정하였습니다. 
  
*우승준
  - MonsterMove를 처음 만들 때, 누수를 줄이려고 Update()를 쓰지 않고 Start()로만 써서 이동시키려고 했었습니다.
이때, Start()에 while 문으로 조건을 걸고 그 만큼 반복을 시키려 했었는데 원래라면 한 픽셀씩 움직이는 것을 기대했으나 기대랑은 다르게 해당 목표 지점까지 순간이동을 했던 적이 있어서 결국 이는 Update() 함수를 사용하는 것으로 픽셀 단위로 이동하게끔 수정하였습니다.
  
*유준영
  - 플레이어가 아이템 오브젝트와 만났을 때 특정 기능이 활성화되도록 하려고 하는데 획득시 아이템이 사라지지 않거나 / 획득 후 아이템 효과가 발생하지 않거나 / 특정 오브젝트를 실행시키려고 하는데 찾지를 못하거나 / 다른 오브젝트를 막아주는 기능이 활성화 되지 않거나 / 활성화 후 일정시간 후 비활성화가 되지 않거나 / 비활성화가 되었지만 쉴드 기능은 남아있거나 등등 하나의 오브젝트와 반응할 때 연쇄적으로 작용되는 부분들이 완벽하게 연결되지 않으면 실행되지 않아서 어려웠다
-> 스크립트를 여러가지로 나눠 각 기능들을 따로 호출하여 불러주거나 하였다
-> 트리거, 콜라이슨 등을 직접 여러번 사용해보고 찾아보면서 어떤 기능을 가지고 있고 어떻게 작용되는지 계속 변화를 주면서 경험해보았다
-> 스크립트 내부의 오류인 경우는 유니티에서 콘솔창의 오류를 참고하며 수정하였고 유니티에서의 오류가 생기는 경우 어떤 변화를 주었을 때 오류가 발생하였는지 원인 추적해보고 원인을 모르거나 해결책을 모르겠다고 판단되면 팀원, 튜터님에게 적극적으로 물어보고 til에 정리하였다
  

## 프로젝트 소감

*소감 1
  - 팀원간에 소통이 잘 되어서 좋았습니다.

*소감 2
  - 다양한 에셋을 사용해서 정해진 컨셉에 맞춰 게임을 만들고 꾸미는 재미가 있었습니다.
  
*소감 3
  - 이전에 해보지 못했던 작업을 맡아 구현해 보는 것이 좋았습니다.

*소감 4
  - 한 매니저님께선 개그요소로 쓰이기 좋으신 분이신 것 같아 좋았습니다.

<br/>
