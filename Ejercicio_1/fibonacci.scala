object Fibonacci {

  private def formatFib(x:Int) = {
    for { i <- 0 to x-1 }
      print( fibonacci(i) + " ")
  }

  def fibonacci(n: Int): Int = {
    if ( n == 0 ) 0
    else if ( n == 1 ) 1
    else if (n == 2) 1
    else fibonacci( n-1 ) + fibonacci( n-2 ) + fibonacci(n-3)
  }

  def main(args: Array[String]): Unit =
    print ("Introduzca un numero: ")
    val a=scala.io.StdIn.readInt()    
    println(formatFib(a)) 
}