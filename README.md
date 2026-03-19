# 📌 Team Rule (팀 개발 규칙)



## ✅ 1. Git Commit Message 규칙 (필수)

커밋 메시지는 작업 내용을 한눈에 파악할 수 있도록 작성한다.

### 📍 타입 종류
- feat: 기능 추가
- fix: 버그 수정
- refactor: 구조 개선 (기능 변화 없음)
- style: 코드 스타일 수정 (세미콜론, 정렬 등)
- docs: 문서 수정
- test: 테스트 코드
- chore: 기타 작업 (빌드, 설정 등)

### 📍 작성 예시
- feat: 플레이어 이동 기능 추가
- fix: 적이 공격하지 않는 버그 수정
- refactor: UI 구조 분리

---

## ✅ 2. 브랜치 생성 규칙 (필수)

브랜치는 역할에 맞게 명확하게 분리한다.

### 📍 브랜치 구조
- main        → 배포용 (직접 작업 금지)
- develop     → 개발 통합 브랜치
- feature/*   → 기능 개발
- fix/*       → 버그 수정

### 📍 브랜치 예시
- feature/player-movement
- feature/inventory-system
- fix/enemy-ai-error

### 📍 규칙
- main 브랜치 직접 작업 ❌
- 모든 작업은 develop 기준으로 진행
- 작업 완료 후 Merge 진행
- 사용한 브랜치는 삭제 후 필요 시 재생성

---

## ✅ 3. 네이밍 규칙 (필수)

| 대상 | 규칙 | 예시 |
|------|------|------|
| 클래스 | PascalCase | `CoinSpawner`, `AssetManager` |
| 메서드 | PascalCase | `SpawnCoin()`, `CalculateDecay()` |
| 공개 프로퍼티 | PascalCase | `CurrentCash`, `FamePoint` |
| 비공개 필드 | _camelCase (언더스코어 접두사) | `_spawnInterval`, `_comboCount` |
| 지역 변수 | camelCase | `decayValue`, `bounceCount` |
| 상수 | UPPER_SNAKE_CASE | `MAX_COMBO_COUNT`, `BASE_DECAY_RATE` |
| 인터페이스 | I + PascalCase | `IPoolable`, `IInvestable` |
| ScriptableObject 클래스 | PascalCase + SO 접미사 | `CoinDataSO`, `TierDataSO` |
| 이벤트 | On + PascalCase | `OnCoinCollected`, `OnTierChanged` |

---

### ✅ 4. Merge & Pull Request 규칙 (필수)

PR은 작업 내용을 명확하게 전달하는 문서다.

📍 제목 형식

[기능] 캐릭터 선택 시스템 추가

[버그] 적 공격 안하는 문제 수정

📍 내용 작성 예시

Photon 동기화 구현

캐릭터 선택 UI 추가

100초 타이머 기능 구현

📍 규칙

무엇을 했는지 명확하게 작성

간결하게 작성

코드 확인 없이도 이해 가능하게 작성

---

### 5. 기능 구현 문서 작성 (선택)

기능 개발 전 간단한 설계를 작성한다.

📍 목적

작업 방향 명확화

문제 발생 시 빠른 공유

협업 효율 증가

[스킬 시스템]

- 키 입력 시 스킬 생성
  - 입력 감지 확인
  - 스킬 오브젝트 생성 확인

- 스킬 사용 시 마나 소모
  - 마나 100 소비

- 스킬 LV 15 이상 시 해금
  - 레벨 조건 확인
  - 해금 여부 체크

  ---

### 6. 문제 해결 규칙 (선택)

30분 이상 해결되지 않는 문제는 혼자 붙잡지 않는다.

📍 이유

시간 낭비 방지

팀 생산성 유지

빠른 문제 해결

📍 행동 지침

 