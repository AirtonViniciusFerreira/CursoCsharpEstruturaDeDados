namespace EstruturaDeDados.Modelos
{
    public class Pessoa
    {
        int _PESSOA_ID = -1;
        string _PESSOA_NOME = string.Empty;
        string _PESSOA_CPF = string.Empty;
        string _PESSOA_RG = string.Empty;
        bool _PESSSOA_ATIVO = false;
        string _PESSOA_EMAIL = string.Empty;

        public int PESSOA_ID { get => _PESSOA_ID; set => _PESSOA_ID = value; }
        public string PESSOA_NOME { get => _PESSOA_NOME; set => _PESSOA_NOME = value; }
        public string PESSOA_CPF { get => _PESSOA_CPF; set => _PESSOA_CPF = value; }
        public string PESSOA_RG { get => _PESSOA_RG; set => _PESSOA_RG = value; }
        public bool PESSSOA_ATIVO { get => _PESSSOA_ATIVO; set => _PESSSOA_ATIVO = value; }
        public string PESSOA_EMAIL { get => _PESSOA_EMAIL; set => _PESSOA_EMAIL = value; }
    }
}