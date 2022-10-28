using System.Text;

StringBuilder sb = new StringBuilder();
int totalC = int.Parse(Console.ReadLine());
string[] str = Console.ReadLine().Split();
int[] criteria = new int[str.Length];
int totalS = int.Parse(Console.ReadLine());
string[] search = Console.ReadLine().Split();

for(int i = 0; i < str.Length; i++){
    criteria[i] = int.Parse(str[i]);
}

Array.Sort(criteria);

for(int i = 0; i<totalS; i++){
    int low = 0;
    int high = criteria.Length-1;
    bool found = false;
    
    while(low <= high && !found){
        int mid = (low+high)/2;
        
        if(criteria[mid]==int.Parse(search[i])) found = true;
        else if(criteria[mid]>int.Parse(search[i])) high = mid -1;
        else low = mid+1;
    }
    sb.Append(found?"1\n":"0\n");
}

Console.WriteLine(sb.ToString());