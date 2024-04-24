
# Course work

Main idea of this project is to create restoraunt website with all the nessesary functions like ordering the dishes, tracking the order and so on

## Some important links related to this project

 - [Use-case diagram](https://www.figma.com/file/mbhrickLvkIBbXkFyfdiFc/CourseWorkUseCaseDiagram?type=design&node-id=0-1&mode=design&t=qbFiTVkbGP1u0ULh-0)
 
## Run Locally

Create a localserver using cmd

```bash
  sqllocaldb create “CourseWork”
```

Go to the SSMS and use the Server name bellow to connect

```bash
  (localdb)\CourseWork
```

Create new query window and run next command

```bash
  CREATE DATABASE CourseWorkDb;
```

Connect to newly created database and run next commands 

```bash
  CREATE TABLE Dishes (
    dish_id UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID(),
    dish_name VARCHAR(30) NOT NULL,
    dish_type VARCHAR(30) NOT NULL,
    restaurant_type VARCHAR(30) NOT NULL,
    dish_price INT NOT NULL,
    in_stock BIT NOT NULL
);

CREATE TABLE Menus (
    menu_id UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID(),
    menu_name VARCHAR(30) NOT NULL,
    in_stock BIT NOT NULL
);

CREATE TABLE MenuDishes (
    menu_id UNIQUEIDENTIFIER NOT NULL,
    dish_id UNIQUEIDENTIFIER NOT NULL,
    PRIMARY KEY (menu_id, dish_id),
    FOREIGN KEY (menu_id) REFERENCES Menus(menu_id),
    FOREIGN KEY (dish_id) REFERENCES Dishes(dish_id)
);

CREATE TABLE UserQuestions (
    question_id UNIQUEIDENTIFIER PRIMARY KEY,
    question_text VARCHAR(300) NOT NULL
);

```


## Authors

- [@Fawa24](https://github.com/Fawa24)
