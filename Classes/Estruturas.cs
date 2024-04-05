using System;
using EstruturaDeDados.Modelos;

namespace EstruturaDeDados.Classes
{
    public class Estruturas
    {
        protected EstruturasPrimitivas objTipos = new EstruturasPrimitivas();
        private string sNaoConverte = "Não foi possível converter!";

        private bool inserirChar(object oObjeto)
        {
            if (oObjeto is char)
            {
                char cObj = (char)oObjeto;
                objTipos.CCARACTER = cObj;
                return true;
            }
            else
                throw new InvalidOperationException(sNaoConverte);
        }

        private bool removerChar()
        {
            objTipos.CCARACTER = char.MinValue;
            return true;
        }

        private bool inserirString(object oObjeto)
        {
            if (oObjeto is string)
            {
                string sObj = (string)oObjeto;
                objTipos.STEXTO = sObj;
                return true;
            }
            else
                throw new InvalidOperationException(sNaoConverte);

        }

        private bool removerString()
        {
            objTipos.STEXTO = string.Empty;
            return true;
        }

        private bool inserirInt(object oObjeto)
        {
            if (oObjeto is int)
            {
                int iObj = (int)oObjeto;
                objTipos.IINTEIRO = iObj;
                return true;
            }
            else
                throw new InvalidOperationException(sNaoConverte);
        }

        private bool removerInt()
        {
            objTipos.IINTEIRO = int.MinValue;
            return true;
        }

        private bool inserirDouble(object oObjeto)
        {
            if (oObjeto is double)
            {
                double dObj = (double)oObjeto;
                objTipos.DDUPLA = dObj;
                return true;
            }
            else
                throw new InvalidOperationException(sNaoConverte);
        }

        private bool removerDouble()
        {
            objTipos.DDUPLA = double.MinValue;
            return true;
        }

        private bool inserirFloat(object oObjeto)
        {
            if (oObjeto is float)
            {
                float fObj = (float)oObjeto;
                objTipos.FFLUTUANTE = fObj;
                return true;
            }
            else
                throw new InvalidOperationException(sNaoConverte);
        }

        private bool removerFloat()
        {
            objTipos.FFLUTUANTE = float.MinValue;
            return true;
        }

        private bool inserirDecimal(object oObjeto)
        {
            if (oObjeto is decimal)
            {
                decimal dObj = (decimal)oObjeto;
                objTipos.DDECIMAL = dObj;
                return true;
            }
            else
                throw new InvalidOperationException(sNaoConverte);
        }

        private bool removerDecimal()
        {
            objTipos.DDECIMAL = decimal.MinValue;
            return true;
        }

        private bool inserirLong(object oObjeto)
        {
            if (oObjeto is long)
            {
                long lObj = (long)oObjeto;
                objTipos.LLONGO = lObj;
                return true;
            }
            else
                throw new InvalidOperationException(sNaoConverte);
        }

        private bool removerLong()
        {
            objTipos.LLONGO = long.MinValue;
            return true;
        }

        private bool inserirBool(object oObjeto)
        {
            if (oObjeto is bool? || oObjeto is bool)
            {
                bool? bObj = Convert.ToBoolean(oObjeto);
                objTipos.BBOLEANO = bObj;
                return true;
            }
            else
                throw new InvalidOperationException(sNaoConverte);
        }

        private bool removerBool()
        {
            objTipos.BBOLEANO = null;
            return true;
        }

        private bool inserirByte(object oObjeto)
        {
            if (oObjeto is byte)
            {
                byte bObj = Convert.ToByte(oObjeto);
                objTipos.BBYTE = bObj;
                return true;
            }
            else
                throw new InvalidOperationException(sNaoConverte);
        }

        private bool removerByte()
        {
            objTipos.BBYTE = byte.MinValue;
            return true;
        }

        private bool inserirSbyte(object oObjeto)
        {
            if (oObjeto is sbyte)
            {
                sbyte sObj = Convert.ToSByte(oObjeto);
                objTipos.SBBYTES = sObj;
                return true;
            }
            else
                throw new InvalidOperationException(sNaoConverte);
        }

        private bool removerSbyte()
        {
            objTipos.SBBYTES = sbyte.MinValue;
            return true;
        }

        private bool inserirShort(object oObjeto)
        {
            if (oObjeto is short)
            {
                short sObj = Convert.ToInt16(oObjeto);
                objTipos.SBAIXO = sObj;
                return true;
            }
            else
                throw new InvalidOperationException(sNaoConverte);
        }

        private bool removerShor()
        {
            objTipos.SBAIXO = short.MinValue;
            return true;
        }

        private bool inserirUint(object oObjeto)
        {
            if (oObjeto is uint)
            {
                uint uObj = Convert.ToUInt32(oObjeto);
                objTipos.UINTEIRO = uObj;
                return true;
            }
            else
                throw new InvalidOperationException(sNaoConverte);
        }

        private bool removerUint()
        {
            objTipos.UINTEIRO = uint.MinValue;
            return true;
        }

        private bool inserirUlong(object oObjeto)
        {
            if (oObjeto is ulong)
            {
                ulong uObj = Convert.ToUInt64(oObjeto);
                objTipos.ULONGO = uObj;
                return true;
            }
            else
                throw new InvalidOperationException(sNaoConverte);
        }

        private bool removerUlong()
        {
            objTipos.ULONGO = ulong.MinValue;
            return true;
        }

        private bool inserirUshort(object oObjeto)
        {
            if (oObjeto is ushort)
            {
                ushort uObj = Convert.ToUInt16(oObjeto);
                objTipos.UBAIXO = uObj;
                return true;
            }
            else
                throw new InvalidOperationException(sNaoConverte);
        }

        public bool inserirEstrutura(int iID, double DX, double DY, double DZ)
        {
            if (iID < 0)
                return false;
            EstruturasPrimitivas.SEstrutura objEstrutura;
            objEstrutura = new EstruturasPrimitivas.SEstrutura(iID, DX, DY, DZ);
            objTipos.ESTRUTURA = objEstrutura;
            return true;
        }

        public bool removerEstrutura()
        {
            objTipos.ESTRUTURA = new EstruturasPrimitivas.SEstrutura(-1, 0, 0, 0);
            return true;
        }

        public string obterEstrutura()
        {
            return objTipos.ESTRUTURA.ToString();
        }

        public object ESTRUTURAS
        {
            get
            {
                if (objTipos.CCARACTER != char.MinValue)
                    return objTipos.CCARACTER;
                if (!string.IsNullOrEmpty(objTipos.STEXTO))
                    return objTipos.STEXTO;
                if (objTipos.IINTEIRO != int.MinValue)
                    return objTipos.IINTEIRO;
                if (objTipos.DDUPLA != double.MinValue)
                    return objTipos.DDUPLA;
                if (objTipos.FFLUTUANTE != float.MinValue)
                    return objTipos.FFLUTUANTE;
                if (objTipos.DDECIMAL != decimal.MinValue)
                    return objTipos.DDECIMAL;
                if (objTipos.LLONGO != long.MinValue)
                    return objTipos.LLONGO;
                if (objTipos.BBOLEANO != null)
                    return objTipos.BBOLEANO;
                if (objTipos.BBYTE != byte.MinValue)
                    return objTipos.BBYTE;
                if (objTipos.SBBYTES != sbyte.MinValue)
                    return objTipos.SBBYTES;
                if (objTipos.SBAIXO != short.MinValue)
                    return objTipos.SBAIXO;
                if (objTipos.UINTEIRO != uint.MinValue)
                    return objTipos.UINTEIRO;
                if (objTipos.ULONGO != ulong.MinValue)
                    return objTipos.ULONGO;
                if (objTipos.UBAIXO != ushort.MinValue)
                    return objTipos.UBAIXO;
                return new object();
            }
            set
            {
                try
                {
                    if (value.GetType() == typeof(char))
                        inserirChar(value);
                    else if (value.GetType() == typeof(string))
                        inserirString(value);
                    else if (value.GetType() == typeof(int))
                        inserirInt(value);
                    else if (value.GetType() == typeof(double))
                        inserirDouble(value);
                    else if (value.GetType() == typeof(float))
                        inserirFloat(value);
                    else if (value.GetType() == typeof(decimal))
                        inserirDecimal(value);
                    else if (value.GetType() == typeof(long))
                        inserirLong(value);
                    else if (value.GetType() == typeof(bool))
                        inserirBool(value);
                    else if (value.GetType() == typeof(byte))
                        inserirByte(value);
                    else if (value.GetType() == typeof(sbyte))
                        inserirSbyte(value);
                    else if (value.GetType() == typeof(short))
                        inserirShort(value);
                    else if (value.GetType() == typeof(uint))
                        inserirUint(value);
                    else if (value.GetType() == typeof(ulong))
                        inserirUlong(value);
                    else if (value.GetType() == typeof(ushort))
                        inserirUshort(value);
                }
                catch (InvalidOperationException ex)
                {
                    inserirString(ex.Message);
                }
            }
        }
    }
}