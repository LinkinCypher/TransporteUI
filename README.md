<h1>DDD+DIP CRUD en .Net Framework</h1>

<p align="center">
	<a href="https://visualstudio.microsoft.com/es/" target="_blank"><img src="https://upload.wikimedia.org/wikipedia/commons/thumb/2/2c/Visual_Studio_Icon_2022.svg/2048px-Visual_Studio_Icon_2022.svg.png" width="200" alt="Visual Studio 2022" /></a>
	<a href="" target="_blank"><img src="https://logos-world.net/wp-content/uploads/2022/01/NET-Framework-Symbol.png" width="200" alt=".Net Framework" /></a>
	<a href="https://www.microsoft.com/es-es/sql-server/sql-server-downloads" target="_blank"><img src="https://brandslogos.com/wp-content/uploads/thumbs/microsoft-sql-server-logo-vector.svg" width="200" alt="SQL Server" /></a>
</p>

<br>

## INSTALACIÓN
Visual Studio Community 2022 - 17.8.2: 
<a href="https://visualstudio.microsoft.com/es/thank-you-downloading-visual-studio/?sku=Community&channel=Release&version=VS2022&source=VSLandingPage&cid=2030&passive=false" target="_blank">visualstudio.microsoft.com</a>
Cargas de trabajo: <br>
- Desarrollo de escritorio de .NET <br>
Opcional: <br>
- Herramiestas de desarrollo de .NET Framework 4.8
- Herramiestas de Entity Framework 6
- Paquete de compatibilidad de bibliotecas

<br>
SQL Server Express: 
<a href="https://go.microsoft.com/fwlink/p/?linkid=2216019&clcid=0x40A&culture=es-es&country=es" target="_blank">www.microsoft.com</a>

<br>
SQL Server Management Studio: 
<a href="https://aka.ms/ssmsfullsetup?clcid=0x40a" target="_blank">learn.microsoft.com</a>
<br>

<br>

## CONFIGURACIÓN
Ubicación del proyecto: <br>
const string inputFile = @"C:\Proyectos\TransporteUI\Infraestructura.AccesoDatos\Model_TransporteUI.edmx"; <br>
<br>
Conexión con la base de datos <br>
Lo más importante es <b>source=PC-Cr</b> que contiene el nombre del motor de la base de datos.
Copiar de: 4.Infraestructura > Infraestructura.AccesoDatos > App.Config <br>
Ejemplo:
```bash
<connectionStrings>
  <add name="transporteUI_DBEntities" connectionString="metadata=res://*/Model_TransporteUI.csdl|res://*/Model_TransporteUI.ssdl|res://*/Model_TransporteUI.msl;provider=System.Data.SqlClient;provider connection string=&quot;data source=PC-Cr;initial catalog=transporteUI_DB;integrated security=True;trustservercertificate=True;MultipleActiveResultSets=True;App=EntityFramework&quot;" providerName="System.Data.EntityClient" />
</connectionStrings>
```
Pegar en: 1.InterfazUsuario > UI.windows > VistaModelo > App.Config <br>
```bash
<?xml version="1.0" encoding="utf-8" ?>
<configuration>
    <startup> 
        <supportedRuntime version="v4.0" sku=".NETFramework,Version=v4.8" />
    </startup>
  <connectionStrings>
    <add name="transporteUI_DBEntities" connectionString="metadata=res://*/Model_TransporteUI.csdl|res://*/Model_TransporteUI.ssdl|res://*/Model_TransporteUI.msl;provider=System.Data.SqlClient;provider connection string=&quot;data source=PC-Cr;initial catalog=transporteUI_DB;integrated security=True;trustservercertificate=True;MultipleActiveResultSets=True;App=EntityFramework&quot;" providerName="System.Data.EntityClient" />
  </connectionStrings>
</configuration>
```