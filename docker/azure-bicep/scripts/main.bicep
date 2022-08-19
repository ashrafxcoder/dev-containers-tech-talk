@description('Name of the Storage Account')
param storageName string // must be globally unique

@description('Location of the Storage Account')
param location string = resourceGroup().location

resource stg 'Microsoft.Storage/storageAccounts@2019-06-01' = {
    name: storageName
    location: location
    kind: 'Storage'
    sku: {
        name: 'Standard_LRS'
    }
}
