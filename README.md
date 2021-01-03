# [Beakjoon](https://www.acmicpc.net/problemset)
- [단계별 문제](https://www.acmicpc.net/step)


문법 정리(호출용)
기본형 : namespace명.class명.static_method명();
기본형 : class인스턴스.method명();

같은 namespace 안에서 다른 class 호출 시 namespace 생략 가능
같은 class 안에서는 static method 호출시 class명 생략가능
method 정의문에서 해당 인스턴스를 호출 시 this 사용. (this 예약어로 자동 설정됨)

### 함수 정의 호출 시 python과 C#의 다른점 
python에서 self 는 C# 에서  this 와 같다.
C#과 다른 점은 python에서는 인자로 self를 명시하지 않으면 static함수로 생각합니다.
추가적으로 접근제어자 (public,private,protected)는 이름 앞에 언더바(_)의 갯수로 구분합니다.

C#  |   public void Heal(int n) {this.HP += n}
python |  def Heal(self, n) : self.HP += n

C# | public static void Heal(Player p, int n) { p.HP += n}
python | def Heal( p, n) : p.HP += n

C# | private void heal(){}  
python | def __heal : pass

C# | protected void heal(){}
python | def _heal : pass