from dotenv import load_dotenv
import os

load_dotenv()

db_host= os.environ.get("db_host")
db_port= os.environ.get("db_port")
db_name= os.environ.get("db_name")
db_user= os.environ.get("db_user")
db_pass= os.environ.get("db_pass")