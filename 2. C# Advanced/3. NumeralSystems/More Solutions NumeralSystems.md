## Още няколко интересни варианта на задачите
### Вариант на преобразуване на число от двоична в десетична бройна система
for (int i = 0; i < binary.Length; i++)
{
    if (binary[binary.Length - i - 1] == '0')
    {
        continue;
    }
    result +=(long) Math.Pow(2, i);
}
Console.WriteLine(result);

Теория за Floating Point Numbers [link](http://www.extremeoptimization.com/Resources/Articles/FPDotNetConceptsAndFormats.aspx#single)
 [link](https://csharp.2000things.com/tag/floating-point/page/2/)
