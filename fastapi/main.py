
from typing import Optional

import uvicorn

from fastapi import FastAPI, Path, Query, Body, Request
from pydantic import BaseModel

app = FastAPI(
    title="TestApi"
)

@app.get("/")
async def print_hello():
    return {'message': 'Hello World!'}

if __name__ == "__main__":
    uvicorn.run("main:app", host="127.0.0.1", port=8000, reload=True)

@app.get('/{name}')
async def get_user(name: str, age: Optional[int] = Query(None, gt=5)):
    return {'name': name, 'age': age}

@app.post('/product')
async def add_new(request: Request, prodId: int = Body(), prodName:str = Body(), price:float = Body(), stock:int = Body() ):
    product = {"Prodict Id": prodId, 'Product Name':prodName, "Price": price, "Stock": stock}
    return product
