// See https://aka.ms/new-console-template for more information
namespace Consoleprogram // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {


# region 1.기초 필기
            /*
            console.whiteline( ) : 특정한 문자열을 출력하는 함수 (다음줄로 띄어서 씀)

            console.white() : 특정한 문자열을 출력하는 함수(그대로 이어서 씀)

// 변수(variable)란?
// 데이터를 저장할 수 있는 메모리 공간을 생성하는 것입니다 (캐릭터의 내부설정을 설정하고 싶을때(체력,공격력,방어력 등) 주로 사용
            *메모리 공간을 확보할 자료형을 먼저 선언해주어야 합니다

 ; < -세미콜롬

빨간줄 = 에러

// bool -> 1 byte (참과 거짓)
// char -> 1 byte (문자)
// short -> 2 byte (정수)
// int -> 4 byte (정수)
// float -> 4 byte (실수)
// double -> 8 byte (실수)

            // =(대입 연산자) : 오른쪾에 있는 피연산자의 값을
            // 왼쪽에 있는 변수에 저장하는 연산자입니다.
            char grade = 'S';
            int health = 100;
            float attack;
            


            
            char grade = 'S';
            int health = 100;
            float attack = 36.5f;

            Console.Write("1000 ; " + health + " / ");
            Console.Write("500 ; " + attack + " / ");

            Console.WriteLine("Hello World!");
            Console.WriteLine("10 ; " + grade);
            */
            #endregion

            #region 변수의 이름 규칙


            // 1. 변수의 이름은 숫자로 시작할 수 없습니다
            // ex) int 1count = 6;

            // 2. 변수의 이름으로 키워드를 사용할 수 없습니다
            // ex) int int = 9;

            // 3. 변수의 이름에 공백이 포함될 수 없습니다
            // ex) int league of = 10;

            // 4. 변수의 이름으로 특수문자 "_"만 가능합니다
            // ex) int count_down = 50;

            // 5.변수의 대소문자를 구분합니다
            // ex) int value = 99;
            // ex) int VALUE = 20;

            // 6. 변수의 이름은 중복될 수 없습니다

            #endregion

            #region 프로그램 실행 순서

            // true (참) 1
            // false(거짓) 0

            bool condition = true;

            int data = 100;

            float pi = 3.141592f;

            #endregion






        }
    }
}