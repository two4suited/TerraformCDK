using System;
using Constructs;
using HashiCorp.Cdktf;


namespace MyCompany.MyApp
{
    class MainStack : TerraformStack
    {
        public MainStack(Construct scope, string id) : base(scope, id)
        {
            var resourceGroupName = new Names("myapp", "westus").ResourceGroup;

            new TerraformOutput(this, "resource_group_name", new TerraformOutputConfig
            {
                Value = resourceGroupName
            });
            // define resources here
        }
    }
}