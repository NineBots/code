from fastapi import FastAPI, Path, Query
from typing import Optional

app = FastAPI()

@app.get("/course/{num_course}")
async def main_menu(num_course:int = Path(ge = 1, le=5,  description="num_course")):
    response = {'num_course': num_course}
    return response