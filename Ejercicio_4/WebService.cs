using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
public class WebService : System.Web.Services.WebService {

    public WebService () {
    }

    [WebMethod]
    public string FibonacciRecursivo(int n){
        string serie = "Serie de Fibonacci Recursivo (n="+n.ToString()+"):  ";
        for (int i = 0; i < n-1; i++ ){
            serie = serie+" "+fiboLib.fibonacci.fiboRec(i).ToString()+" ";
        }
        return serie;
    }
    [WebMethod]
    public string Fibonacci(int n){
        string serie = "Serie de Fibonacci Estructurado (n="+n.ToString()+"):  ";
        for (int i = 0; i < n-1; i++ ){
            serie = serie+" "+fiboLib.fibonacci.fiboEst(i).ToString()+" ";
        }
        return serie;
    }
}