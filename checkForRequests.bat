@echo off
python -c "import requests" > nul 2>&1

if %errorlevel% equ 0 (
    echo requests �Ҳդw�g�w�ˡC
    exit /b 0
) else (
    echo requests �Ҳե��w�ˡA���b�w��...
    pip install requests
    if %errorlevel% neq 0 (
        echo �w�˥��ѡA���ˬd�����s���M pip �w�ˡC
        exit /b 1
    ) else (
        echo �w�˦��\�I
        exit /b 0
    )
)
