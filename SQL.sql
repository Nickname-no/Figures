create table Category
(
  Id bigint primary key,
  Name varchar(64) 
);

create table Product
(
  Id bigint primary key,
  Name varchar(64)
);

create table ProductCategory
(
 IdProduct bigint,
 IdCategory bigint,
 foreign key (IdCategory) references  Category(Id),
 foreign key (IdProduct) references Product(ID) 
);

select P.Name ProductName, C.Name CategoryName 
from Product P
left join ProductCategory PC on P.Id = PC.IdProduct
left join Category C on PC.IdCategory = C.Id;

