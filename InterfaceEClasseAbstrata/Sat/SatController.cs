using InterfaceEClasseAbstrata.Abstracao;
using System.Xml;

namespace InterfaceEClasseAbstrata.Sat;

public class SatController : DocumentoFiscalBaseController, ISatController
{
    public void CancelarDocumento(string chaveAcesso)
    {
        
    }

    public void ConfigurarEquipamento()
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
