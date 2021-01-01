# 파이썬 입출력 
백준에서 많이 사용되는 입출력 방법 

입력 예시 : 
```
3
1 2
4 5 
6 7
```
### 방법 1 : input
장점 : 코드가 짧아짐
단점 : 입출력 함수 호출이 느림
```python
T = int(input())
A = []
for i in range(T):
    x,y = map(int,input().split())
    A.append([x,y])
# A = [list( map(int,input().split()) ) for _ in range(T)]
print(*A, sep="\n", end="")
```

---

### 방법 2 : sys.stdin
장점 : 입출력 시간이 빠름
단점 : 여러줄 입력받을 떄 공백제거를 위해 rstrip을 해야함

```python
import sys
T = int(sys.stdin.readline())
A = []
for i in range(T):
    x,y = map(int, sys.stdin.readline().rstrip().split())
    A.append(x,y)

# A = [list(map(int,sys.stdin.readline().rstrip().split())) for _ in range(T)]
for i in A : 
    sys.stdout.write(str(i)+'\n')

# input = sys.stdin.readline
# 이렇게 함수를 덥어쓰기해서 간단하게 호출 할 수 있다.
```

---

### 방법 3 : open
장단점 : 잘 안써봐서 모름
파일 읽을 때 좋을 것 같음
```python
data = [*open(0)]
T = int(data[0])
A = map(int, data[1:] )
```
