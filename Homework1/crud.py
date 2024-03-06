from sqlalchemy.orm import Session
import models, schemas

def get_menu(db: Session, menu_id: int):
    return db.query(models.Menu).filter(models.Menu.id == menu_id).first()

def create_menu(db: Session, menu: schemas.CreateMenu):
    new_menu = models.Menu(title= menu.title, description= menu.description)
    db.add(new_menu)
    db.commit()
    db.refresh(new_menu)
    return new_menu

def get_menus(db: Session):
    return db.query(models.Menu).all()

def remove_menu(db: Session, menu_id: int):
    _menu = db.query(models.Menu).filter(models.Menu.id == menu_id).first()
    db.delete(_menu)
    db.commit()



################################################################

def get_under_menu(db: Session, under_menu_id: int):
    return db.query(models.Under_menu).filter(models.Under_menu.id == under_menu_id).first()

def create_under_menu(db: Session, under_menu: schemas.Create_Under_Menu, menu_id:int):
    new_under_menu = models.Under_menu(name = under_menu.name, menu_id = menu_id)
    db.add(new_under_menu)
    db.commit()
    db.refresh(new_under_menu)

def get_under_menus(db: Session):
    return db.query(models.Under_menu).all()

def remove_under_menu(db: Session, under_menu_id: int):
    under_menu = db.query(models.Menu).filter(models.Menu.id == under_menu_id)
    db.delete(under_menu)
    db.commit()

#################################################################

def get_dish(db: Session, dish_id: int):
    return db.query(models.Dish).filter(models.Dish.id == dish_id).first()

def create_dish(db: Session, dish: schemas.Create_Dish, under_menu_id:int):
    new_dish = models.Dish(name = dish.name, under_menu_id = under_menu_id)
    db.add(new_dish)
    db.commit()
    db.refresh(new_dish)

def get_dishes(db: Session):
    return db.query(models.Dish).all()

def remove_dish(db: Session, dish_id: int):
    _dish = db.query(models.Menu).filter(models.Menu.id == dish_id)
    db.delete(_dish)
    db.commit()

