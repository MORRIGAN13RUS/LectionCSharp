void FiillArray(int[] collection){
    int i=0;
    while(i<collection.Length){
        collection[i]=new Random().Next(1,100);
        i++;
    }
}
void PrintArray(int[]col){
    int i=0;
    while(i<col.Length){
        Console.WriteLine(col[i]);
        i++;
    }
}
int Indexof(int[] collection, int find){
    int i=0;
    int position=-1;
    while(i<collection.Length){
        if(collection[i]==find) position=i;
        break;
    i++;
}
return position;
}
int[]array=new int[10];
FiillArray(array);
PrintArray(array);
Console.WriteLine();
int pos=Indexof(array,4);
Console.WriteLine(pos);