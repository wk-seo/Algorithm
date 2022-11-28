using System.Collections.Generic;

int n = int.Parse(Console.ReadLine());
int[] counts = new int[n+1];
counts[0] = 0;
List<int> temp = new List<int>();

for(int i = 1; i <= n; i++){
    if(i == 1) counts[i] = 0;
    else if(i == 2 || i == 3) counts[i] = 1;
    else{
        temp.Clear();
        if(i % 3 == 0) temp.Add(i/3);
        if(i % 2 == 0) temp.Add(i/2);
        temp.Add(i-1);
        int min = 100;
        for(int j = 0; j < temp.Count; j++){
            if(min>counts[temp[j]])
                min = counts[temp[j]];
        }
        counts[i] = min + 1;
    }
}

Console.WriteLine(counts[n]);