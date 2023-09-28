int[] CreateRandomeArray(int min, int max, int size){
    int[] array = new int[size];
    for(int i = 0; i<size; i++){
        array[i]= new Random().Next(min,max +1);
    }
    return array;
}

void ShowArray(int[] array){
    for(int i = 0; i<array.Length; i++){
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void CalcPosNeg(int[]array){
    int sumPos=0;
    int sumNeg=0;
     for(int i = 0; i<array.Length; i++){
        if (array[i]<1){
            sumNeg+=array[i];
        }
        else{
            sumPos+=array[i];
        }
     }
         Console.WriteLine($"Summ of negative is {sumNeg} and summ positive is {sumPos}");
}


bool Is Present(int[] array, int num){
         for(int i = 0; i<array.Length; i++){
            if(array[i]== num){
                return true;
            }
            return false;
}



Console.WriteLine("Enter min of array value:  ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter max of array value:  ");
int max = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter size of array value:  ");
int size = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateRandomeArray(min, max, size);
ShowArray(newArray);
CalcPosNeg(newArray); 