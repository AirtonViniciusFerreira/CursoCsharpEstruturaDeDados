namespace EstruturaDeDados.Modelos
{
    public class EstruturasPrimitivas
    {
        private char cCaracter = char.MinValue;
        private string sTexto = string.Empty;
        private int iInteiro = int.MinValue;
        private double dDupla = double.MinValue;
        private float fFlutuante = float.MinValue;
        private decimal dDecimal = decimal.MinValue;
        private long lLongo = long.MinValue;
        private bool? bBoleano = null;
        private byte bByte = byte.MinValue;
        private sbyte sbBytes = sbyte.MinValue;
        private short sBaixo = short.MinValue;
        private uint uInteiro = uint.MinValue;
        private ulong uLongo = ulong.MinValue;
        private ushort uBaixo = ushort.MinValue;

        private SEstrutura estrutura;
        public struct SEstrutura
        {
            public int IID { get; }
            public double DX { get; }
            public double DY { get; }
            public double DZ { get; }
            public SEstrutura (int iId, double dX, double dY, double dZ)
            {
                IID = iId;
                DX = dX;
                DY = dY;
                DZ = dZ;
            }

            public override string ToString()
            {
                return "{" + $"\"id\": {IID}, \"X\": {DX}, \"Y\": {DY}, \"Z\": {DZ}  " + "}";
            }
        }

        #region Get's e Set's
        public char  CCARACTER
        {
            get { return cCaracter; }
            set { cCaracter = value; }
        }
        public string  STEXTO
        {
            get { return sTexto; }
            set { sTexto = value; }
        }
        public int IINTEIRO 
        {
            get { return iInteiro; }
            set { iInteiro = value; }
        }
        public double DDUPLA 
        {
            get { return dDupla; }
            set { dDupla = value; }
        }
        public float FFLUTUANTE
        {
            get { return fFlutuante; }
            set { fFlutuante = value; }
        }
        public decimal DDECIMAL 
        {
            get { return dDecimal; }
            set { dDecimal = value; }
        }
        public long LLONGO 
        {
            get { return lLongo; }
            set { lLongo = value; }
        }
        public bool? BBOLEANO
        {
            get { return bBoleano; }
            set { bBoleano = value; }
        }
        public byte BBYTE
        {
            get { return bByte; }
            set { bByte = value; }
        }
        public sbyte SBBYTES
        {
            get { return sbBytes; }
            set { sbBytes = value; }
        }
        public short SBAIXO
        {
            get { return sBaixo; }
            set { sBaixo = value; }
        }
        public uint UINTEIRO 
        {
            get { return uInteiro; }
            set { uInteiro = value; }
        }
        public ulong ULONGO 
        {
            get { return uLongo; }
            set { uLongo = value; }
        }
        public ushort UBAIXO
        {
            get { return uBaixo; }
            set { uBaixo = value; }
        }
        
        public SEstrutura  ESTRUTURA
        {
            get { return estrutura; }
            set { estrutura = value; }
        }
        
        #endregion
    }
}