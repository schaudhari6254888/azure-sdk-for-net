// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Attestation.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.Attestation.Samples
{
    public partial class Sample_AttestationPrivateEndpointConnectionResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_AttestationProviderGetPrivateEndpointConnection()
        {
            // Generated from example definition: specification/attestation/resource-manager/Microsoft.Attestation/preview/2021-06-01-preview/examples/AttestationProviderGetPrivateEndpointConnection.json
            // this example is just showing the usage of "PrivateEndpointConnections_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AttestationPrivateEndpointConnectionResource created on azure
            // for more information of creating AttestationPrivateEndpointConnectionResource, please refer to the document of AttestationPrivateEndpointConnectionResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "res6977";
            string providerName = "sto2527";
            string privateEndpointConnectionName = "{privateEndpointConnectionName}";
            ResourceIdentifier attestationPrivateEndpointConnectionResourceId = AttestationPrivateEndpointConnectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, providerName, privateEndpointConnectionName);
            AttestationPrivateEndpointConnectionResource attestationPrivateEndpointConnection = client.GetAttestationPrivateEndpointConnectionResource(attestationPrivateEndpointConnectionResourceId);

            // invoke the operation
            AttestationPrivateEndpointConnectionResource result = await attestationPrivateEndpointConnection.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            AttestationPrivateEndpointConnectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_AttestationProviderDeletePrivateEndpointConnection()
        {
            // Generated from example definition: specification/attestation/resource-manager/Microsoft.Attestation/preview/2021-06-01-preview/examples/AttestationProviderDeletePrivateEndpointConnection.json
            // this example is just showing the usage of "PrivateEndpointConnections_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AttestationPrivateEndpointConnectionResource created on azure
            // for more information of creating AttestationPrivateEndpointConnectionResource, please refer to the document of AttestationPrivateEndpointConnectionResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "res6977";
            string providerName = "sto2527";
            string privateEndpointConnectionName = "{privateEndpointConnectionName}";
            ResourceIdentifier attestationPrivateEndpointConnectionResourceId = AttestationPrivateEndpointConnectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, providerName, privateEndpointConnectionName);
            AttestationPrivateEndpointConnectionResource attestationPrivateEndpointConnection = client.GetAttestationPrivateEndpointConnectionResource(attestationPrivateEndpointConnectionResourceId);

            // invoke the operation
            await attestationPrivateEndpointConnection.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_AttestationProviderPutPrivateEndpointConnection()
        {
            // Generated from example definition: specification/attestation/resource-manager/Microsoft.Attestation/preview/2021-06-01-preview/examples/AttestationProviderPutPrivateEndpointConnection.json
            // this example is just showing the usage of "PrivateEndpointConnections_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AttestationPrivateEndpointConnectionResource created on azure
            // for more information of creating AttestationPrivateEndpointConnectionResource, please refer to the document of AttestationPrivateEndpointConnectionResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "res7687";
            string providerName = "sto9699";
            string privateEndpointConnectionName = "{privateEndpointConnectionName}";
            ResourceIdentifier attestationPrivateEndpointConnectionResourceId = AttestationPrivateEndpointConnectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, providerName, privateEndpointConnectionName);
            AttestationPrivateEndpointConnectionResource attestationPrivateEndpointConnection = client.GetAttestationPrivateEndpointConnectionResource(attestationPrivateEndpointConnectionResourceId);

            // invoke the operation
            AttestationPrivateEndpointConnectionData data = new AttestationPrivateEndpointConnectionData
            {
                ConnectionState = new AttestationPrivateLinkServiceConnectionState
                {
                    Status = AttestationPrivateEndpointServiceConnectionStatus.Approved,
                    Description = "Auto-Approved",
                },
            };
            ArmOperation<AttestationPrivateEndpointConnectionResource> lro = await attestationPrivateEndpointConnection.UpdateAsync(WaitUntil.Completed, data);
            AttestationPrivateEndpointConnectionResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            AttestationPrivateEndpointConnectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
