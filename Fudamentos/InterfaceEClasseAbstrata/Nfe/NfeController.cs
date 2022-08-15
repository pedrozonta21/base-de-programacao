using InterfaceEClasseAbstrata.Abstracao;
using System.Xml;

namespace InterfaceEClasseAbstrata.Nfe;

internal class NfeController : DocumentoFiscalBaseController, INfeController
{
    public void CancelarDocumento(string chaveAcesso)
    {
        
    }

    public void ConsultarDocumento(string chaveAcesso)
    {
        
    }

    public void EmitirDocumento(string xml)
    {
        
    }

    protected override string RetornarElementoDaTag(XmlDocument xml, string tag)
    {
        return string.Empty;
    }
}
