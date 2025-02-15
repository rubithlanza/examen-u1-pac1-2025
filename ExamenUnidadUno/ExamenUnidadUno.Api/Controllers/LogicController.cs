using System.Security.Cryptography.X509Certificates;
using Microsoft.AspNetCore.Mvc;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ExamenUnidadUno.Api.Controllers
{

    [ApiController]
    [Route("api/examen")]
    public class LogicController : ControllerBase
    {
        
        public LogicController()
        {

        }
        //Calculo de los numeros primos 
        [HttpGet("is-prime/{number}")]

        public ActionResult Prime(int number)
        {
            
            bool numberPrime = true;

            if (number <= 1)
            {
                numberPrime = false;
            }
            else
            {
                for (int i = 2; i <= Math.Sqrt(number); i++)
                {
                    if (number % i == 0)
                    {
                        numberPrime = false;
                        break;
                    }
                }
            }

            var result = new
            {
                number = number,
                numberPrime = numberPrime
            };

            return Ok(result);

            }
        //Factoriales 
        [HttpGet("factorial/{number}")]
        public ActionResult Factorial(int number) 
        {
            var factorial = 1;
            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }

            var result = new
            {
                number = number,
                factorial = factorial
            };


            return Ok(result);
        }
        ////Numeros fibonacci
        //[HttpGet("fibonacci/{limit}")]
        //public ActionResult Fibonacci()
        //{
        //    return Ok(Results);
        //}

        //Vocales con palabras 
        [HttpGet("count-vowels")]
        public ActionResult CountVowels(string text)
        {
            var vowelsCount = 0;

            vowelsCount = text.Length;
            var result = new
            {
                text = text,
                vowelsCount = vowelsCount
            };
            return Ok(result);
        }

        [HttpGet("is-polindrome/{word}")]
        public ActionResult Polindrome(string text) 
        {
            bool isPolindrome = true;
            if (string.IsNullOrEmpty(text)) 
            { 
                isPolindrome = false;
            }

            var result = new
            {
                text = text,
                isPolindrome = isPolindrome
            };
            return Ok(result);
        }


    }
}
