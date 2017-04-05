namespace Arrays
{
    internal class ArraysAndStrings
    {
        public int CountCharInString(string inputString, char inputChar)
        {
            int result = 0;

            for (int i = 0; i < inputString.Length; i++)
            {
                if (inputChar == inputString[i])
                {
                    result += 1;
                }
            }

            //TODO: Escriba aquí el algoritmo para contar
            // las ocurrencias de inputChar en inputString

            return result;
        }

        public int NextPowerOfTwo(int currentNumber)
        {
            int result = 1;

            while(currentNumber < result)
            {
                result = result * 2;
            }

            return result;
        }

        public int FibonacciAtN(int fibonacciPositioon)
        {
            int result = 0;

            return result;
        }

        public int MultiplesOfThreeInArray(int[] inputArr)
        {
            int result = 0;

            for (int i = 0; i < inputArr.Length; i++)
            {
                if ((inputArr[i] % 3) == 0)
                {
                    result += 1;
                }
            }


            return result;
        }

        public bool NumberIsMultipleOf(int inputNum, int inputFactor)
        {
            bool result = false;

            if ( inputNum % inputFactor == 0)
            {
                result = true;
            }
            return result;
        }

        public bool MatrixIsIdentity(int[,] inputMatrix)
        {
            bool result = true;

            
                

            return result;
        }

        public bool ElementsInDiagonalAreEqual(int[,] inputMatrix)
        {
            bool result = false;

          
            return result;
        }

        public int OperateElementsInArray(int[] inputArr)
        {
            int result = 0;

            if (inputArr.Length > 1)
            {
                for (int i = 0; i < inputArr.Length; i++)
                {
                    result += inputArr[i];
                }

                for (int i = 1; i < inputArr.Length; i += 2)
                {
                    result = result * inputArr[i];
                }
            }

            return result;
        }

        public int CountVowelsInString(string inputString)
        {
            int result = 0;

            for (int i = 0; i < inputString.Length; i++)
            {
                if ((inputString[i] == 'a') || (inputString[i] == 'e') || (inputString[i] == 'i') || (inputString[i] == 'o') || (inputString[i] == 'u'))
                {
                    result += 1;
                   }
                }
            return result;
        }

        public int CountConsonantInString(string inputString)
        {
            int result = 0;

            for (int i = 0; i < inputString.Length; i++)
            {
                if ((inputString[i] != 'a') && (inputString[i] != 'e') && (inputString[i] != 'i') && (inputString[i] != 'o') && (inputString[i] != 'u'))
                {
                    result += 1;
                }
            }

            return result;
        }

        public string StringHasOddOrEvenCharCount(string inputString)
        {
            string result = string.Empty;

            if ((inputString.Length % 2) == 0)
            {
                result = "PAR";
            }else {
                result = "IMPAR";
            }
            

            //TODO: Para indicar que el conteo es par, retornar "PAR"
            //Para indicar que el conteo es inpar, retornar "IMPAR"

            return result;
        }

        public string ProductOfElementsIsOddOrEven(int[] inputArr)
        {
            string result = string.Empty;
            int producto = 1;

            for (int i = 0; i < inputArr.Length; i++)
            {
                producto = producto * inputArr[i];
            }

            if ((producto % 2) == 0)
            {
                result = "PAR";
            }else
            {
                result = "IMPAR";
            }
            //TODO: Para indicar que el conteo es par, retornar "PAR"
            //Para indicar que el conteo es inpar, retornar "IMPAR"

            return result;
        }

        public string RacerGotFirst(float d1, float t1, float d2, float t2)
        {
            string result = string.Empty;
			float v1 = 0.0f;
			float v2 = 0.0f;

			v1 = (d1 / t1);
			v2 = (d2 / t2);

			if (v1 > v2)
			{
				result = "PRIMERO";
			}
			else
			{
				result = "SEGUNDO";
			}
	
            //TODO: Para indicar que el corredor más rápido es el primero, retornar "PRIMERO"
            //Para indicar que el corredor más rápido es el segundo, retornar "SEGUNDO"

            return result;
        }
    }
}