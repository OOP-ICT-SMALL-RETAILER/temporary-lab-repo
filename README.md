# Электронная торговая площадка для мелких производителей

![IDEF1X (4)](https://github.com/OOP-ICT-SMALL-RETAILER/temporary-lab-repo/assets/112976482/f7ed2d81-8bbc-4cdd-bc9d-5acd807c5a88)

Мы работаем над электронной торговой площадкой для мелких производителей (из похожих - яндекс маркет)

В сервисе существует два вида аккаунтов - магазин, у которого есть товары
и покупатель, который может заказать товары и получить их в пункте выдачи(без доставки на дом)


(потребности пункта выдачи и курьеров - игнорируются)

# Описание взаимодействия с сайтом

## Со стороны пользователя

Регистрация:
после регистрации пользователю выдаются файлы cookie, которые хранятся локально и должны прикладываться к каждому запросу, касающемуся пользователя

Возможность залогиниться/разлогиниться:
сделан учет файлов cookie, чтобы они не были вечными

Поиск товара:
- по категории 
- по названию 
- по продавцу 
- по артикулу 

Добавление товара в корзину

Оплата заказа:
- происходит одна транзакция со стороны пользователя
- банк/платежная система как-то перенаправит прибыль магазинам сама
- выбор пункта выдачи

Оставление отзыва на товар (с и без вложений):
- рейтинг
- текст
- фото


## Со стороны магазина

Создание аккаунта продавца 

Создание товара 

Изменение свойств товара:
- цена
- размер и наличие скидки
- название
- описание
- категория
- наличие

Просмотр своих продаж


## Шпаргалка по REST

Вставление чувствительной информации в в request, а не в строку запроса
Не передавать лишнюю информацию

Методы:
GET - запросить информацию
POST - отправить информацию
PUT - обновить информацию
PATCH - игнорируем, равноценен PUT
DELETE - удаляем, логично


# Эндпоинты

## Пользователь

Файлы cookie - это долгосрочный ключ, который хранится локально.

Регистрация пользователя - POST /user/register
request - {"name": "Иван", "email": "ivan@example.com", "password": "password123"}
response - {"userCookie": "5n6w4k5j6"}

Залогиниться на новом устройстве - GET /user/login
request - {"email": "ivan@example.com", "password": "password123"}
responce - {"userCookie": "5n6w4k5j7"}

Разлогиниться на этом устройстве - POST user/logout
request -  {"userCookie": "5n6w4k5j6"}
response - {“message”: “you have logged out of your account”}

Разлогиниться со всех устройств - POST user/logout/total
request - {"email": "ivan@example.com", "password": "password123"}
response - {“message”: “you have logged out of your account on all devices”}

Выбор предпочтительного пункта выдачи - POST /user/address
request - {“userCookie”: "5n6w4k5j6", “ID выбранного пункта выдачи”: “aebaebebebebebe”}


## Отзыв

Создание отзыва на товар - POST /reviews/create
request - {"userCookie": "5n6w4k5j6", reviewId: “7y8ujn65jnk5j6nkf”,  "productID": "3h42k5j56", "rating": 4, "comment": "Отличный товар, всем рекомендую!"}
response - {"message": "Отзыв успешно добавлен"}

Удаление отзыва - DELETE api/v1/reviews/delete
request - {"userCookie": "5n6w4k5j6", "reviewId":"7y8ujn65jnk5j6nkf"}
response - {"message":"Отзыв успешно удален"}
 
Редактирование отзыва - PUT api/v1/reviews/change
request - {"userCookie": "5n6w4k5j6", "reviewId":"7y8ujn65jnk5j6nkf", ?"rating": 4, ?"comment": "Товар неплохой, но есть небольшие недочеты"}
response - {"message":"Отзыв успешно изменен"}

Получение всех отзывов на товар - 


## Корзина

Получение списка товаров в корзине - GET - /cart/
request - {"userCookie": "5n6w4k5j6"}
response - {“productID”: “3h42k5j56”, “quantity”: 1}, {“productID”: “abcd1234”, “quantity”: 3}

Добавление товара в корзину - POST /cart/add
request - {"userCookie": "5n6w4k5j6", "productID": "3h42k5j56", "quantity": 1}
response - {"message": "Товар успешно добавлен в корзину"}

Удаление товара из корзины - DELETE /cart/remove
request - { "userCookie": "5n6w4k5j6", "productID": "3h42k5j56"}
response - {"message": "Товар успешно удален из корзины"}

​​Изменение количества товара в корзине - PUT /cart/update quantity
request - {"userCookie": "5n6w4k5j6", "productID": "abcd1234", "quantity": 3}
response - {"message": "Количество товара изменено"}

Создание счета/чека на оплату - POST /cart/checkout
request - {"userCookie": "5n6w4k5j6"}
response - {"orderID": "inv123456", "totalAmount": 150.00, "paymentDueDate": "2022-05-30", "paymentLink": "https://paymentprovider.com/pay/inv123456", "invoiceEmail": "name@example.com"} —-на этом моменте отслеживание заканчивается, так как товар точно оплачен


## Товар
Получение списка товаров - GET /products{?product_name_like;?product_category;?product_price;?product_seller;?product_rating}
request - {}
response - {"products": [{"id": 1, "name": "Товар 1", "price": 50.0, "description": "Описание товара 1"}, {"id": 2, "name": "Товар 2", "price": 70.0, "description": "Описание товара 2"}, ...]}

Получение информации о товаре - GET /products/{product_id}/
request  - {}
response - {"id": 1, "name": "Товар 1", "current_price": 50.0, "description": "Описание товара 1", “rating”: 3.9, “is listed”: true}

Добавление нового товара - POST /products/new
request - {“shop_cookie”: “babba34b2”, "name": "Новый товар", "price": 80.0, "description": "Описание нового товара"}
response - {"productID": "7er54w6n46l5nw4ln6w54"}

Редактирование информации о товаре - PUT /products/{productID}
request - {“shop_cookie”: “babba34b2”, ?"name": "Новое название товара", ?"price": 90.0, ?"description": "Новое описание товара", ?”sale%”: 100, ?”delisted”: false}
response - {"message": "Информация о товаре успешно обновлена"}

Удаление товара - DELETE /products/{productID}
request - {“shop_cookie”: “babba34b2}
response - {"message": "Товар успешно удален"}

## Магазин
Регистрация магазина - POST /shop/register
request - {"name": "Иван", "email": "ivan@example.com", "password": "password123"}
response - {"shopCookie": "5n6w4k5j6"}

Залогиниться на новом устройстве - GET /shop/login
request - {"email": "ivan@example.com", "password": "password123"}
responce - {"shopCookie": "5n6w4k5j7"}

Разлогиниться на этом устройстве - POST /shop/logout
request -  {"shopCookie": "5n6w4k5j6"}
response - {“message”: “you have logged out of your account”}

Разлогиниться со всех устройств - POST /shop/logout/total
request - {"email": "ivan@example.com", "password": "password123"}
response - {“message”: “you have logged out of your account on all devices”}

Просмотр продаж - GET /shop/sales{?date_from;?date_to}
request - {“shopCookie”: "5n6w4k5j6"}
response - {“7er54w6n46l5nw4ln6w54”: “56900р”, “7er54wbh145nw4ln6bhi”: “98700р”}

## Адрес
Просмотр адреса - GET /address/search{?adress_text;?city_name;?street_name}
Request - {}
Response - {“г. Санкт-Петербург, Улица Ленина, д.4”: “aeb” , 
   “г. Москва, Улица Ленина, д.4”: “bebebe”, 
   “г. Сыктывкар, Улица Ленина, д.4”: “babbabab”, 
   “г. Тюмень, Улица Ленина, д.4”: “bibibi”}

## Заказ
Просмотр информации о последнем заказе - GET /orders/{orderID}
request - {"userCookie": "5n6w4k5j6"}
response - {"orderID": "4w5l6jn4wlk5j6nw4lk56", "status": "В обработке", "totalPrice": 107.5, "products": [{"id": 1, "name": "Тестовый товар", "quantity": 1}, ...]}

Просмотр всех своих заказов - GET /orders/history
request - {“userCookie”: “5n6w4k5j6”}
response - [{"product_id": 1, "quantity": 2},
    {"product_id": 2, "quantity": 1},
    {"product_id": 3,  "quantity": 3}]


Отмена заказа - POST /orders/{orderID}/cancel
request - {"userCookie": "5n6w4k5j6"}
response - {"message": "Заказ успешно отменен"}


```
