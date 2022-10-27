using System.Text;
//A=고정비용, B=가변비용(1대 생산), A+B는 전체 비용
//C=노트북 가격

long[] inputs = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);

if(inputs[1]>=inputs[2]) Console.WriteLine("-1");
else{
//int i = 0; //판매량
    //inputs[0]+inputs[1]*i = inputs[2]*i
    //(inputs[0]/(inputs[2]-inputs[1]))+1=i
    //inputs[1]*i-inputs[2]*i >= inputs[0]
    //(inputs[1]-inputs[2])*i >= inputs[0]
    //i >= inputs[0]/(inputs[1]-inputs[2]);
    
    Console.WriteLine((inputs[0]/(inputs[2]-inputs[1]))+1);
}

