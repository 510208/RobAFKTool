import requests
import subprocess

import subprocess

# 定義 check_for_requests 函數
def check_for_requests():
    # 定義要運行的批處理檔案的路徑
    batch_file_path = "checkForRequests.bat"
    # 使用 subprocess 模塊執行批處理檔案並獲取輸出
    output = subprocess.check_output(batch_file_path, shell=True)
    # 將輸出打印到終端
    print(output.decode('ansi'))

# 執行 check_for_requests 函數
check_for_requests()

# 當前版本號
current_version = '1.0.0.0'

# 定義用戶名與儲存庫名
github_un = "510208"
github_repo = "RobAFKTool"

# 獲取 GitHub 上的版本號和更新日誌
print(f'https://api.github.com/repos/{github_un}/{github_repo}/releases/latest')
response = requests.get(f'https://api.github.com/repos/{github_un}/{github_repo}/releases/latest')
latest_version = response.json()['tag_name']
changelog = response.json()['body']

# 比較當前版本號和最新版本號
if latest_version > current_version:
    print(f'最新版本號：{latest_version}\n\n更新日誌：\n{changelog}\n\n是否下載新版本？')
else:
    print('目前為最新版本')
