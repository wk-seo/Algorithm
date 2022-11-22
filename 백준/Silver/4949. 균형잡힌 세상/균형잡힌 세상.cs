using System.Collections.Generic;

string s = "";
while(s!=".")//입력 반복문
{
    s = Console.ReadLine(); //입력 받음
    if (s == ".") break;  //반복문 종료 조건
    bool check = true; //닫는 괄호 하나만 들어왔을 때 false가 됨
    Stack<char> stack = new Stack<char>(); //char Stack
    for (int i = 0; i < s.Length; i++) // 문자 하나씩 검사
    {
        switch (s[i])
        {
            case '(': //여는 괄호가 들어왔을 때
            case '[':
                stack.Push(s[i]); //stack에 push
                break; //switch문 종료 -> 다음 문자로 넘어감
            case ')': //닫는 소괄호 들어왔을 때
                if (stack.Count != 0 && stack.Peek() == '(') //여는괄호가 있고, 걔가 소괄호일 때
                {
                    stack.Pop(); //뺀다(균형 맞음)
                    break; //swtich문 종료
                }
                else
                {
                    check = false;
                    break; //위 조건이 아니면 바로 switch문 종료
                }
            case ']': //닫는 대괄호 들어왔을 때
                if (stack.Count!=0 && stack.Peek()=='[') //여는 괄호가 있고 걔가 대괄호일 때
                {
                    stack.Pop(); //뺀다(균형 맞음)
                    break; //switch문 종료
                }
                else
                {
                    check = false;
                    break; //위 조건이 아니면 바로 switch문 종료
                } //위 조건이 아니면 바로 switch문 종료
        }
        if (!check) break; //다음 문자 검사
    }
    Console.WriteLine(check&&stack.Count==0 ? "yes" : "no");
    stack.Clear(); //stack 비워둠
}