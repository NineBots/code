from sqlalchemy import MetaData, Table, Column, Integer, String, TIMESTAMP, ForeignKey
from database import Base
from sqlalchemy.orm import relationship, backref

metadata = MetaData()

class Menu (Base):
    __tablename__ = 'menu'
    id = Column( Integer, primary_key=True, autoincrement=True)
    title = Column( String)
    description = Column( String)
    count_under_menus = Column(Integer, nullable=True, default=0)
    # under_menus = relationship("UnderMenus", back_populates='under_menu', cascade="all,delete")
    under_menus = relationship('Under_menu', passive_deletes= True, backref='menu')


class Under_menu (Base):
    __tablename__ = "under_menu"
    id = Column( Integer, primary_key=True , autoincrement=True)
    name = Column( String)
    menu_id = Column( Integer, ForeignKey("menu.id", ondelete="CASCADE"))
    # menu = relationship("Menu", back_populates='menu', backref=backref('under_menu', passive_deletes = True))
    count_dishes = Column(Integer)
    # dishes = relationship("Dishes", back_populates='dish', cascade='all,delete')
    dishes = relationship('Dish', passive_deletes= True, backref='under_menu')




class Dish (Base):
    __tablename__ = "dish"
    id = Column( Integer, primary_key=True , autoincrement=True)
    name = Column( String)
    under_menu_id = Column( Integer, ForeignKey("under_menu.id", ondelete="CASCADE"))
    # under_menu = relationship("Under_menu", back_populates='under_menu', backref=backref('dish', passive_deletes = True))

