from time import sleep

from bs4 import BeautifulSoup
from selenium import webdriver
from selenium.webdriver.common.by import By


import requests, lxml

#link = "http://students.perm.hse.ru/timetable"

#headers = {"User-Agent": "Mozilla/5.0 (Linux; Android 6.0; Nexus 5 Build/MRA58N) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/116.0.5845.837 Mobile Safari/537.36",
#         "Accept" : "* / *",
#}

#req = requests.get(link, headers=headers)



with open ("timetable.html", encoding='utf-8') as f:
    src = f.read()

soup = BeautifulSoup(src,'lxml')

links = soup.find_all(class_ = "link mceDataFile")

driver = webdriver.Chrome()

for link in links:
    driver.get(f"http://students.perm.hse.ru{link.get('href')}")
    sleep(2)


