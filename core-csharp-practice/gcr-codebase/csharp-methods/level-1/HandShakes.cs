using System;
class HandShakes{
    static void Main(){
        int n=int.Parse(Console.ReadLine());
        hand(n);
    }
    static void hand(int n){
        int handshakes=(n*(n-1))/2;
        Console.WriteLine("The number of handshakes possible are "+handshakes);
    }
}