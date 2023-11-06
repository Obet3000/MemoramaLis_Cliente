@echo off
setlocal enabledelayedexpansion

cd /d "%~dp0"

set "count=0"

for /f %%f in ('dir /b /a-d') do (
    set /a "count+=1"
    echo [!count!] %%f
)

endlocal
