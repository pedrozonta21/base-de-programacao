namespace InterfaceEClasseAbstrata.InterfaceFiscal;

public interface IDocumentoFiscal
{
    void EmitirDocumento(string xml);
    void ConsultarDocumento(string chaveAcesso);
    void CancelarDocumento(string chaveAcesso);
}
