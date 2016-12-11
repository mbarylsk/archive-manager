REM Delete previous artifacts
DEL /F /Q ..\..\archmgr.msi
SET PATH=C:\Program Files\7-Zip;C:\Program Files (x86)\WiX Toolset v3.7\bin\;%PATH%

REM Create installer
candle archmgr.wxs
light archmgr.wixobj

REM Deploy installer
MOVE archmgr.msi ..\..\WebPage\pobierz

PAUSE