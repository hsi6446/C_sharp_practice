using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {

            /* 1. basic concept
             * C# is an elegant object-oriented language that enables developers to build a variety of secure and robust applications that run on the .NET Framework. 
               You can use C# to create Windows applications, Web services, mobile applications, client-server applications, database applications, and much, much more. 

             * C#은 개발자들이 .NET Framework에서 작동하는 안전하고 강력한 여러가지 어플리케이션을 만들도록 해주는 정밀한 객체지향 언어이다.
                     Windows applications(윈도우 어플리케이션), Web services(웹 서비스), mobile applications(모바일 어플리케이션), client-server applications(클라이언트-서버 어플리케이션),
                     database applications(데이터베이스 어플리케이션) 그리고 그 외의 아주 많은 것들을 C#을 사용해 만들 수 있다.

             * The .NET Framework
                    The .NET Framework consists of the Common Language Runtime (CLR) and the .NET Framework class library.
                    The CLR is the foundation of the .NET Framework. It manages code at execution time, providing core services such as memory management, code accuracy, 
                    and many other aspects of your code.
                    The class library is a collection of classes, interfaces, and value types that enable you to accomplish a range of common programming tasks, such as data collection, 
                    file access, and working with text.
                    C# programs use the .NET Framework class library extensively to do common tasks and provide various functionalities.

              *해석: The .NET Framework는 Common Language Runtime (CLR) 과 the .NET Framework class library로 구성된다. 
                    The CLR은 the .NET Framework의 기초다. CRL은 실행 시간에 코드를 관리하고 memory management(메모리 관리), code accuracy(코드 정확도), 그리고 다른 여러 코드의 핵심 서비스를 제공한다.
                    클래스 라이브러리는 클래스, 인터페이스, 값 형식들(value types)의 집합으로 데이터 콜렉션, 파일 엑세스와 텍스트 작업 같은 일반 프로그래밍 범위에 속하는 업무를 할 수 있게끔 해준다.
                    C# 프로그램은 일반적인 업무를 수행하고 다양한 함수를 제공하기 위해 The .NET Framework 클래스 라이브러리를 광범위하게 사용한다. 

             * These concepts might seem complex, but for now just remember that applications written in C# use the .NET Framework and its components.
             * 이 개념들이 복잡하게 보일 수도 있다. 지금은 일단 C#으로 쓰여진 어플리케이션이 .NET Framework와 .NET Framework의 컴포넌트를 이용한다는 것을 기억하라.
             


             *Variables
                    Programs typically use data to perform tasks. 
                    Creating a variable reserves a memory location, or a space in memory, for storing values. It is called variable because the information stored in that location can be changed 
                    when the program is running. 
                    To use a variable, it must first be declared by specifying the name and data type. 
                    A variable name, also called an identifier, can contain letters, numbers and the underscore character (_) and must start with a letter or underscore. 
                    Although the name of a variable can be any set of letters and numbers, the best identifier is descriptive of the data it will contain. 
                    This is very important in order to create clear, understandable and readable code!

             *변수
                    프로그램은 작업을 수행하기 위해 일반적으로 데이터를 사용한다.
                    변수를 만드는 것은 값을 저장하기 위해 메모리 로케이션이나 메모리 활용 공간을 따로 남겨두는 것이다.
                    변수를 사용하기 위해서는 반드시 먼저 이름과 데이터 타입을 명시하는 것으로 선언해야한다. 
                    변수의 이름은 식별자라고도 한다. 그리고 문자와 숫자 언더코드 문자(_)를 포함할 수 있고, 반드시 문자나 언더코드로 시작한다.
                    변수의 이름은 어떤 문자나 숫자를 이용해도 되지만, 가장 좋은 식별자는 담겨질 데이터를 묘사하는 것이다.
                    명확하고, 이해하기 쉽고, 잘 읽히는 코드를 만들기 위해서는 방금 말한 부분이 정말 중요하다!

             *For example, firstName and lastName are good descriptive variable names, while abc and xyz are not.
             *예를 들면, "firstName"과 "lastName"은 잘 쓰여진 변수이름인 반면에 abc와 xyz는 완전 형편없는 변수이름이다.

             *Variable Types 변수 타입
                    A data type defines the information that can be stored in a variable, the size of needed memory and the operations that can be performed with the variable. 
                    For example, to store an integer value (a whole number) in a variable, use the int keyword:  int myAge;

                    (?)데이터타입은 변수의 필요한 메모리와 변수를 가지고 수행할 수 있는 동작들의 크기에 담을 수 있는 정보를 정의한다.
                    예를 들어, 변수에 정수 값(모든 숫자)을 저장하기 위해 int myAge;라는 키워드를 사용한다.


                    The code above declares a variable named myAge of type integer.
                    A line of code that completes an action is called a statement. Each statement in C# must end with a semicolon.

                    코드는 정수형의 myAge라고 이름붙인 변수를 선언한 것보다 위에 있다.
                    작업을 끝낸 코드의 라인은 명령문이라 부른다. C#에서 각각의 명령문은 반드시 세미콜론(;)으로 끝난다.


                    You can assign the value of a variable when you declare it: int myAge = 18;

                    int myAge = 18; 이라고 선언할 때, 변수의 값을 할당할 수 있다. =(int myAge = 18; 이라고 선언함으로써 변수에 값을 할당 할 수 있는 것이다.)

                    or later in your code: 
                        int myAge;
                        myAge = 18;

                    (아니면 이런 식으로도 가능하다.)

                    Remember that you need to declare the variable before using it.
                    변수를 사용하기 전에는, 먼저 선언부터 해야한다는 것을 잊지마세요. 별이 다섯개~~~~


                    *Built-in Data Types 고유 데이터 타입

                    There are a number of built-in data types in C#. The most common are:
                    int - integer.
                    float - floating point number.
                    double - double-precision version of float.
                    char - a single character.
                    bool - Boolean that can have only one of two values: True or False.
                    string - a sequence of characters.

                    C#에는 많은 고유 데이터 타입이 있다. 그 중 일반적으로 쓰이는 것들은 다음과 같다.
                    int - 정수
                    float - 4바이트 실수 데이터형
                    double - 8바이트 실수 데이터형
                    char - 한 개의 문자
                    bool - True or False의 논리 연산자
                    string - 문자열             

                    The statements below use C# data types: (쓰임새 예시)
                        int x = 42;
                        double pi = 3.14;
                        char y = 'Z';
                        bool isOnline = true;
                        string firstName = "David";


                    *Note that char values are assigned using single quotes and string values require double quotes.
                     You will learn how to perform different operations with variables in the upcoming lessons!

                     char 값은 ''(작은따옴표)와 ""(큰따옴표)를 요구하는 문자열 타입을 통해 할당되는 것에 주목하자.
                     앞으로의 수업에서 어떻게 변수와 함께 다른 연산을 수행할 수 있는 지를 배우게 될 것이다.
            


            *Your First C# Program 첫 번째 C# 프로그램


                    You can run, save, and share your C# codes on our Code Playground, without installing any additional software.

                    추가 소프트웨어를 설치하지 않고도, 우리의 코드 플레이그라운드에 당신의 C# 코드를 공유하고, 저장, 구동할 수 있다. 

                    Reference this lesson if you need to install the software on your computer.                     
                    이번 수업은 당신의 컴퓨터에 소프트웨어를 설치해보세요.(?)

                    To create a C# program, you need to install an integrated development environment (IDE) with coding and debugging tools.
                    We will be using Visual Studio Community Edition, which is available to download for free.
                    After installing it, choose the default configuration. 
                    Next, click File->New->Project and then choose Console Application as shown below: 

                    C# 프로그램을 만들기 위해서는, 코딩과 디버깅 도구와 함께 표준 개발 환경(IDE)을 설치해야한다.
                    우리는 무료로 다운로드할 수 있는 비주얼 스튜디오 커뮤니케이션 에디션을 사용할 것이다.
                    비주얼 스튜디오를 설치하고나면, 기본 설정을 정하자.
                    그 다음, File->New->Project를 누르고 아래처럼 콘솔 어플리케이션을 선택하자.

                    Enter a name for your Project and click OK.
                    프로젝트의 이름을 정하고, OK를 누른다.

                    Console application uses a text-only interface. We chose this type of application to focus on learning the fundamentals of C#.
                    콘솔 어플리케이션은 텍스트로만 이루어진 인터페이스를 사용한다. C#의 기초를 공부하는 것에 중점을 두기 위해 이 어플리케이션 타입을 선택하자.


                    You will learn what each of the statements do in the upcoming lessons. 
                    앞으로의 수업에서 각각의 명령문이 하는 것을 배우게 될 것이다.
                    
                    For now, remember that every C# console application must contain a method (a function) named Main. 
                    Main is the starting point of every application, i.e. the point where our program starts execution from.
                    지금은 C# 콘솔 어플리케이션이 반드시 메인 메소드를 갖고 있다는 것만을 기억하자.
                    메인 메소드는 모든 어플리케이션의 시작점이다. 즉, 우리의 프로그램이 실행을 시작하는 지점이다.

                    We will learn about classes, methods, arguments, and namespaces in the upcoming lessons.
                    우리는 앞으로의 수업에서 클래스와 메소드, 인수, 그리고 네임스페이스에 대해 배울 것이다.

                    
            *Displaying Output
                    Most applications require some input from the user and give output as a result.
                    To display text to the console window you use the Console.Write or Console.WriteLine methods. 
                    The difference between these two is that Console.WriteLine is followed by a line terminator, which moves the cursor to the next line after the text output. 

            *디스플레잉 출력
                    대부분의 어플리케이션은 결과로써의 출력을 주고, 유저에게 입력을 요구한다.
                    콘솔 창에 텍스트를 나타내기 위해서, [Console.Write 나 Console.WriteLine] 메소드를 사용한다.
                    이 두 메소드의 차이점은 다음과 같다. Console.WriteLine은 텍스트 출력 다음에 다음 줄을 커서로 움직이는 라인 터미네이터에 따른다.(?)

            *Note the parentheses after the WriteLine method. This is the way to pass data, or arguments, to methods. 
             In our case WriteLine is the method and we pass "Hello World!" to it as an argument. String arguments must be enclosed in quotation marks.
                    WriteLine 메소드 이후의 괄호에 주목하자. 이것은 데이타, 독립변수를 메소드까지 지난다.
                    WriteLine의 경우는 메소드이자, "Hello World!"를 독립변수까지 지나친다. 문자 인수는 반드시 인용마크 안에 들어가 있어야한다.


            *User Input
                    The Console.ReadLine() method returns a string value. 
                    If you are expecting another type of value (such as int or double), the entered data must be converted to that type.
                    This can be done using the Convert.ToXXX methods, where XXX is the .NET name of the type that we want to convert to. 
                    For example, methods include Convert.ToDouble and Convert.ToBoolean.
                    For integer conversion, there are three alternatives available based on the bit size of the integer: Convert.ToInt16, Convert.ToInt32 and Convert.ToInt64. 
                    The default int type in C# is 32-bit.

            *유저 입력
                    Console.ReadLine() 메소드는 문자값을 리턴한다.
                    만약 정수나 8비트형 실수 값 같은 다른 타입의 값을 기대한다면, 입력된 데이터의 타입을 반드시 변환해야한다.
                    이것은 Convert.ToXXX 메소드로 가능하다. XXX는 우리가 변환시키고자 하는 타입의 .NET 이름 (?)
                    예를 들면, 메소드는 Convert.ToDouble 과 Convert.ToBoolean. 를 포함한다.
                    정수형으로 변환하기 위해서, 세 개의 대안이 가능한데 Convert.ToInt16, Convert.ToInt32 and Convert.ToInt64. 의 사이즈를 기반으로 한 것이다.
                    C#에서 기본 정수타입은 32-bit다.

            *If, in the program above, a non-integer value is entered (for example, letters), the Convert will fail and cause an error.
            *만약 프로그램 위에, 문자열 등의 정수가 아닌 값이 입력되면 에러가 나며 컨버트(변환)에 실패할 것이다.
            
            *Comments 주석
                    Comments are explanatory statements that you can include in a program to benefit the reader of your code. 
                    The compiler ignores everything that appears in the comment, so none of that information affects the result. 
                    주석은 당신의 코드를 읽는 데에 도움을 주고자 프로그램에 포함하는 설명문이다.
                    컴파일러는 주석처리 된 것을 모두 무시하기 때문에 결과에 영향을 주지 않는다.

                    A comment beginning with two slashes (//) is called a single-line comment. The slashes tell the compiler to ignore everything that follows, until the end of the line. 
                    두개의 슬래쉬로 시작하는 주석을 싱글라인 주석이라 부른다. 슬래쉬는 컴파일러에게 이 다음에 오는 문장을 문장 끝까지 무시하라고 말해주는 것이다.

           *Multi-Line Comments 멀티라인 주석
                    Comments that require multiple lines begin with at the end of the comment block.                   
                    You can place them on the same line or insert one or more lines between them. 
                    멀티라인을 요구하는 주석은 코멘트 블록의 끝에서 시작한다.
                    같은 라인이나, 그 사이에 하나 이상의 라인을 삽입시키는 것에 위치시킬 수 있다.

           *The var Keyword -var 키워드
                    A variable can be explicitly declared with its type before it is used.
                    Alternatively, C# provides a handy function to enable the compiler to determine the type of the variable automatically based on the expression it is assigned to. 
                    변수는 사용되기 전에 그 타입을 명쾌하게 선언할 수 있다. 
                    그 대신, C#은 편리한 기능을 제공한다. (그 뒤가 너무 길음...)

           *The code above makes the compiler determine the type of the variable. Since the value assigned to the variable is an integer, the variable will be declared as an integer automatically.
           *  



             */


        }
    }
}
