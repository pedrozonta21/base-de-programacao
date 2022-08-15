using InterfaceEClasseAbstrata.InterfaceFiscal;

namespace InterfaceEClasseAbstrata.Sat;

public interface ISatController : IDocumentoFiscal
{
    void ConfigurarEquipamento();
}
