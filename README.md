게임 컨셉 

2D 탑 다운 게임

조작법

w, A, S, D 이동키

E 상호작용 키


기능 소개 

카메라 따라가기 

시네머신 카메라를 활용하여 구현 / 시네머신 카메라에 기본적으로 정해진 오브젝트를 따라가는 기능 탑재 

https://youtu.be/bjgFsXweQw8?si=FVN4oYf3qQdVj_gr

캐릭터 애니메이션 추가 / 캐릭터 선택 시스템 

SpriteLibray와 Sprite Resolver, Library Asset을 활용하여 처리

https://youtu.be/b3J2SInvuwM?si=ubI_EFgb3crLu8pr

시간 표시

DeltaTime.Now를 통해 구현.

참석 인원 UI

해당하는 오브젝트에 Tag(Player)를 걸고, 참석인원 UI를 누를 때마다 FindWithTag를 호출하여 
맵(같은 씬) 안에 있는 플레이어 수를 파악, 정보를 받아와 이름과 이미지를 처리하도록 구현
오브젝트 풀링으로 재활용 할 수 있도록 처리.

NPC 대화 

NPC의 자식 오브젝트에 collider를 하나 추가하여 플레이어가 접근했을 시 대화 활성화하도록 설정
Raycast2D를 통해 플레이어가 어떤 NPC와 대화하는지 감지.
이를 토대로 엑셀에 저장된 대화 내용을 불러 오도록 설정 (현재는 불러오는 과정에서 오류)

https://youtu.be/bZVa6C6vRBQ?si=_I_l67-Gs71WjXDU - rayCast를 통해 NPC 처리 내용


======================
+ 그 외 시도 

날씨

파티클 시스템을 활용하여 비 및 눈 내리는 연출 구현 

https://youtu.be/wrpuJkjaSiQ?si=0Uqy6PyPLmcNClwF


엑셀 연동

Excel Importer라는 외부 Tool을 활용하여 유니티 내부에서 엑셀을 빌드하여 데이터 처리 시도
(로그인 부분, 대화 내용 부분)

https://youtu.be/2oip0H7VgPM?si=SNcTYH8dXNdt6DtV

메뉴 UI 

Toggle을 활용하여 TabBar 구현

https://youtu.be/NVBP_CoU-Xk?si=JIu5Zz8NXj-0oHdW

