@echo off
python -c "import requests" > nul 2>&1

if %errorlevel% equ 0 (
    echo requests 模組已經安裝。
    exit /b 0
) else (
    echo requests 模組未安裝，正在安裝...
    pip install requests
    if %errorlevel% neq 0 (
        echo 安裝失敗，請檢查網路連接和 pip 安裝。
        exit /b 1
    ) else (
        echo 安裝成功！
        exit /b 0
    )
)
