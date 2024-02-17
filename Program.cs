using System;
using Constructs;
using HashiCorp.Cdktf;

namespace MyCompany.MyApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            App app = new App();
            MainStack stack = new MainStack(app, "TerraformCDK");
            new CloudBackend(stack, new CloudBackendConfig { Hostname = "app.terraform.io", Organization = "BS_INC", Workspaces = new NamedCloudWorkspace("TerraformCDK") });
            app.Synth();
            Console.WriteLine("App synth complete");
        }
    }
}