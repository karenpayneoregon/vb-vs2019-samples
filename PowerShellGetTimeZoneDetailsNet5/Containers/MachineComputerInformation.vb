Imports System.ComponentModel
Imports System.Text.Json.Serialization

Namespace Containers

    <Category("Computer information"), Description("Details from PowerShell")>
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
        <DisplayName("Characteristics"), Category("Bios")>
        Public Property BiosCharacteristics() As Integer()
        <DisplayName("BIOS Version"), Category("Bios")>
        Public Property BiosBIOSVersion() As String()
        <DisplayName("Build Number"), Category("Bios")>
        Public Property BiosBuildNumber() As Object
        <DisplayName("Caption"), Category("Bios")>
        Public Property BiosCaption() As String
        <DisplayName("Code Set"), Category("Bios")>
        Public Property BiosCodeSet() As Object
        <DisplayName("Current Language"), Category("Bios")>
        Public Property BiosCurrentLanguage() As String
        <DisplayName("Description"), Category("Bios")>
        Public Property BiosDescription() As String
        <DisplayName("Embedded Controller Major Version"), Category("Bios")>
        Public Property BiosEmbeddedControllerMajorVersion() As Integer
        <DisplayName("Embedded Controller Minor Version"), Category("Bios")>
        Public Property BiosEmbeddedControllerMinorVersion() As Integer
        <DisplayName("Firmware Type"), Category("Bios")>
        Public Property BiosFirmwareType() As Integer
        <Category("Bios")>
        Public Property BiosIdentificationCode() As Object
        <Category("Bios")>
        Public Property BiosInstallableLanguages() As Integer
        <Category("Bios")>
        Public Property BiosInstallDate() As Object
        <Category("Bios")>
        Public Property BiosLanguageEdition() As Object
        <Category("Bios")>
        Public Property BiosListOfLanguages() As String()
        <Category("Bios")>
        Public Property BiosManufacturer() As String
        <Category("Bios")>
        Public Property BiosName() As String
        <Category("Bios")>
        Public Property BiosOtherTargetOS() As Object
        <Category("Bios")>
        Public Property BiosPrimaryBIOS() As Boolean
        <Category("Bios")>
        Public Property BiosReleaseDate() As DateTime
        <Category("Bios")>
        Public Property BiosSeralNumber() As String
        <Category("Bios")>
        Public Property BiosSMBIOSBIOSVersion() As String
        <Category("Bios")>
        Public Property BiosSMBIOSMajorVersion() As Integer
        <Category("Bios")>
        Public Property BiosSMBIOSMinorVersion() As Integer
        <Category("Bios")>
        Public Property BiosSMBIOSPresent() As Boolean
        <Category("Bios")>
        Public Property BiosSoftwareElementState() As Integer
        <Category("Bios")>
        Public Property BiosStatus() As String
        <Category("Bios")>
        Public Property BiosSystemBiosMajorVersion() As Integer
        <Category("Bios")>
        Public Property BiosSystemBiosMinorVersion() As Integer
        <Category("Bios")>
        Public Property BiosTargetOperatingSystem() As Integer
        <Category("Bios")>
        <DisplayName("Bios Version")>
        Public Property BiosVersion() As String
        <Category("Bios")>
        <DisplayName("Admin Password Status")>
        Public Property CsAdminPasswordStatus() As Integer
        <DisplayName("Automatic Managed Pagefile")>
        Public Property CsAutomaticManagedPagefile() As Boolean
        <Category("CS")>
        <DisplayName("Automatic Reset Boot Option")>
        Public Property CsAutomaticResetBootOption() As Boolean
        <Category("CS")>
        Public Property CsAutomaticResetCapability() As Boolean
        <Category("CS")>
        Public Property CsBootOptionOnLimit() As Object
        <Category("CS")>
        Public Property CsBootOptionOnWatchDog() As Object
        <Category("CS")>
        Public Property CsBootROMSupported() As Boolean
        <Category("CS")>
        Public Property CsBootStatus() As Integer()
        <Category("CS")>
        Public Property CsBootupState() As String
        <Category("CS")>
        Public Property CsCaption() As String
        <Category("CS")>
        Public Property CsChassisBootupState() As Integer
        <Category("CS")>
        Public Property CsChassisSKUNumber() As String
        <Category("CS")>
        Public Property CsCurrentTimeZone() As Integer
        <Category("CS")>
        Public Property CsDaylightInEffect() As Boolean
        <Category("CS")>
        Public Property CsDescription() As String
        <Category("CS")>
        Public Property CsDNSHostName() As String
        <Category("CS")>
        Public Property CsDomain() As String
        <Category("CS")>
        Public Property CsDomainRole() As Integer
        <Category("CS")>
        Public Property CsEnableDaylightSavingsTime() As Boolean
        <Category("CS")>
        Public Property CsFrontPanelResetStatus() As Integer
        <Category("CS")>
        Public Property CsHypervisorPresent() As Boolean
        <Category("CS")>
        Public Property CsInfraredSupported() As Boolean
        <Category("CS")>
        Public Property CsInitialLoadInfo() As Object
        <Category("CS")>
        Public Property CsInstallDate() As Object
        <Category("CS")>
        Public Property CsKeyboardPasswordStatus() As Integer
        <Category("CS")>
        Public Property CsLastLoadInfo() As Object
        <Category("CS")>
        Public Property CsManufacturer() As String
        <Category("CS")>
        Public Property CsModel() As String
        <Category("CS")>
        Public Property CsName() As String
        <Category("Network adapter")>
        Public Property CsNetworkAdapters() As Csnetworkadapter()
        <Category("CS")>
        Public Property CsNetworkServerModeEnabled() As Boolean
        <Category("CS")>
        Public Property CsNumberOfLogicalProcessors() As Integer
        <Category("CS")>
        Public Property CsNumberOfProcessors() As Integer
        <Category("CS")>
        Public Property CsProcessors() As Csprocessor()
        <Category("CS")>
        Public Property CsOEMStringArray() As String()
        <Category("CS")>
        Public Property CsPartOfDomain() As Boolean
        <Category("CS")>
        Public Property CsPauseAfterReset() As Integer
        <Category("CS")>
        Public Property CsPCSystemType() As Integer
        <Category("CS")>
        Public Property CsPCSystemTypeEx() As Integer
        <Category("CS")>
        Public Property CsPowerManagementCapabilities() As Object
        <Category("CS")>
        Public Property CsPowerManagementSupported() As Object
        <Category("CS")>
        Public Property CsPowerOnPasswordStatus() As Integer
        <Category("CS")>
        Public Property CsPowerState() As Integer
        <Category("CS")>
        Public Property CsPowerSupplyState() As Integer
        <Category("CS")>
        Public Property CsPrimaryOwnerContact() As Object
        <Category("CS")>
        Public Property CsPrimaryOwnerName() As String
        <Category("CS")>
        Public Property CsResetCapability() As Integer
        <Category("CS")>
        Public Property CsResetCount() As Integer
        <Category("CS")>
        Public Property CsResetLimit() As Integer
        <Category("CS")>
        Public Property CsRoles() As String()
        <Category("CS")>
        Public Property CsStatus() As String
        <Category("CS")>
        Public Property CsSupportContactDescription() As Object
        <Category("CS")>
        Public Property CsSystemFamily() As String
        <Category("CS")>
        Public Property CsSystemSKUNumber() As String
        <Category("CS")>
        Public Property CsSystemType() As String
        <Category("CS")>
        Public Property CsThermalState() As Integer
        <Category("CS")>
        Public Property CsTotalPhysicalMemory() As Long
        <Category("CS")>
        Public Property CsPhyicallyInstalledMemory() As Integer
        <Category("CS")>
        Public Property CsUserName() As String
        <Category("CS")>
        Public Property CsWakeUpType() As Integer
        <Category("CS")>
        Public Property CsWorkgroup() As Object
        <Category("OS")>
        Public Property OsName() As String
        <Category("OS")>
        Public Property OsType() As Integer
        <Category("OS")>
        Public Property OsOperatingSystemSKU() As Integer
        <Category("OS")>
        Public Property OsVersion() As String
        <Category("OS")>
        Public Property OsCSDVersion() As Object
        Public Property OsBuildNumber() As String
        <Category("OS")>
        Public Property OsHotFixes() As Oshotfix()
        <Category("OS")>
        Public Property OsBootDevice() As String
        <Category("OS")>
        Public Property OsSystemDevice() As String
        <Category("OS")>
        Public Property OsSystemDirectory() As String
        <Category("OS")>
        Public Property OsSystemDrive() As String
        <Category("OS")>
        Public Property OsWindowsDirectory() As String
        <Category("OS")>
        Public Property OsCountryCode() As String
        <Category("OS")>
        Public Property OsCurrentTimeZone() As Integer
        <Category("OS")>
        Public Property OsLocaleID() As String
        <Category("OS")>
        Public Property OsLocale() As String
        <Category("OS")>
        Public Property OsLocalDateTime() As DateTime
        <Category("OS")>
        Public Property OsLastBootUpTime() As DateTime
        <Category("OS")>
        Public Property OsUptime() As Osuptime
        <Category("OS")>
        Public Property OsBuildType() As String
        <Category("OS")>
        Public Property OsCodeSet() As String
        <Category("OS")>
        Public Property OsDataExecutionPreventionAvailable() As Boolean
        <Category("OS")>
        Public Property OsDataExecutionPrevention32BitApplications() As Boolean
        <Category("OS")>
        Public Property OsDataExecutionPreventionDrivers() As Boolean
        <Category("OS")>
        Public Property OsDataExecutionPreventionSupportPolicy() As Integer
        <Category("OS")>
        Public Property OsDebug() As Boolean
        <Category("OS")>
        Public Property OsDistributed() As Boolean
        <Category("OS")>
        Public Property OsEncryptionLevel() As Integer
        <Category("OS")>
        Public Property OsForegroundApplicationBoost() As Integer
        <Category("OS")>
        Public Property OsTotalVisibleMemorySize() As Integer
        <Category("OS")>
        Public Property OsFreePhysicalMemory() As Integer
        <Category("OS")>
        Public Property OsTotalVirtualMemorySize() As Integer
        <Category("OS")>
        Public Property OsFreeVirtualMemory() As Integer
        <Category("OS")>
        Public Property OsInUseVirtualMemory() As Integer
        <Category("OS")>
        Public Property OsTotalSwapSpaceSize() As Object
        <Category("OS")>
        Public Property OsSizeStoredInPagingFiles() As Integer
        <Category("OS")>
        Public Property OsFreeSpaceInPagingFiles() As Integer
        <Category("OS")>
        Public Property OsPagingFiles() As String()
        <Category("OS")>
        Public Property OsHardwareAbstractionLayer() As String
        <Category("OS")>
        Public Property OsInstallDate() As DateTime
        <Category("OS")>
        Public Property OsManufacturer() As String
        <Category("OS")>
        Public Property OsMaxNumberOfProcesses() As Long
        <Category("OS")>
        Public Property OsMaxProcessMemorySize() As Long
        <Category("OS")>
        Public Property OsMuiLanguages() As String()
        <Category("OS")>
        Public Property OsNumberOfLicensedUsers() As Object
        <Category("OS")>
        Public Property OsNumberOfProcesses() As Integer
        <Category("OS")>
        Public Property OsNumberOfUsers() As Integer
        <Category("OS")>
        Public Property OsOrganization() As String
        <Category("OS")>
        Public Property OsArchitecture() As String
        <Category("OS")>
        Public Property OsLanguage() As String
        <Category("OS")>
        Public Property OsProductSuites() As Integer()
        <Category("OS")>
        Public Property OsOtherTypeDescription() As Object
        <Category("OS")>
        Public Property OsPAEEnabled() As Object
        <Category("OS")>
        Public Property OsPortableOperatingSystem() As Boolean
        <Category("OS")>
        Public Property OsPrimary() As Boolean
        <Category("OS")>
        Public Property OsProductType() As Integer
        <Category("OS")>
        Public Property OsRegisteredUser() As String
        <Category("OS")>
        Public Property OsSerialNumber() As String
        <Category("OS")>
        Public Property OsServicePackMajorVersion() As Integer
        <Category("OS")>
        Public Property OsServicePackMinorVersion() As Integer
        <Category("OS")>
        Public Property OsStatus() As String
        <Category("OS")>
        Public Property OsSuites() As Integer()
        <Category("OS")>
        Public Property OsServerLevel() As Object
        <Category("OS")>
        Public Property KeyboardLayout() As String
        <Category("OS")>
        Public Property TimeZone() As String
        <Category("OS")>
        Public Property LogonServer() As String
        <Category("OS")>
        Public Property PowerPlatformRole() As Integer
        <Category("OS")>
        Public Property HyperVisorPresent() As Boolean
        <Category("HyperV")>
        Public Property HyperVRequirementDataExecutionPreventionAvailable() As Object
        <Category("HyperV")>
        Public Property HyperVRequirementSecondLevelAddressTranslation() As Object
        <Category("HyperV")>
        Public Property HyperVRequirementVirtualizationFirmwareEnabled() As Object
        <Category("HyperV")>
        Public Property HyperVRequirementVMMonitorModeExtensions() As Object
        <Category("HyperV")>
        Public Property DeviceGuardSmartStatus() As Integer
        <Category("Devices")>
        Public Property DeviceGuardRequiredSecurityProperties() As Integer()
        <Category("Devices")>
        Public Property DeviceGuardAvailableSecurityProperties() As Integer()
        <Category("Devices")>
        Public Property DeviceGuardSecurityServicesConfigured() As Integer()
        <Category("Devices")>
        Public Property DeviceGuardSecurityServicesRunning() As Integer()
        <Category("Devices")>
        Public Property DeviceGuardCodeIntegrityPolicyEnforcementStatus() As Object
        <Category("Devices")>
        Public Property DeviceGuardUserModeCodeIntegrityPolicyEnforcementStatus() As Object


        Public Overrides Function ToString() As String
            Return $"{WindowsRegisteredOwner}"
        End Function
    End Class
End Namespace