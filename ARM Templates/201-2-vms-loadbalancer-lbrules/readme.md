Get all this at https://github.com/Azure/azure-quickstart-templates/tree/master/201-2-vms-loadbalancer-lbrules
    
	Login-AzureRmAccount

    #Select-AzureRmSubscription -SubscriptionId <subscription-id>

    New-AzureRmResourceGroup -Name GlobalAzure2016-vm-2 -Location eastus

     New-AzureRmResourceGroupDeployment 
		-ResourceGroupName GlobalAzure2016-vm-2 
		-TemplateParameterFile .\azuredeploy.parameters.json 
		-TemplateFile .\azuredeploy.json