<%@Application Language='C#' Inherits="Sitecore.Web.Application" %>
<%@ Import Namespace="System.Runtime.InteropServices" %>
<%@ Import Namespace="Glass.Sitecore.Mapper" %>
<%@ Import Namespace="Glass.Sitecore.Mapper.Configuration.Attributes" %>
<%@ Import Namespace="Glass.Sitecore.Mapper.Razor" %>
<%@ Import Namespace="Sitecore.Diagnostics" %>

<script runat="server">

    public void Application_Start()
    {
        //var loader = new AttributeConfigurationLoader("Website.MVC, SUGNL.Website");
        //var context = new Context(loader, new GlassModuleLoader());
    }

    public void Application_End()
    {
    }

    public void Application_Error(object sender, EventArgs args)
    {
    }

    public void FormsAuthentication_OnAuthenticate(object sender, FormsAuthenticationEventArgs args)
    {
        string frameworkVersion = GetFrameworkVersion();
        if (!string.IsNullOrEmpty(frameworkVersion) && frameworkVersion.StartsWith("v4.", StringComparison.InvariantCultureIgnoreCase))
        {
            args.User = Sitecore.Context.User;
        }
    }

    private string GetFrameworkVersion()
    {
        try
        {
            return RuntimeEnvironment.GetSystemVersion();
        }
        catch (Exception ex)
        {
            Log.Error("Cannot get framework version", ex, this);
            return string.Empty;
        }
    }

</script>