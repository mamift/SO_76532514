
Run VS2022 developer command prompt:
`%comspec% /k "C:\Program Files\Microsoft Visual Studio\2022\Professional\Common7\Tools\VsDevCmd.bat"`

XSD.exe executing should be:
`C:\Program Files (x86)\Microsoft SDKs\Windows\v10.0A\bin\NETFX 4.8 Tools\xsd.exe`

Run comamnd to generate VB code
`xsd .\PathDetailMessage.xsd /l:VB /c /namespace:infofer`

Dont run xsd on the Common_Elements.xsd as it's redundant, it's included by PathDetailMessage.xsd
