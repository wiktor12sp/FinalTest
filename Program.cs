строка [] inputArray  = { " привет " , " 2 " , " мир " , " :-) " , " 1234 " , " 1567 " };

// Метод печати массива
строка  PrintArray ( строка [] inputArray )
{
    возвращаемая  строка . Присоединиться ( " , " , inputArray );
}

// Метод подсчета строк в массиве длиной меньше или равной 3 символам
int  CountStringInArray ( строка [] ввод )
{
    int  len  ​​=  inputArray . длина ;
     число  счетчиков =  0 ;
    интервал  maxLengthString  =  3 ;
    для ( int  i  =  0 ; я  <  len ; я ++ )
    {
        если ( inputArray [ i ]. Length  <=  maxLengthString )
        {
            считать ++ ;
        }
    }
     количество возвратов ;
}

// Метод для создания нового массива из строк, меньших или равных 3 символам, которые он находит во входном массиве
// ! передать результат метода CountStringInArray в аргумент countWords!
строка [] CreateNewArray ( строка [] inputArray , int  countWords )
{
    int  len  ​​=  inputArray . длина ;
    строка [] outputArray  =  новая  строка [ countWords ];
     число  счетчиков =  0 ;
    интервал  maxLengthString  =  3 ;
    для ( int  i  =  0 ; я  <  len ; я ++ )
    {
        если ( inputArray [ i ]. Length  <=  maxLengthString )
        {
            outputArray [ count ] =  inputArray [ i ];
            считать ++ ;
        }
    }

    вернуть  выходной массив ;
}

Массив печати ( входной массив );

string [] outputArray  =  CreateNewArray ( inputArray , CountStringInArray ( inputArray ));

Массив печати ( выходной массив );