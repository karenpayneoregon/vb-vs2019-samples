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

Also using the same method above we can do a json file.

```json
{
  "UserName": "AQAAANCMnd8BFdERjHoAwE/Cl+sBAAAAeyGgHNEX6UeW1fJWdfqQbgAAAAACAAAAAAADZgAAwAAAABAAAADE+2HrEB+FxKBavWYqCqYhAAAAAASAAACgAAAAEAAAAPDLmEW3NYC/xO3N/Wj5XpgQAAAAq8DaWpFFvhFuKswKuaMDKxQAAABr8AyT0sbsw9vaBipgtpVPP9mnug==",
  "UserPassword": "AQAAANCMnd8BFdERjHoAwE/Cl+sBAAAAeyGgHNEX6UeW1fJWdfqQbgAAAAACAAAAAAADZgAAwAAAABAAAADkMR+W6HYYNSISdxKbyV7gAAAAAASAAACgAAAAEAAAAMq7LPuGsnsiq7Rbi1KaZB4YAAAAOoxjALdhYocdhCvqV4BO2jzVEn/SiTwIFAAAAI4KcHcFhacHoQZtv90IAFBNQ7NQ",
  "UseDefaultCredentials": false
}
```

# Requires

NuGet packages

:heavy_check_mark: [System.Security.Cryptography.ProtectedData -Version 5.0.0](https://www.nuget.org/packages/System.Security.Cryptography.ProtectedData/6.0.0-preview.3.21201.4)
:heavy_check_mark: [Newtonsoft.Json](https://www.nuget.org/packages/Newtonsoft.Json/)

![img](assets/vb1.png)

![img](assets/ConventionFramework.png)