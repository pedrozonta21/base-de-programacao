using DesignPatterns.Estruturais.Facade.Services.Interfaces;

namespace DesignPatterns.Estruturais.Facade.Services;

internal class QrCodeFramework1Service : IQrCodeFacadeService
{
	private readonly FrameworkQrCode _frameworkQrCode;

	public QrCodeFramework1Service()
	{
		_frameworkQrCode = new FrameworkQrCode();
	}

    public string GerarQrCode(object conteudo) => _frameworkQrCode.GerarQrCode(conteudo);
}
