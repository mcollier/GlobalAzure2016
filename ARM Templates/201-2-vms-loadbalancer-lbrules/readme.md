    Login-AzureRmAccount

    #Select-AzureRmSubscription <subscription-id>

    New-AzureRmResourceGroup -Name GlobalAzure2016-vm-2 -Location eastus

     New-AzureRmResourceGroupDeployment 
		-ResourceGroupName GlobalAzure2016-vm-2 
		-TemplateParameterFile .\azuredeploy.parameters.json 
		-TemplateFile .\azuredeploy.json