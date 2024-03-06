import uvicorn
from fastapi import FastAPI, Depends
from sqlalchemy.orm import Session
import os
from database import SessionLocal, engine
import models, schemas, crud


app = FastAPI()

def get_db():
    db = SessionLocal()
    try:
        yield db
    finally:
        db.close()

@app.get('/api/v1/menus' , response_model=list[schemas.Menu])
def read_menus(db: Session = Depends (get_db)):
    menus = crud.get_menus(db)
    return menus

@app.get('/api/v1/menus/{target_menu_id}/', response_model=schemas.Menu)
def read_menu(target_menu_id: int, db: Session = Depends (get_db)):
    menu = crud.get_menu(db, target_menu_id)
    menu.count = len(menu.under_menus)
    return menu

@app.post('/api/v1/menus', response_model=schemas.Menu, status_code=201)
def create_menu( menu: schemas.CreateMenu, db: Session = Depends (get_db)):
    return crud.create_menu(db, menu)

@app.delete('/api/v1/menus/{target_menu_id}/')
def delete_menu( target_menu_id: int, db: Session = Depends (get_db)):
    return crud.remove_menu(db, target_menu_id)

@app.patch('/api/v1/menus/{target_menu_id}/', response_model=schemas.Menu)
def update_menu( target_menu_id: int, title: str, description:str,  db: Session = Depends (get_db)):
    menu = crud.get_menu(db, target_menu_id)
    menu.title = title
    menu.description = description
    db.commit()
    return menu

if __name__ == "__main__":
    uvicorn.run(app, host="127.0.0.1", port=8000)





