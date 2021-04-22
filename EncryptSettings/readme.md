# About 

Provides starter code for encryp/decrypt strings for, in this case securing details we don't want prying eyes to see in user.config file.

Created using `VS2019`, .NET Framework `4.8`

```xml
<?xml version="1.0" encoding="utf-8"?>
<configuration>
    <userSettings>
        <EncryptSettings.My.MySettings>
            <setting name="UserName" serializeAs="String">
                <value>AQAAANCMnd8BFdERjHoAwE/Cl+sBAAAAeyGgHNEX6UeW1fJWdfqQbgAAAAACAAAAAAADZgAAwAAAABAAAABZFC4XA/X8wjGciCFs/ZrrAAAAAASAAACgAAAAEAAAAJcw4MWAdi4DzluIZ1zVhVsQAAAA4Uv2uISf/V+FHI9xjWobGRQAAABPipwy+z89Ke3WM9ohlfGQGogZdw==</value>
            </setting>
            <setting name="UserPassword" serializeAs="String">
                <value>AQAAANCMnd8BFdERjHoAwE/Cl+sBAAAAeyGgHNEX6UeW1fJWdfqQbgAAAAACAAAAAAADZgAAwAAAABAAAABC5iAejR5qnLmgl1ArNIhYAAAAAASAAACgAAAAEAAAAFyO424vTqpo2RQpNm3bKaEYAAAA2ZR5rfz7lpEPD+kCeE2bgy1ycxeAzniQFAAAAKh4FJtpAyUJcr3Z0rbg3ikiJz6C</value>
            </setting>
        </EncryptSettings.My.MySettings>
    </userSettings>
</configuration>
```

# Requires

NuGet package [System.Security.Cryptography.ProtectedData -Version 5.0.0](https://www.nuget.org/packages/System.Security.Cryptography.ProtectedData/6.0.0-preview.3.21201.4)

![img](assets/vb1.png)

![img](assets/ConventionFramework.png)