# azure-cdn-demos

Before running this demo , you must create a service principal on your Azure account. To do that , you can use the commands or the link below.

### creating service principal via Azure portal


https://docs.microsoft.com/en-us/azure/active-directory/develop/howto-create-service-principal-portal#register-an-application-with-azure-ad-and-create-a-service-principal

### creating service principal via Azure CLI

```bash

az account set --subscription "YOUR SUBSCRIPTION NAME"

az ad sp create-for-rbac --role Contributor

```

Please keep your commands' outputs.
