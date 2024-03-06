import requests
from bs4 import BeautifulSoup
import urllib.request
import pandas as pd
import xlrd
from openpyxl import load_workbook, Workbook

def collect_urls(): ##сбор ссылок для загрузки файлов
    page_url = 'http://students.perm.hse.ru/timetable'
    req = requests.get(page_url)
    bs = BeautifulSoup(req.text, 'html.parser')

    all_items = bs.find_all('a', class_='link mceDataFile')

    urls = []
    for item in all_items:

        urls.append(['http://students.perm.hse.ru' + item.get('href'), item.get_text()])

    return urls

def load_file(url): ## загрузка по одному файлу
    url[0] = url[0].replace('//www.hse.ru', '')

    url_changed = url[0].split('/')
    year = url_changed[4]
    month = url_changed[5]
    day = url_changed[6]
    time = url_changed[7]

    urllib.request.urlretrieve(url[0], f'./schedules/{year}_{month}_{day}_{time}({url[1]}).xlsx')

def delete_badRows():
    wb2 = load_workbook('./schedules/2024_01_16_2104399332(Расписание занятий (неделя №2 c 15.01.2024) с изм.16.01.24).xls')
    for worksheet in wb2:
        worksheet.delete_rows(2)
def moveToJson(file): #перобразовать в json

    data = pd.read_excel(file, sheet_name='1 курс')
    print(data)

for url in collect_urls(): #собрать ссылки
    load_file(url)

#moveToJson("./schedules/2023_12_21_2099198102(Расписание занятий (неделя №9 c 25.12.2023) СЕССИЯ с изм. 21.12.23).xls")
delete_badRows()