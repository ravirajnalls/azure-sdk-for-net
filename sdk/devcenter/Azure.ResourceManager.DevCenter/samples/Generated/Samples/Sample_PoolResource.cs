// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;
using Azure.ResourceManager.DevCenter;
using Azure.ResourceManager.DevCenter.Models;

namespace Azure.ResourceManager.DevCenter.Samples
{
    public partial class Sample_PoolResource
    {
        // Pools_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_PoolsGet()
        {
            // Generated from example definition: specification/devcenter/resource-manager/Microsoft.DevCenter/preview/2022-08-01-preview/examples/Pools_Get.json
            // this example is just showing the usage of "Pools_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PoolResource created on azure
            // for more information of creating PoolResource, please refer to the document of PoolResource
            string subscriptionId = "{subscriptionId}";
            string resourceGroupName = "rg1";
            string projectName = "{projectName}";
            string poolName = "{poolName}";
            ResourceIdentifier poolResourceId = PoolResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, projectName, poolName);
            PoolResource pool = client.GetPoolResource(poolResourceId);

            // invoke the operation
            PoolResource result = await pool.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            PoolData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Pools_Update
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_PoolsUpdate()
        {
            // Generated from example definition: specification/devcenter/resource-manager/Microsoft.DevCenter/preview/2022-08-01-preview/examples/Pools_Patch.json
            // this example is just showing the usage of "Pools_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PoolResource created on azure
            // for more information of creating PoolResource, please refer to the document of PoolResource
            string subscriptionId = "{subscriptionId}";
            string resourceGroupName = "rg1";
            string projectName = "{projectName}";
            string poolName = "{poolName}";
            ResourceIdentifier poolResourceId = PoolResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, projectName, poolName);
            PoolResource pool = client.GetPoolResource(poolResourceId);

            // invoke the operation
            PoolPatch patch = new PoolPatch()
            {
                DevBoxDefinitionName = "WebDevBox2",
            };
            ArmOperation<PoolResource> lro = await pool.UpdateAsync(WaitUntil.Completed, patch);
            PoolResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            PoolData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Pools_Delete
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_PoolsDelete()
        {
            // Generated from example definition: specification/devcenter/resource-manager/Microsoft.DevCenter/preview/2022-08-01-preview/examples/Pools_Delete.json
            // this example is just showing the usage of "Pools_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PoolResource created on azure
            // for more information of creating PoolResource, please refer to the document of PoolResource
            string subscriptionId = "{subscriptionId}";
            string resourceGroupName = "rg1";
            string projectName = "{projectName}";
            string poolName = "poolName";
            ResourceIdentifier poolResourceId = PoolResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, projectName, poolName);
            PoolResource pool = client.GetPoolResource(poolResourceId);

            // invoke the operation
            await pool.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }
    }
}
