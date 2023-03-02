class program {
    static void Main(string[] args) {
        int id = Convert.ToInt32(Console.ReadLine());
        String name = Console.ReadLine();
        int count = 0;
        int n=10;
        for(int i=0;i<6;i++){
            if((id/n)%10 == 7){
                count++;
            }
            n=n*10;
        }
        if(name == "CIA"){
            if((id%10)%3 == 0 
            && (id/10)%10 !=1 && (id/10)%10 !=3 && (id/10)%10 !=5
            && (id/1000)%10 >=6 && (id/1000)%10 != 8){
                Console.WriteLine("True");
            }else{
                Console.WriteLine("False");
            }
        }else if(name == "FBI"){
            if((((id/100)%10)%2 == 0 && (id/100)%10 != 6)
            && (((id/10000)%10)%2 != 0)
            && ((id/100000)%10 >=4 && (id/100000)%10 <=7 )){
                Console.WriteLine("True");
            }else{
                Console.WriteLine("False");
            }
        }else if(name == "NSA"){
            if(30%(id%10)==0
            && ((id/100)%10)%2 != 0
            && count>=1){
                Console.WriteLine("True");
            }else{
                Console.WriteLine("False");
            }
        }else{
            Console.WriteLine("False");
        }
    }

}
   