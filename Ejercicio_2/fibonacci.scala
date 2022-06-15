object Fibo {
    def fiboRecursivo(n: Int): Int = n match {
        case 0 => 0
        case 1 => 1
        case 2 => 1
        case _ => fiboRecursivo(n - 1) + fiboRecursivo(n - 2) + fiboRecursivo(n - 3)
    }
    def serie(n: Int):Unit = {
        for (i <- 0 to n-1){
            print(fiboRecursivo(i)+" ")
        }
    }
    def main(args:Array[String]):Unit = {
        print("Ingrese un numero: ")
        val a = scala.io.StdIn.readInt()
        println("Fibonacci Recursivo.")
        val SerieFibo = (n:Int)=> serie(n)        
        SerieFibo(a)
    }

}