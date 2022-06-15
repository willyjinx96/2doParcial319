object Fibonacci{

  def FiboRecursivo(n: Int): Int = {
    if (n == 0) 0
    else if (n == 1) 0
    else if (n == 2) 1
    else FiboRecursivo(n-1) + FiboRecursivo(n-2)+FiboRecursivo(n-3)
  }

  def fsup(ftribR:(Int)=>Int):Unit={
    print("Introduzca un numero: ")
    val n=scala.io.StdIn.readInt()
    for (i <- 0 to n){
        print(ftribR(i) + " ")
    }
  }

  def main(args:Array[String]):Unit={    
    fsup(FiboRecursivo)
  } 

}