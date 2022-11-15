using System.Collections.Generic;

int n = int.Parse(Console.ReadLine());
int count = 0;
HashSet<string> hash = new HashSet<string>();
for(int i = 0; i < n; i++){
    string s = Console.ReadLine();
    if (s != "ENTER")
       hash.Add(s);
    else{
        count+=hash.Count();
        hash.Clear();
    }
}

Console.WriteLine(count+=hash.Count());