REM Delete previous artifacts
DEL archmgr.msi
SET PATH=C:\Program Files\7-Zip;C:\Program Files (x86)\WiX Toolset v3.7\bin\;%PATH%

REM Create installer
candle archmgr.wxs
light archmgr.wixobj

PAUSE