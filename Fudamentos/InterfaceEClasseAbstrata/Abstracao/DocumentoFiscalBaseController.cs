using System.Xml;

namespace InterfaceEClasseAbstrata.Abstracao;

public abstract class DocumentoFiscalBaseController
{
    public string RetornarNumeroDocumentoPelaChaveDeAcesso(string chaveAcesso) => chaveAcesso.Substring(25, 9);

    protected abstract string RetornarElementoDaTag(XmlDocument xml, string tag);
}
