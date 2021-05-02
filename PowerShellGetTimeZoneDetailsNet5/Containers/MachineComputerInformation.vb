Imports System.ComponentModel

<Category("Computer information")>
Public Class MachineComputerInformation
	<DisplayName("Build Lab")>
	Public Property WindowsBuildLabEx() As String
	<DisplayName("Current Version")>
	Public Property WindowsCurrentVersion() As String
	<DisplayName("Edition Id")>
	Public Property WindowsEditionId() As String
	<DisplayName("Installation Type")>
	Public Property WindowsInstallationType() As String
	<DisplayName("Install Date From Registry")>
	Public Property WindowsInstallDateFromRegistry() As DateTime
	<DisplayName("Product Id")>
	Public Property WindowsProductId() As String
	<DisplayName("Product Name")>
	Public Property WindowsProductName() As String
	<DisplayName("Registered Org")>
	Public Property WindowsRegisteredOrganization() As String
	<DisplayName("Registered Owner")>
	Public Property WindowsRegisteredOwner() As String
	<DisplayName("System Root")>
	Public Property WindowsSystemRoot() As String
	<DisplayName("Windows Version")>
	Public Property WindowsVersion() As String
	Public Property BiosCharacteristics() As Integer()
	Public Property BiosBIOSVersion() As String()
	Public Property BiosBuildNumber() As Object
	Public Property BiosCaption() As String
	Public Property BiosCodeSet() As Object
	Public Property BiosCurrentLanguage() As String
	Public Property BiosDescription() As String
	Public Property BiosEmbeddedControllerMajorVersion() As Integer
	Public Property BiosEmbeddedControllerMinorVersion() As Integer
	Public Property BiosFirmwareType() As Integer
	Public Property BiosIdentificationCode() As Object
	Public Property BiosInstallableLanguages() As Integer
	Public Property BiosInstallDate() As Object
	Public Property BiosLanguageEdition() As Object
	Public Property BiosListOfLanguages() As String()
	Public Property BiosManufacturer() As String
	Public Property BiosName() As String
	Public Property BiosOtherTargetOS() As Object
	Public Property BiosPrimaryBIOS() As Boolean
	Public Property BiosReleaseDate() As DateTime
	Public Property BiosSeralNumber() As String
	Public Property BiosSMBIOSBIOSVersion() As String
	Public Property BiosSMBIOSMajorVersion() As Integer
	Public Property BiosSMBIOSMinorVersion() As Integer
	Public Property BiosSMBIOSPresent() As Boolean
	Public Property BiosSoftwareElementState() As Integer
	Public Property BiosStatus() As String
	Public Property BiosSystemBiosMajorVersion() As Integer
	Public Property BiosSystemBiosMinorVersion() As Integer
	Public Property BiosTargetOperatingSystem() As Integer
	Public Property BiosVersion() As String
	Public Property CsAdminPasswordStatus() As Integer
	Public Property CsAutomaticManagedPagefile() As Boolean
	Public Property CsAutomaticResetBootOption() As Boolean
	Public Property CsAutomaticResetCapability() As Boolean
	Public Property CsBootOptionOnLimit() As Object
	Public Property CsBootOptionOnWatchDog() As Object
	Public Property CsBootROMSupported() As Boolean
	Public Property CsBootStatus() As Integer()
	Public Property CsBootupState() As String
	Public Property CsCaption() As String
	Public Property CsChassisBootupState() As Integer
	Public Property CsChassisSKUNumber() As String
	Public Property CsCurrentTimeZone() As Integer
	Public Property CsDaylightInEffect() As Boolean
	Public Property CsDescription() As String
	Public Property CsDNSHostName() As String
	Public Property CsDomain() As String
	Public Property CsDomainRole() As Integer
	Public Property CsEnableDaylightSavingsTime() As Boolean
	Public Property CsFrontPanelResetStatus() As Integer
	Public Property CsHypervisorPresent() As Boolean
	Public Property CsInfraredSupported() As Boolean
	Public Property CsInitialLoadInfo() As Object
	Public Property CsInstallDate() As Object
	Public Property CsKeyboardPasswordStatus() As Integer
	Public Property CsLastLoadInfo() As Object
	Public Property CsManufacturer() As String
	Public Property CsModel() As String
	Public Property CsName() As String
	<Category("Network adapter")>
	Public Property CsNetworkAdapters() As Csnetworkadapter()
	Public Property CsNetworkServerModeEnabled() As Boolean
	Public Property CsNumberOfLogicalProcessors() As Integer
	Public Property CsNumberOfProcessors() As Integer
	<Category("Processor")>
	Public Property CsProcessors() As Csprocessor()
	Public Property CsOEMStringArray() As String()
	Public Property CsPartOfDomain() As Boolean
	Public Property CsPauseAfterReset() As Integer
	Public Property CsPCSystemType() As Integer
	Public Property CsPCSystemTypeEx() As Integer
	Public Property CsPowerManagementCapabilities() As Object
	Public Property CsPowerManagementSupported() As Object
	Public Property CsPowerOnPasswordStatus() As Integer
	Public Property CsPowerState() As Integer
	Public Property CsPowerSupplyState() As Integer
	Public Property CsPrimaryOwnerContact() As Object
	Public Property CsPrimaryOwnerName() As String
	Public Property CsResetCapability() As Integer
	Public Property CsResetCount() As Integer
	Public Property CsResetLimit() As Integer
	Public Property CsRoles() As String()
	Public Property CsStatus() As String
	Public Property CsSupportContactDescription() As Object
	Public Property CsSystemFamily() As String
	Public Property CsSystemSKUNumber() As String
	Public Property CsSystemType() As String
	Public Property CsThermalState() As Integer
	Public Property CsTotalPhysicalMemory() As Long
	Public Property CsPhyicallyInstalledMemory() As Integer
	Public Property CsUserName() As String
	Public Property CsWakeUpType() As Integer
	Public Property CsWorkgroup() As Object
	Public Property OsName() As String
	Public Property OsType() As Integer
	Public Property OsOperatingSystemSKU() As Integer
	Public Property OsVersion() As String
	Public Property OsCSDVersion() As Object
	Public Property OsBuildNumber() As String
	<Category("Hot fix")>
	Public Property OsHotFixes() As Oshotfix()
	Public Property OsBootDevice() As String
	Public Property OsSystemDevice() As String
	Public Property OsSystemDirectory() As String
	Public Property OsSystemDrive() As String
	Public Property OsWindowsDirectory() As String
	Public Property OsCountryCode() As String
	Public Property OsCurrentTimeZone() As Integer
	Public Property OsLocaleID() As String
	Public Property OsLocale() As String
	Public Property OsLocalDateTime() As DateTime
	Public Property OsLastBootUpTime() As DateTime
	<Category("Up time")>
	Public Property OsUptime() As Osuptime
	Public Property OsBuildType() As String
	Public Property OsCodeSet() As String
	Public Property OsDataExecutionPreventionAvailable() As Boolean
	Public Property OsDataExecutionPrevention32BitApplications() As Boolean
	Public Property OsDataExecutionPreventionDrivers() As Boolean
	Public Property OsDataExecutionPreventionSupportPolicy() As Integer
	Public Property OsDebug() As Boolean
	Public Property OsDistributed() As Boolean
	Public Property OsEncryptionLevel() As Integer
	Public Property OsForegroundApplicationBoost() As Integer
	Public Property OsTotalVisibleMemorySize() As Integer
	Public Property OsFreePhysicalMemory() As Integer
	Public Property OsTotalVirtualMemorySize() As Integer
	Public Property OsFreeVirtualMemory() As Integer
	Public Property OsInUseVirtualMemory() As Integer
	Public Property OsTotalSwapSpaceSize() As Object
	Public Property OsSizeStoredInPagingFiles() As Integer
	Public Property OsFreeSpaceInPagingFiles() As Integer
	Public Property OsPagingFiles() As String()
	Public Property OsHardwareAbstractionLayer() As String
	Public Property OsInstallDate() As DateTime
	Public Property OsManufacturer() As String
	Public Property OsMaxNumberOfProcesses() As Long
	Public Property OsMaxProcessMemorySize() As Long
	Public Property OsMuiLanguages() As String()
	Public Property OsNumberOfLicensedUsers() As Object
	Public Property OsNumberOfProcesses() As Integer
	Public Property OsNumberOfUsers() As Integer
	Public Property OsOrganization() As String
	Public Property OsArchitecture() As String
	Public Property OsLanguage() As String
	Public Property OsProductSuites() As Integer()
	Public Property OsOtherTypeDescription() As Object
	Public Property OsPAEEnabled() As Object
	Public Property OsPortableOperatingSystem() As Boolean
	Public Property OsPrimary() As Boolean
	Public Property OsProductType() As Integer
	Public Property OsRegisteredUser() As String
	Public Property OsSerialNumber() As String
	Public Property OsServicePackMajorVersion() As Integer
	Public Property OsServicePackMinorVersion() As Integer
	Public Property OsStatus() As String
	Public Property OsSuites() As Integer()
	Public Property OsServerLevel() As Object
	Public Property KeyboardLayout() As String
	Public Property TimeZone() As String
	Public Property LogonServer() As String
	Public Property PowerPlatformRole() As Integer
	Public Property HyperVisorPresent() As Boolean
	Public Property HyperVRequirementDataExecutionPreventionAvailable() As Object
	Public Property HyperVRequirementSecondLevelAddressTranslation() As Object
	Public Property HyperVRequirementVirtualizationFirmwareEnabled() As Object
	Public Property HyperVRequirementVMMonitorModeExtensions() As Object
	Public Property DeviceGuardSmartStatus() As Integer
	Public Property DeviceGuardRequiredSecurityProperties() As Integer()
	Public Property DeviceGuardAvailableSecurityProperties() As Integer()
	Public Property DeviceGuardSecurityServicesConfigured() As Integer()
	Public Property DeviceGuardSecurityServicesRunning() As Integer()
	Public Property DeviceGuardCodeIntegrityPolicyEnforcementStatus() As Object
	Public Property DeviceGuardUserModeCodeIntegrityPolicyEnforcementStatus() As Object

	Public Overrides Function ToString() As String
		Return $"{WindowsRegisteredOwner}"
	End Function
End Class