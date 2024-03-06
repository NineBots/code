from pydantic import BaseModel, Field


########################################################################

class Dish_Base(BaseModel):
    id: int
    name: str


class Dish(Dish_Base):
    under_menu_id: int

    class Config:
        from_attributes = True


class Create_Dish(Dish_Base):
    pass


################################################################
class Under_Menu_Base(BaseModel):
    id: int
    name: str

class Under_Menu(Under_Menu_Base):
    menu_id: int
    dishes: list[Dish] = []
    count_dishes: int = len(dishes)
    class Config:
        from_attributes = True

class Create_Under_Menu(Under_Menu_Base):
    pass


################################################################
class MenuBase(BaseModel):
    title: str
    description: str

class Menu(MenuBase):
    id: int
    under_menus: list[Under_Menu] = []
    count_under_menus: int = len(under_menus)
    class Config:
        from_attributes = True

class CreateMenu(MenuBase):
    pass







