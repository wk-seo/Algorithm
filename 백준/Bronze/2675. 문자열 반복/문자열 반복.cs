using System.Text;

//[0]testCase t, StringBuilder sb
int t = int.Parse(Console.ReadLine());
StringBuilder sb = new StringBuilder();

//[1]input
for(int i = 0; i<t; i++){
    sb.Clear();
    string[] inputs = Console.ReadLine().Split();
    int r = int.Parse(inputs[0]);
    string s = inputs[1];
    
    //[2]Process
    for(int j = 0; j<s.Length; j++){
        for(int k = 0; k<r; k++){
            sb.Append(s[j]);
        }
    }
    //[3]Output
    Console.WriteLine(sb.ToString());
}
