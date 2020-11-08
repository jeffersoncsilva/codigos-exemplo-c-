using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversao_de_Tipos
{
    class Program
    {
        static void Main(string[] args)
        {
            //ConverterToByte();
            //CastingDeInteirosProblematicos();
            //ErroDivisao();
            //CastingDeStrings();
            //SaidasFormatadas();
            //CastingTryParseTiposPrincipais();
            //ErroPontoFlutuante();
            Console.ReadLine();
        }

        static void ErroPontoFlutuante()
        {
            int numero_iteracoes = 1;
            Console.WriteLine("Primeiro laço, usando o tipo float :");

            // executa somente 4 vezes e não 5 como esperado
            for (float d = 1.1f; d <= 3f; d += 0.1f)
            {
                Console.WriteLine("Iteração #: {0}, valor float : {1}", numero_iteracoes++, d.ToString("e10"));
            }

            Console.WriteLine("\r\nSegundo laço, usando o tipo Decimal :");
            // reseta o contador
            numero_iteracoes = 1;

            // executa corretamente para 5 interações
            for (Decimal d = 1.1m; d <= 3m; d += 0.1m)
            {
                Console.WriteLine("Iteração #: {0}, valor Decimal : {1}", numero_iteracoes++, d.ToString("e10"));
            }
        }

        static void CastingTryParseTiposPrincipais()
        {
            if(int.TryParse("3456", out int res))
            {
                Console.WriteLine("Convertido com sucesso: {0}", res);
            }
            if(int.TryParse("333333333333333333", out int res2))
            {
                Console.WriteLine("Não convertido.");
            }else
                Console.WriteLine("Conversão falhada.");

            int ii1 = int.Parse("345");
            //int ii2 = int.Parse("345f"); // FormatException

            if(double.TryParse("55.69", out double dd))
            {
                Console.WriteLine("Convertido com sucesso.");
            }

            if(double.TryParse("55555555555555555555555555555555555555555555555555555.55555555555555555555555555555555555555555", out double d2))
            {
                Console.WriteLine("não funciona.");
            }else
                Console.WriteLine("Conversão falhada.");

            double doub = double.Parse("45679.5454");
            //double doub2 = double.Parse("32455.2345ffds");//FormatException


            if(decimal.TryParse("56464.5454", out decimal dec))
            {
                Console.WriteLine("Convertido com sucesso.");
            }

            if (decimal.TryParse("55555555555555555555555555555555555555555555555555555.55555555555555555555555555555555555555555", out decimal dec2))
            {
                Console.WriteLine("Convertido com sucesso.");
            }
            else
                Console.WriteLine("Conversão falhada.");
            decimal dec3 = decimal.Parse("34235.546");
            //decimal dec4 = decimal.Parse("23452435kj"); // FormatException
        }

        static void SaidasFormatadas()
        {
            Console.WriteLine("The value 99999 in various formats:");
            Console.WriteLine("Formato moeda: {0:c}", 1024);
            Console.WriteLine("Definido casas decimais minimas: {0:d9}", 123);
            Console.WriteLine("Casas decimais definidas: {0:f2}", 99.5256);
            Console.WriteLine("Formato notação real: {0:n}", 2048);
            Console.WriteLine("Notação expoente maiusculo: {0:E}", 8795);
            Console.WriteLine("Notação expoente minusculo: {0:e}", 99999);
            Console.WriteLine("Hexa maiousculo: {0:X}", 12);
            Console.WriteLine("Hexa minusculo: {0:x}", 15);
        }

        static void CastingDeStrings()
        {
            sbyte ss = Convert.ToSByte("-123");
            Console.WriteLine("res: {0} -- sbyte: {1}", sbyte.TryParse("-123", out sbyte s1), s1);
            Console.WriteLine("res: {0} -- sbyte: {1}", sbyte.TryParse("-258", out sbyte s2), s2);
            sbyte sb1 = sbyte.Parse("123");
            //sbyte sss = Convert.ToSByte("128"); // OverflowExeption



            byte bb = Convert.ToByte("254");
            Console.WriteLine("res: {0} -- byte: {1}", byte.TryParse("250", out byte b), b);
            Console.WriteLine("res: {0} -- byte: {1}", byte.TryParse("259", out byte b2), b2);
            byte bb2 = byte.Parse("233");


            short sshort = Convert.ToInt16("-512");
            Console.WriteLine("res: {0} -- short: {1}", short.TryParse("-512", out short s3), s3);
            Console.WriteLine("res: {0} -- short: {1}", short.TryParse("256", out short s4), s4);
            Console.WriteLine("res: {0} -- short: {1}", short.TryParse("-32769", out short s5), s5);
            Console.WriteLine("res: {0} -- short: {1}", short.TryParse("32769", out short s6), s6);
            short sshort2 = short.Parse("345");


            ushort uushort = Convert.ToUInt16("1024");
            Console.WriteLine("res: {0} -- short: {1}", ushort.TryParse("1025", out ushort u1), u1);
            Console.WriteLine("res: {0} -- short: {1}", ushort.TryParse("-58", out ushort u2), u2);
            Console.WriteLine("res: {0} -- short: {1}", ushort.TryParse("65536", out ushort u3), u3);
            ushort uushort2 = ushort.Parse("2048");


            int ii = Convert.ToInt32("3356");
            Console.WriteLine("res: {0} -- int: {1}", int.TryParse("-2147483645", out int i1), i1);
            Console.WriteLine("res: {0} -- int: {1}", int.TryParse("2147483", out int i2), i2);
            Console.WriteLine("res: {0} -- int: {1}", int.TryParse("2147483648", out int i3), i3);
            int ii2 = int.Parse("51454654");


            uint uii = Convert.ToUInt32("3356");
            Console.WriteLine("res: {0} -- int: {1}", uint.TryParse("-4147483645", out uint ui1), ui1);
            Console.WriteLine("res: {0} -- int: {1}", uint.TryParse("4144521481", out uint ui2), ui2);
            Console.WriteLine("res: {0} -- int: {1}", uint.TryParse("2147483648", out uint ui3), ui3);
            uint uii2 = uint.Parse("2547896");


            long ll = Convert.ToInt64("3356");
            Console.WriteLine("res: {0} -- int: {1}", long.TryParse("-4147483645", out long l1), l1);
            Console.WriteLine("res: {0} -- int: {1}", long.TryParse("4144521481", out long l2), l2);
            Console.WriteLine("res: {0} -- int: {1}", long.TryParse("2147483648", out long l3), l3);
            long ll2 = long.Parse("147852369123");


            ulong ull = Convert.ToUInt64("3356");
            Console.WriteLine("res: {0} -- int: {1}", ulong.TryParse("-598632547852", out ulong ul1), ul1);
            Console.WriteLine("res: {0} -- int: {1}", ulong.TryParse("2658963542569", out ulong ul2), ul2);
            Console.WriteLine("res: {0} -- int: {1}", ulong.TryParse("5487965477895", out ulong ul3), ul3);
            ulong ull2 = ulong.Parse("123456789963");

            Console.WriteLine("res: {0} -- int: {1}", float.TryParse("-521.235.255", out float f1), f1);
            Console.WriteLine("res: {0} -- int: {1}", float.TryParse("235.698.258", out float f2), f2);
            Console.WriteLine("res: {0} -- int: {1}", float.TryParse("236.569.854.258", out float f3), f3);

            double dd = Convert.ToDouble("345512343124");
            Console.WriteLine("res: {0} -- int: {1:0,00}", double.TryParse("-521.235.255", out double d1), d1);
            Console.WriteLine("res: {0} -- int: {1:0,00}", double.TryParse("235.698.258", out double d2), d2);
            Console.WriteLine("res: {0} -- int: {1:0,00}", double.TryParse("236.569.854.258", out double d3), d3);
            double double2 = double.Parse("147852369.569874");
            Console.WriteLine("dd2: {0}", double2);


            decimal de = Convert.ToDecimal("345512343124");
            Console.WriteLine("res: {0} -- int: {1:0,00}", decimal.TryParse("-521.235.255", out decimal dd1), dd1);
            Console.WriteLine("res: {0} -- int: {1:0,00}", decimal.TryParse("235.698.258", out decimal dd2), dd2);
            Console.WriteLine("res: {0} -- int: {1:0,00}", decimal.TryParse("236.569.854.258", out decimal dd3), dd3);
            decimal dd4 = decimal.Parse("7539512486.4568");
            Console.WriteLine("dd4: {0}", dd4);
        }

        static void ErroDivisao()
        {
            int a = 100;
            float b = a / 3;
            Console.WriteLine("b: {0}", b.ToString());
            float bb = b + b + b;
            Console.WriteLine("bb: {0:f21}", bb.ToString());
            // Como "corrigir"
            float ff = 100;
            float res = ff / 3f;
            Console.WriteLine("\nres: {0}", res.ToString());
            float soma = res + res + res;
            Console.WriteLine("soma: {0}", soma.ToString());
        }

        static void CastingDeInteirosProblematicos()
        {
            sbyte ss = -5;
            byte bb = (byte)ss;
            Console.WriteLine("\n\nss: {0} - bb: {1}", ss, bb);
            int ii = -1;
            uint uu = (uint)ii;
            Console.WriteLine("\n\nii: {0} -- uu: {1}", ii, uu);
            long ll = -345;
            ulong ul = (ulong)ll;
            Console.WriteLine("\n\nll: {0} -- ul: {1}", ll, ul);
        }

        #region Casting_gerais

        static void ConvertToDecimal()
        {
            float _float;
            double _double;
            decimal _decimal;
            object _object;
        }

        static void ConvertToDouble()
        {
            double _double;
            decimal _decimal;
            object _object;

            _decimal = 39.8m;
            _double = (double)_decimal;
            Console.WriteLine("_decimal: {0} - _byte: {1} ", _decimal, _double);

            _decimal = 39.2m;
            _double = (double)_decimal;
            Console.WriteLine("_decimal: {0} - _byte: {1} ", _decimal, _double);


            _object = 39.4444445;
            _double = (double)_object;
            Console.WriteLine("_decimal: {0} - _byte: {1}", _object, _double);
            _object = 39.5;
            _double = (double)_object;
            Console.WriteLine("_decimal: {0} - _byte: {1} ", _object, _double);
            _object = 39.6;
            _double = (double)_object;
            Console.WriteLine("_decimal: {0} - _byte: {1} ", _object, _double);
            Console.WriteLine("type: {0}", _object.GetType());

            _double = Convert.ToDouble(_object);
            Console.WriteLine("_decimal: {0} - _byte: {1} Convert.ToDouble()", _object, _double);
        }
    
        static void ConvertToFloat()
        {
            float _float;
            double _double;
            decimal _decimal;
            object _object;

            _double = 39.2f;
            _float = (float)_double;
            Console.WriteLine("_double: {0} - _byte: {1} ", _double, _float);

            _double = 39.8f;
            _float = (float)_double;
            Console.WriteLine("_double: {0} - _byte: {1} ", _double, _float);



            _decimal = 39.8m;
            _float = (float)_decimal;
            Console.WriteLine("_decimal: {0} - _byte: {1} ", _decimal, _float);

            _decimal = 39.2m;
            _float = (float)_decimal;
            Console.WriteLine("_decimal: {0} - _byte: {1} ", _decimal, _float);


            _object = 39.4444445;
            _float = (float)_object;
            Console.WriteLine("_decimal: {0} - _byte: {1} ", _object, _float);
            _object = 39.5;
            _float = (float)_object;
            Console.WriteLine("_decimal: {0} - _byte: {1} ", _object, _float);
            _object = 39.6;
            _float = (float)_object;
            Console.WriteLine("_decimal: {0} - _byte: {1} ", _object, _float);
            Console.WriteLine("type: {0}", _object.GetType());

           
        }

        static void ConvertToULong()
        {
            ulong _ulong;
            float _float;
            double _double;
            decimal _decimal;
            object _object;

            _float = 21456984265f;
            _ulong = (ulong)_float;
            Console.WriteLine("_float: {0} - _byte: {1}", _float, _ulong);

            _float = -21456984f;
            _ulong = (ulong)_float;
            Console.WriteLine("_float: {0} - _byte: {1}", _float, _ulong);

            _float = 39.2f;
            _ulong = Convert.ToUInt64(_float);
            Console.WriteLine("_float: {0} - _byte: {1} Convert.ToUInt64()", _float, _ulong);

            _float = 39.6f;
            _ulong = Convert.ToUInt64(_float);
            Console.WriteLine("_float: {0} - _byte: {1} Convert.ToUInt64()", _float, _ulong);

            _double = 39.6f;
            _ulong = Convert.ToUInt64(_double);
            Console.WriteLine("_double: {0} - _byte: {1} Convert.ToUInt64()", _double, _ulong);

            _double = 39.2f;
            _ulong = Convert.ToUInt64(_double);
            Console.WriteLine("_double: {0} - _byte: {1} Convert.ToUInt64()", _double, _ulong);

            _double = 39.2f;
            _ulong = (ulong)_double;
            Console.WriteLine("_double: {0} - _byte: {1} ", _double, _ulong);

            _double = 39.8f;
            _ulong = (ulong)_double;
            Console.WriteLine("_double: {0} - _byte: {1} ", _double, _ulong);



            _decimal = 39.8m;
            _ulong = (ulong)_decimal;
            Console.WriteLine("_decimal: {0} - _byte: {1} ", _decimal, _ulong);

            _decimal = 39.2m;
            _ulong = (ulong)_decimal;
            Console.WriteLine("_decimal: {0} - _byte: {1} ", _decimal, _ulong);

            _decimal = 39.2m;
            _ulong = Convert.ToUInt64(_decimal);
            Console.WriteLine("_decimal: {0} - _byte: {1} Convert.ToUInt64()", _decimal, _ulong);

            _decimal = 39.4444445m;
            _ulong = Convert.ToUInt64(_decimal);
            Console.WriteLine("_decimal: {0} - _byte: {1} Convert.ToUInt64()", _decimal, _ulong);

            _object = 39.4444445;
            _ulong = Convert.ToUInt64(_object);
            Console.WriteLine("_decimal: {0} - _byte: {1} Convert.ToUInt64()", _object, _ulong);
            _object = 39.5;
            _ulong = Convert.ToUInt64(_object);
            Console.WriteLine("_decimal: {0} - _byte: {1} Convert.ToUInt64()", _object, _ulong);
            _object = 39.6;
            _ulong = Convert.ToUInt64(_object);
            Console.WriteLine("_decimal: {0} - _byte: {1} Convert.ToUInt64()", _object, _ulong);
            Console.WriteLine("type: {0}", _object.GetType());

            _object = 39.4444445;
            _ulong = Convert.ToUInt64(_object);
            Console.WriteLine("_decimal: {0} - _byte: {1} Convert.ToUInt64()", _object, _ulong);
            _object = 39.5;
            _ulong = Convert.ToUInt64(_object);
            Console.WriteLine("_decimal: {0} - _byte: {1} Convert.ToUInt64()", _object, _ulong);
            _object = 39.6;
            _ulong = Convert.ToUInt64(_object);
            Console.WriteLine("_decimal: {0} - _byte: {1} Convert.ToUInt64()", _object, _ulong);
            Console.WriteLine("type: {0}", _object.GetType());

            _ulong = (ulong)_object;
            Console.WriteLine("_decimal: {0} - _byte: {1} ", _object, _ulong);
        }

        static void ConvertToLong()
        {
            long _long;
            ulong _ulong;
            float _float;
            double _double;
            decimal _decimal;
            object _object;

            _ulong = 12L;
            _long = Convert.ToUInt32(_ulong);
            Console.WriteLine("_ulong: {0} - _byte: {1} Convert.ToUInt32()", _ulong, _long);

            _ulong = 120L;
            _long = (long)_ulong;
            Console.WriteLine("_ulong: {0} - _byte: {1}", _ulong, _long);

            _ulong = 21456984268465L;
            _long = (long)_ulong;
            Console.WriteLine("_ulong: {0} - _byte: {1}", _ulong, _long);

            _float = 21456984265f;
            _long = (long)_float;
            Console.WriteLine("_float: {0} - _byte: {1}", _float, _long);

            _float = -21456984f;
            _long = (long)_float;
            Console.WriteLine("_float: {0} - _byte: {1}", _float, _long);

            _float = 39.2f;
            _long = Convert.ToInt64(_float);
            Console.WriteLine("_float: {0} - _byte: {1} Convert.ToInt64()", _float, _long);

            _float = 39.6f;
            _long = Convert.ToInt64(_float);
            Console.WriteLine("_float: {0} - _byte: {1} Convert.ToInt64()", _float, _long);

            _double = 39.6f;
            _long = Convert.ToInt64(_double);
            Console.WriteLine("_double: {0} - _byte: {1} Convert.ToInt64()", _double, _long);

            _double = 39.2f;
            _long = Convert.ToInt64(_double);
            Console.WriteLine("_double: {0} - _byte: {1} Convert.ToInt64()", _double, _long);

            _double = 39.2f;
            _long = (long)_double;
            Console.WriteLine("_double: {0} - _byte: {1} ", _double, _long);

            _double = 39.8f;
            _long = (long)_double;
            Console.WriteLine("_double: {0} - _byte: {1} ", _double, _long);



            _decimal = 39.8m;
            _long = (long)_decimal;
            Console.WriteLine("_decimal: {0} - _byte: {1} ", _decimal, _long);

            _decimal = 39.2m;
            _long = (long)_decimal;
            Console.WriteLine("_decimal: {0} - _byte: {1} ", _decimal, _long);

            _decimal = 39.2m;
            _long = Convert.ToInt64(_decimal);
            Console.WriteLine("_decimal: {0} - _byte: {1} Convert.ToInt64()", _decimal, _long);

            _decimal = 39.4444445m;
            _long = Convert.ToInt64(_decimal);
            Console.WriteLine("_decimal: {0} - _byte: {1} Convert.ToInt64()", _decimal, _long);

            _object = 39.4444445;
            _long = Convert.ToInt64(_object);
            Console.WriteLine("_decimal: {0} - _byte: {1} Convert.ToInt64()", _object, _long);
            _object = 39.5;
            _long = Convert.ToInt64(_object);
            Console.WriteLine("_decimal: {0} - _byte: {1} Convert.ToInt64()", _object, _long);
            _object = 39.6;
            _long = Convert.ToInt64(_object);
            Console.WriteLine("_decimal: {0} - _byte: {1} Convert.ToInt64()", _object, _long);
            Console.WriteLine("type: {0}", _object.GetType());

            _long = (long)_object;
            Console.WriteLine("_decimal: {0} - _byte: {1} ", _object, _long);
        }

        static void ConvertToUInt()
        {
            uint _uint;
            long _long;
            ulong _ulong;
            float _float;
            double _double;
            decimal _decimal;
            object _object;

            _long = 12L;
            _uint = Convert.ToUInt32(_long);
            Console.WriteLine("_long: {0} - _byte: {1} Convert.ToUInt32()", _long, _uint);

            _long = 120L;
            _uint = (uint)_long;
            Console.WriteLine("_long: {0} - _byte: {1} ", _long, _uint);

            _ulong = 12L;
            _uint = Convert.ToUInt32(_ulong);
            Console.WriteLine("_ulong: {0} - _byte: {1} Convert.ToUInt32()", _ulong, _uint);

            _ulong = 120L;
            _uint = (uint)_ulong;
            Console.WriteLine("_ulong: {0} - _byte: {1}", _ulong, _uint);

            _ulong = 21456984268465L;
            _uint = (uint)_ulong;
            Console.WriteLine("_ulong: {0} - _byte: {1}", _ulong, _uint);

            _float = 21456984265f;
            _uint = (uint)_float;
            Console.WriteLine("_float: {0} - _byte: {1}", _float, _uint);

            _float = -21456984f;
            _uint = (uint)_float;
            Console.WriteLine("_float: {0} - _byte: {1}", _float, _uint);

            _float = 39.2f;
            _uint = Convert.ToUInt32(_float);
            Console.WriteLine("_float: {0} - _byte: {1} Convert.ToUInt32()", _float, _uint);

            _float = 39.6f;
            _uint = Convert.ToUInt32(_float);
            Console.WriteLine("_float: {0} - _byte: {1} Convert.ToUInt32()", _float, _uint);

            _double = 39.6f;
            _uint = Convert.ToUInt32(_double);
            Console.WriteLine("_double: {0} - _byte: {1} Convert.ToUInt32()", _double, _uint);

            _double = 39.2f;
            _uint = Convert.ToUInt32(_double);
            Console.WriteLine("_double: {0} - _byte: {1} Convert.ToUInt32()", _double, _uint);

            _double = 39.2f;
            _uint = (uint)_double;
            Console.WriteLine("_double: {0} - _byte: {1} ", _double, _uint);

            _double = 39.8f;
            _uint = (uint)_double;
            Console.WriteLine("_double: {0} - _byte: {1} ", _double, _uint);



            _decimal = 39.8m;
            _uint = (uint)_decimal;
            Console.WriteLine("_decimal: {0} - _byte: {1} ", _decimal, _uint);

            _decimal = 39.2m;
            _uint = (uint)_decimal;
            Console.WriteLine("_decimal: {0} - _byte: {1} ", _decimal, _uint);

            _decimal = 39.2m;
            _uint = Convert.ToUInt32(_decimal);
            Console.WriteLine("_decimal: {0} - _byte: {1} Convert.ToUInt32()", _decimal, _uint);

            _decimal = 39.4444445m;
            _uint = Convert.ToUInt32(_decimal);
            Console.WriteLine("_decimal: {0} - _byte: {1} Convert.ToUInt32()", _decimal, _uint);

            _object = 39.4444445;
            _uint = Convert.ToUInt32(_object);
            Console.WriteLine("_decimal: {0} - _byte: {1} Convert.ToUInt32()", _object, _uint);
            _object = 39.5;
            _uint = Convert.ToUInt32(_object);
            Console.WriteLine("_decimal: {0} - _byte: {1} Convert.ToUInt32()", _object, _uint);
            _object = 39.6;
            _uint = Convert.ToUInt32(_object);
            Console.WriteLine("_decimal: {0} - _byte: {1} Convert.ToUInt32()", _object, _uint);
            Console.WriteLine("type: {0}", _object.GetType());

            _uint = (uint)_object;
            Console.WriteLine("_decimal: {0} - _byte: {1}", _object, _uint);
        }

        static void ConvertToInt()
        {   
            int _int;
            uint _uint;
            long _long;
            ulong _ulong;
            float _float;
            double _double;
            decimal _decimal;
            object _object;

            _uint = 548215658;
            _int = (int)_uint;
            Console.WriteLine("_int: {0} - _byte: {1} ", _uint, _int);

            _uint = 123;
            _int = (int)_uint;
            Console.WriteLine("_int: {0} - _byte: {1} ", _uint, _int);

            _uint = 12;
            _int = Convert.ToInt32(_uint);
            Console.WriteLine("_int: {0} - _byte: {1} ", _uint, _int);


            _long = 12L;
            _int = Convert.ToInt32(_long);
            Console.WriteLine("_long: {0} - _byte: {1} Convert.ToInt32()", _long, _int);

            _long = 120L;
            _int = (int)_long;
            Console.WriteLine("_long: {0} - _byte: {1} ", _long, _int);

            _ulong = 12L;
            _int = Convert.ToInt32(_ulong);
            Console.WriteLine("_ulong: {0} - _byte: {1} Convert.ToInt32()", _ulong, _int);

            _ulong = 120L;
            _int = (int)_ulong;
            Console.WriteLine("_ulong: {0} - _byte: {1}", _ulong, _int);

            _ulong = 21456984268465L;
            _int = (int)_ulong;
            Console.WriteLine("_ulong: {0} - _byte: {1}", _ulong, _int);

            _float = 21456984265f;
            _int = (int)_float;
            Console.WriteLine("_float: {0} - _byte: {1}", _float, _int);

            _float = -21456984f;
            _int = (int)_float;
            Console.WriteLine("_float: {0} - _byte: {1}", _float, _int);

            _float = 39.2f;
            _int = Convert.ToInt32(_float);
            Console.WriteLine("_float: {0} - _byte: {1} Convert.ToInt32()", _float, _int);

            _float = 39.6f;
            _int = Convert.ToInt32(_float);
            Console.WriteLine("_float: {0} - _byte: {1} Convert.ToInt32()", _float, _int);

            _double = 39.6f;
            _int = Convert.ToInt32(_double);
            Console.WriteLine("_double: {0} - _byte: {1} Convert.ToInt32()", _double, _int);

            _double = 39.2f;
            _int = Convert.ToInt32(_double);
            Console.WriteLine("_double: {0} - _byte: {1} Convert.ToInt32()", _double, _int);

            _double = 39.2f;
            _int = (int)_double;
            Console.WriteLine("_double: {0} - _byte: {1} ", _double, _int);

            _double = 39.8f;
            _int = (int)_double;
            Console.WriteLine("_double: {0} - _byte: {1} ", _double, _int);



            _decimal = 39.8m;
            _int = (int)_decimal;
            Console.WriteLine("_decimal: {0} - _byte: {1} ", _decimal, _int);

            _decimal = 39.2m;
            _int = (int)_decimal;
            Console.WriteLine("_decimal: {0} - _byte: {1} ", _decimal, _int);

            _decimal = 39.2m;
            _int = Convert.ToInt32(_decimal);
            Console.WriteLine("_decimal: {0} - _byte: {1} Convert.ToInt32()", _decimal, _int);

            _decimal = 39.4444445m;
            _int = Convert.ToInt32(_decimal);
            Console.WriteLine("_decimal: {0} - _byte: {1} Convert.ToInt32()", _decimal, _int);

            _object = 39.4444445;
            _int = Convert.ToInt32(_object);
            Console.WriteLine("_decimal: {0} - _byte: {1} Convert.ToInt32()", _object, _int);
            _object = 39.5;
            _int = Convert.ToInt32(_object);
            Console.WriteLine("_decimal: {0} - _byte: {1} Convert.ToInt32()", _object, _int);
            _object = 39.6;
            _int = Convert.ToInt32(_object);
            Console.WriteLine("_decimal: {0} - _byte: {1} Convert.ToInt32()", _object, _int);
            Console.WriteLine("type: {0}", _object.GetType());

            _int = (int)_object;
            Console.WriteLine("_decimal: {0} - _byte: {1} Convert.ToInt32()", _object, _int);
        }

        static void ConvertToUShort()
        {
            ushort _ushort;
            int _int;
            uint _uint;
            long _long;
            ulong _ulong;
            char _char;
            float _float;
            double _double;
            decimal _decimal;
            object _object;

            _int = 33;
            _ushort = (ushort)_int;
            Console.WriteLine("_int: {0} - _byte: {1} ", _int, _ushort);

            _int = -128;
            _ushort = (ushort)_int;
            Console.WriteLine("_int: {0} - _byte: {1} ", _int, _ushort);

            _int = -548215658;
            _ushort = (ushort)_int;
            Console.WriteLine("_int: {0} - _byte: {1} ", _int, _ushort);

            _int = 548215658;
            _ushort = (ushort)_int;
            Console.WriteLine("_int: {0} - _byte: {1} ", _int, _ushort);

            _uint = 548215658;
            _ushort = (ushort)_uint;
            Console.WriteLine("_int: {0} - _byte: {1} ", _uint, _ushort);

            _uint = 123;
            _ushort = (ushort)_uint;
            Console.WriteLine("_int: {0} - _byte: {1} ", _uint, _ushort);

            _uint = 12;
            _ushort = Convert.ToUInt16(_uint);
            Console.WriteLine("_int: {0} - _byte: {1} Convert.ToUINt16()", _uint, _ushort);


            _long = 12L;
            _ushort = Convert.ToUInt16(_long);
            Console.WriteLine("_long: {0} - _byte: {1} Convert.ToUInt16()", _long, _ushort);

            _long = 120L;
            _ushort = (ushort)_long;
            Console.WriteLine("_long: {0} - _byte: {1} ", _long, _ushort);

            _ulong = 12L;
            _ushort = Convert.ToUInt16(_ulong);
            Console.WriteLine("_ulong: {0} - _byte: {1} Convert.ToUInt16()", _ulong, _ushort);

            _ulong = 120L;
            _ushort = (ushort)_ulong;
            Console.WriteLine("_ulong: {0} - _byte: {1}", _ulong, _ushort);

            _ulong = 21456984268465L;
            _ushort = (ushort)_ulong;
            Console.WriteLine("_ulong: {0} - _byte: {1}", _ulong, _ushort);

            _float = 21456984265f;
            _ushort = (ushort)_float;
            Console.WriteLine("_float: {0} - _byte: {1}", _float, _ushort);

            _float = -21456984f;
            _ushort = (ushort)_float;
            Console.WriteLine("_float: {0} - _byte: {1}", _float, _ushort);

            _float = 39.2f;
            _ushort = Convert.ToUInt16(_float);
            Console.WriteLine("_float: {0} - _byte: {1} Convert.ToUInt16()", _float, _ushort);

            _float = 39.6f;
            _ushort = Convert.ToUInt16(_float);
            Console.WriteLine("_float: {0} - _byte: {1} Convert.ToUInt16()", _float, _ushort);

            _double = 39.6f;
            _ushort = Convert.ToUInt16(_double);
            Console.WriteLine("_double: {0} - _byte: {1} Convert.ToUInt16()", _double, _ushort);

            _double = 39.2f;
            _ushort = Convert.ToUInt16(_double);
            Console.WriteLine("_double: {0} - _byte: {1} Convert.ToUInt16()", _double, _ushort);

            _double = 39.2f;
            _ushort = (ushort)_double;
            Console.WriteLine("_double: {0} - _byte: {1} ", _double, _ushort);

            _double = 39.8f;
            _ushort = (ushort)_double;
            Console.WriteLine("_double: {0} - _byte: {1} ", _double, _ushort);



            _decimal = 39.8m;
            _ushort = (ushort)_decimal;
            Console.WriteLine("_decimal: {0} - _byte: {1} ", _decimal, _ushort);

            _decimal = 39.2m;
            _ushort = (ushort)_decimal;
            Console.WriteLine("_decimal: {0} - _byte: {1} ", _decimal, _ushort);

            _decimal = 39.2m;
            _ushort = Convert.ToUInt16(_decimal);
            Console.WriteLine("_decimal: {0} - _byte: {1} Convert.ToUInt16()", _decimal, _ushort);

            _decimal = 39.4444445m;
            _ushort = Convert.ToUInt16(_decimal);
            Console.WriteLine("_decimal: {0} - _byte: {1} Convert.ToUInt16()", _decimal, _ushort);

            _object = 39.4444445;
            _ushort = Convert.ToUInt16(_object);
            Console.WriteLine("_decimal: {0} - _byte: {1} Convert.ToUInt16()", _object, _ushort);
            _object = 39.5;
            _ushort = Convert.ToUInt16(_object);
            Console.WriteLine("_decimal: {0} - _byte: {1} Convert.ToUInt16()", _object, _ushort);
            _object = 39.6;
            _ushort = Convert.ToUInt16(_object);
            Console.WriteLine("_decimal: {0} - _byte: {1} Convert.ToUInt16()", _object, _ushort);
            Console.WriteLine("type: {0}", _object.GetType());
        }

        static void ConvertToShort()
        {
            short _short;
            ushort _ushort;
            int _int;
            uint _uint;
            long _long;
            ulong _ulong;
            char _char;
            float _float;
            double _double;
            decimal _decimal;
            object _object;

            Console.WriteLine("\n\n_ushort ======>>>>> _byte: ");
            _ushort = 2334;
            _short = (short)_ushort;
            Console.WriteLine("_ushort: {0} - _byte: {1}", _ushort, _short);

            _ushort = 125;
            _short = (short)_ushort;
            Console.WriteLine("_ushort: {0} - _byte: {1}", _ushort, _short);

            _ushort = 25;
            _short = Convert.ToInt16(_ushort);
            Console.WriteLine("_ushort: {0} - _byte: {1} (Convert.ToInt16())", _ushort, _short);

            //_ushort = 2005;
            //_byte = Convert.ToByte(_ushort); // OverflowException
            //Console.WriteLine("_ushort: {0} - _byte: {1} (Convert.ToInt16())", _ushort, _short);

            _int = 33;
            _short = (short)_int;
            Console.WriteLine("_int: {0} - _byte: {1} ", _int, _short);

            _int = -128;
            _short = (short)_int;
            Console.WriteLine("_int: {0} - _byte: {1} ", _int, _short);

            _int = -548215658;
            _short = (short)_int;
            Console.WriteLine("_int: {0} - _byte: {1} ", _int, _short);

            _int = 548215658;
            _short = (short)_int;
            Console.WriteLine("_int: {0} - _byte: {1} ", _int, _short);

            _uint = 548215658;
            _short = (short)_uint;
            Console.WriteLine("_int: {0} - _byte: {1} ", _uint, _short);

            _uint = 123;
            _short = (short)_uint;
            Console.WriteLine("_int: {0} - _byte: {1} ", _uint, _short);

            _uint = 12;
            _short = Convert.ToInt16(_uint);
            Console.WriteLine("_int: {0} - _byte: {1} Convert.ToInt16()", _uint, _short);


            _long = 12L;
            _short = Convert.ToInt16(_long);
            Console.WriteLine("_long: {0} - _byte: {1} Convert.ToInt16()", _long, _short);

            _long = 120L;
            _short = (short)_long;
            Console.WriteLine("_long: {0} - _byte: {1} ", _long, _short);

            _ulong = 12L;
            _short = Convert.ToInt16(_ulong);
            Console.WriteLine("_ulong: {0} - _byte: {1} Convert.ToInt16()", _ulong, _short);

            _ulong = 120L;
            _short = (short)_ulong;
            Console.WriteLine("_ulong: {0} - _byte: {1}", _ulong, _short);

            _ulong = 21456984268465L;
            _short = (short)_ulong;
            Console.WriteLine("_ulong: {0} - _byte: {1}", _ulong, _short);

            _float = 21456984265f;
            _short = (short)_float;
            Console.WriteLine("_float: {0} - _byte: {1}", _float, _short);

            _float = -21456984f;
            _short = (short)_float;
            Console.WriteLine("_float: {0} - _byte: {1}", _float, _short);

            _float = 39.2f;
            _short = Convert.ToInt16(_float);
            Console.WriteLine("_float: {0} - _byte: {1} Convert.ToInt16()", _float, _short);

            _float = 39.6f;
            _short = Convert.ToInt16(_float);
            Console.WriteLine("_float: {0} - _byte: {1} Convert.ToInt16()", _float, _short);

            _double = 39.6f;
            _short = Convert.ToInt16(_double);
            Console.WriteLine("_double: {0} - _byte: {1} Convert.ToInt16()", _double, _short);

            _double = 39.2f;
            _short = Convert.ToInt16(_double);
            Console.WriteLine("_double: {0} - _byte: {1} Convert.ToInt16()", _double, _short);

            _double = 39.2f;
            _short = (short)_double;
            Console.WriteLine("_double: {0} - _byte: {1} ", _double, _short);

            _double = 39.8f;
            _short = (short)_double;
            Console.WriteLine("_double: {0} - _byte: {1} ", _double, _short);



            _decimal = 39.8m;
            _short = (short)_decimal;
            Console.WriteLine("_decimal: {0} - _byte: {1} ", _decimal, _short);

            _decimal = 39.2m;
            _short = (short)_decimal;
            Console.WriteLine("_decimal: {0} - _byte: {1} ", _decimal, _short);

            _decimal = 39.2m;
            _short = Convert.ToInt16(_decimal);
            Console.WriteLine("_decimal: {0} - _byte: {1} Convert.ToInt16()", _decimal, _short);

            _decimal = 39.4444445m;
            _short = Convert.ToInt16(_decimal);
            Console.WriteLine("_decimal: {0} - _byte: {1} Convert.ToInt16()", _decimal, _short);

            _object = 39.4444445;
            _short = Convert.ToInt16(_object);
            Console.WriteLine("_decimal: {0} - _byte: {1} Convert.ToInt16()", _object, _short);
            _object = 39.5;
            _short = Convert.ToInt16(_object);
            Console.WriteLine("_decimal: {0} - _byte: {1} Convert.ToInt16()", _object, _short);
            _object = 39.6;
            _short = Convert.ToInt16(_object);
            Console.WriteLine("_decimal: {0} - _byte: {1} Convert.ToInt16()", _object, _short);
            Console.WriteLine("type: {0}", _object.GetType());
        }

        static void ConverterToByte()
        {
            byte _byte;
            short _short;
            ushort _ushort;
            int _int;
            uint _uint;
            long _long;
            ulong _ulong;
            char _char;
            float _float;
            double _double;
            decimal _decimal;
            object _object;
            Console.WriteLine("\n\n_short ======>>>>> _byte: ");
            _short = -2700;
            _byte = (byte)_short;
            Console.WriteLine("_short: {0} - _byte: {1}", _short, _byte);
            _short = 3455;
            _byte = (byte)_short;
            Console.WriteLine("_short: {0} - _byte: {1}", _short, _byte);
            _short = -4500;
            // _byte = Convert.ToByte(_short); // Overflow
            _short = 88;
            _byte = Convert.ToByte(_short);
            Console.WriteLine("_short: {0} - _byte: {1}", _short, _byte);
            
            Console.WriteLine("\n\n_ushort ======>>>>> _byte: ");
            _ushort = 2334;
            _byte = (byte)_ushort;
            Console.WriteLine("_ushort: {0} - _byte: {1}", _ushort, _byte);

            _ushort = 125;
            _byte = (byte)_ushort;
            Console.WriteLine("_ushort: {0} - _byte: {1}", _ushort, _byte);

            _ushort = 25;
            _byte = Convert.ToByte(_ushort);
            Console.WriteLine("_ushort: {0} - _byte: {1} (Convert.ToByte())", _ushort, _byte);

            _ushort = 2005;
            //_byte = Convert.ToByte(_ushort); // OverflowException
            Console.WriteLine("_ushort: {0} - _byte: {1} (Convert.ToByte())", _ushort, _byte);

            _int = 33;
            _byte = (byte)_int;
            Console.WriteLine("_int: {0} - _byte: {1} ", _int, _byte);

            _int = -128;
            _byte = (byte)_int;
            Console.WriteLine("_int: {0} - _byte: {1} ", _int, _byte);

            _int = -548215658;
            _byte = (byte)_int;
            Console.WriteLine("_int: {0} - _byte: {1} ", _int, _byte);

            _int = 548215658;
            _byte = (byte)_int;
            Console.WriteLine("_int: {0} - _byte: {1} ", _int, _byte);

            _uint = 548215658;
            _byte = (byte)_uint;
            Console.WriteLine("_int: {0} - _byte: {1} ", _uint, _byte);

            _uint = 123;
            _byte = (byte)_uint;
            Console.WriteLine("_int: {0} - _byte: {1} ", _uint, _byte);

            _uint = 12;
            _byte = Convert.ToByte(_uint);
            Console.WriteLine("_int: {0} - _byte: {1} ", _uint, _byte);


            _long = 12L;
            _byte = Convert.ToByte(_long);
            Console.WriteLine("_long: {0} - _byte: {1} Convert.ToByte()", _long, _byte);

            _long = 120L;
            _byte = (byte)_long;
            Console.WriteLine("_long: {0} - _byte: {1} ", _long, _byte);

            _ulong = 12L;
            _byte = Convert.ToByte(_ulong);
            Console.WriteLine("_ulong: {0} - _byte: {1} Convert.ToByte()", _ulong, _byte);

            _ulong = 120L;
            _byte = (byte)_ulong;
            Console.WriteLine("_ulong: {0} - _byte: {1}", _ulong, _byte);

            _ulong = 21456984268465L;
            _byte = (byte)_ulong;
            Console.WriteLine("_ulong: {0} - _byte: {1}", _ulong, _byte);

            _float = 21456984265f;
            _byte = (byte)_float;
            Console.WriteLine("_float: {0} - _byte: {1}", _float, _byte);

            _float = -21456984f;
            _byte = (byte)_float;
            Console.WriteLine("_float: {0} - _byte: {1}", _float, _byte);

            _float = 39.2f;
            _byte = Convert.ToByte(_float);
            Console.WriteLine("_float: {0} - _byte: {1} Convert.ToByte()", _float, _byte);

            _float = 39.6f;
            _byte = Convert.ToByte(_float);
            Console.WriteLine("_float: {0} - _byte: {1} Convert.ToByte()", _float, _byte);

            _double = 39.6f;
            _byte = Convert.ToByte(_double);
            Console.WriteLine("_double: {0} - _byte: {1} Convert.ToByte()", _double, _byte);

            _double = 39.2f;
            _byte = Convert.ToByte(_double);
            Console.WriteLine("_double: {0} - _byte: {1} Convert.ToByte()", _double, _byte);

            _double = 39.2f;
            _byte = (byte)_double;
            Console.WriteLine("_double: {0} - _byte: {1} ", _double, _byte);

            _double = 39.8f;
            _byte = (byte)_double;
            Console.WriteLine("_double: {0} - _byte: {1} ", _double, _byte);



            _decimal = 39.8m;
            _byte = (byte)_decimal;
            Console.WriteLine("_decimal: {0} - _byte: {1} ", _decimal, _byte);

            _decimal = 39.2m;
            _byte = (byte)_decimal;
            Console.WriteLine("_decimal: {0} - _byte: {1} ", _decimal, _byte);

            _decimal = 39.2m;
            _byte = Convert.ToByte(_decimal);
            Console.WriteLine("_decimal: {0} - _byte: {1} Convert.ToByte()", _decimal, _byte);

            _decimal = 39.4444445m;
            _byte = Convert.ToByte(_decimal);
            Console.WriteLine("_decimal: {0} - _byte: {1} Convert.ToByte()", _decimal, _byte);

            _object = 39.4444445;
            _byte = Convert.ToByte(_object);
            Console.WriteLine("_decimal: {0} - _byte: {1} Convert.ToByte()", _object, _byte);
            _object = 39.5;
            _byte = Convert.ToByte(_object);
            Console.WriteLine("_decimal: {0} - _byte: {1} Convert.ToByte()", _object, _byte);
            _object = 39.6;
            _byte = Convert.ToByte(_object);
            Console.WriteLine("_decimal: {0} - _byte: {1} Convert.ToByte()", _object, _byte);
            Console.WriteLine("type: {0}", _object.GetType());
        }

        static void ConverterToSByte()
        {
            /*
            sbyte
            byte
            short
            ushort
            int 
            uint
            long
            ulong
            char
            float
            double
            decimal
            object
             */
            sbyte _sbyte;
            
             
            // string para byte
            Console.WriteLine("----- String para sbyte -------");
            string str1 = "123";
            _sbyte = Convert.ToSByte(str1);
            bool res = sbyte.TryParse(str1, out sbyte s2);
            Console.WriteLine("s1: {0}", _sbyte);
            Console.WriteLine("res: {0} - s2: {1}", res, s2);


            Console.WriteLine("----- byte para sbyte -------");
            // byte para sbyte
            byte b1 = 100;
            sbyte s3 = (sbyte)b1;
            byte b2 = 253;
            sbyte s4 = (sbyte)b2; // Ocorre perda de valor.
            Console.WriteLine("s3: {0}", s3);
            Console.WriteLine("b2: {0} - s4: {1}", b2, s4);



            Console.WriteLine("----- short para sbyte -------");
            short sh1 = -145;
            sbyte sb1 = (sbyte)sh1;
            Console.WriteLine("sh1: {0} - sb1: {1}", sh1, sb1);
            short sh2 = 2500;
            sbyte sb2 = (sbyte)sh2;
            Console.WriteLine("sh2: {0} - sb2: {1}", sh2, sb2);


            Console.WriteLine("----- ushort para sbyte -------");
            ushort us1 = 0;
            sbyte sb3 = (sbyte)us1;
            Console.WriteLine("us1: {0} - sb3: {1}", us1, sb3);
            ushort us2 = 478;
            _sbyte = (sbyte)us2;
            Console.WriteLine("us2: {0} - sb4: {1}", us2, _sbyte);




            Console.WriteLine("----- int para sbyte -------");
            int i = 897631;
            _sbyte = (sbyte)i;
            Console.WriteLine("i: {0} - _sbyte: {1}", i, _sbyte);
            i = -43;
            _sbyte = (sbyte)i;
            Console.WriteLine("i: {0} - _sbyte: {1}", i, _sbyte);



            Console.WriteLine("----- long para sbyte -------");
            long l = 348_847_328_346_345L;
            _sbyte = (sbyte)l;
            Console.WriteLine("l: {0} - _sbyte: {1}", l, _sbyte);
            l = -213_345_217_999_583_132L;
            _sbyte = (sbyte)l;
            Console.WriteLine("l: {0} - _sbyte: {1}", l, _sbyte);




            Console.WriteLine("----- ulong para sbyte -------");
            ulong ul = 345_123_848_222_999_487L;
            _sbyte = (sbyte)ul;
            Console.WriteLine("ul: {0} - _sbyte: {1}", ul, _sbyte);

            Console.WriteLine("----- char para sbyte -------");
            char c = (char)33;
            // char c1 = (char)-33; // Compilador não aceita valor negativo !!!
            _sbyte = (sbyte)c;
            Console.WriteLine("c: {0} - _sbyte: {1}", c, _sbyte);



            Console.WriteLine("----- float para sbyte -------");
            float ff = 123.3f;
            _sbyte = (sbyte)ff;
            Console.WriteLine("c: {0} - _sbyte: {1}", ff, _sbyte);

            ff = -126.8f;
            _sbyte = (sbyte)ff;
            Console.WriteLine("c: {0} - _sbyte: {1}", ff, _sbyte);

            _sbyte = Convert.ToSByte(ff);
            Console.WriteLine("c: {0} - _sbyte: {1} (Convert.ToSByte())", ff, _sbyte);

            ff = 123.3f;
            _sbyte = (sbyte)ff;
            Console.WriteLine("c: {0} - _sbyte: {1}", ff, _sbyte);


            Console.WriteLine("----- double para sbyte -------");
            double db1 = 123.4444;
            sbyte sb4 = (sbyte)db1;
            Console.WriteLine("db1: {0} - sb4: {1}", db1, sb4);

            db1 = 123.5555555554;
            sb4 = (sbyte)db1;
            Console.WriteLine("db1: {0} - sb4: {1}", db1, sb4);

            db1 = 123.8888889;
            sb4 = (sbyte)db1;
            Console.WriteLine("db1: {0} - sb4: {1}", db1, sb4);

            db1 = 123.44444444445;
            sb4 = Convert.ToSByte(db1);
            Console.WriteLine("db1: {0} - sb4: {1}", db1, sb4);

            db1 = 123.555555555;
            sb4 = Convert.ToSByte(db1);
            Console.WriteLine("db1: {0} - sb4: {1}", db1, sb4);

            Console.WriteLine("----- decimal para sbyte -------");
            decimal d = 23.5m;
            decimal d2 = 23.4m;
            decimal d3 = 23.8m;
            sbyte by;
            by = Convert.ToSByte(d2);
            Console.WriteLine("d: {0} - by: {1} (Convert.ToSByte())", d2, by);
            by = Convert.ToSByte(d);
            Console.WriteLine("d: {0} - by: {1} (Convert.ToSByte())", d, by);
            by = Convert.ToSByte(d3);
            Console.WriteLine("d: {0} - by: {1} (Convert.ToSByte())", d3, by);
            by = (sbyte)d2;
            Console.WriteLine("d: {0} - by: {1} ", d2, by);
            by = (sbyte)d;
            Console.WriteLine("d: {0} - by: {1} ", d, by);
            by = (sbyte)d3;
            Console.WriteLine("d: {0} - by: {1} ", d3, by);


            Console.WriteLine("----- object para sbyte -------");
            object oo;
            oo = 378_987;
            //OverflowExpetion
            //sbyte _sbyte = Convert.ToSByte(oo); 
            //Console.WriteLine("oo: {0} - _sbyte: {1}", oo, _sbyte);
            oo = 123;
            _sbyte = Convert.ToSByte(oo); // Funciona UAL!!
            Console.WriteLine("oo: {0} - _sbyte: {1} (Convert.ToSByte())", oo, _sbyte);

        }

        #endregion
    }
}
