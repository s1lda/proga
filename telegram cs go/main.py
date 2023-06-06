import telebot
from telebot import types
bot = telebot.TeleBot('5622573726:AAFO8fLTSExP6dOek3dIZzKnM0EoHflfxYk')
@bot.message_handler(commands=['start'])  # стартовая команда
def start(message):
    markup = types.ReplyKeyboardMarkup(resize_keyboard=True)
    btn1 = types.KeyboardButton("Mirage")
    btn2 = types.KeyboardButton('Dust 2')
    btn3=types.KeyboardButton('Inferno')
    markup.add(btn1, btn2,btn3)
    bot.send_message(message.from_user.id, "👋 Вас приветствует бот для игры CS:GO", reply_markup=markup)
    bot.send_message(message.from_user.id, '👀 Выберите карту')

@bot.message_handler(content_types=['text'])
def get_text_messages(message):
    # Mirage
    if message.text == 'Mirage':
        markup = types.ReplyKeyboardMarkup(resize_keyboard=True)
        btn1 = types.KeyboardButton('KT Мираж')
        btn2 = types.KeyboardButton('Т Мираж')
        btn3 = types.KeyboardButton('🔙 Вернуться к выбору карты')
        markup.add(btn1, btn2, btn3)
        bot.send_message(message.from_user.id, '👀 Выберите сторону',reply_markup=markup)

    elif message.text == '🔙 Вернуться к выбору карты':
        markup = types.ReplyKeyboardMarkup(resize_keyboard=True)
        btn1 = types.KeyboardButton("Mirage")
        btn2 = types.KeyboardButton('Dust 2')
        btn3 = types.KeyboardButton('Inferno')
        markup.add(btn1, btn2, btn3)
        bot.send_message(message.from_user.id, "👋 Вас приветствует бот для игры CS:GO", reply_markup=markup)
        bot.send_message(message.from_user.id, '👀 Выберите карту')


    #KT MIRAGE
    elif message.text == 'KT Мираж':
        markup = types.ReplyKeyboardMarkup(resize_keyboard=True)
        btn1 = types.KeyboardButton('Апартаменты на B')
        btn2 = types.KeyboardButton('Ковры на A')
        btn3 = types.KeyboardButton('Подвал')
        btn4 = types.KeyboardButton('Рампа на А')
        btn5 = types.KeyboardButton('Топ мид')
        btn6 = types.KeyboardButton('Шорт')
        bnt7=types.KeyboardButton('🔙 Вернуться к выбору карты')
        markup.add(btn1, btn2, btn3, btn4, btn5, btn6,bnt7)
        bot.send_message(message.from_user.id, 'Выберите позицию', reply_markup=markup)

    elif message.text == 'Апартаменты на B':
        markup = types.ReplyKeyboardMarkup(resize_keyboard=True)
        btn1 = types.KeyboardButton('🔙 Позиции за КТ Мираж')
        markup.add(btn1)
        bot.send_message(message.from_user.id, "Куда вставать",reply_markup=markup)
        bot.send_photo(message.from_user.id,photo=open('Апартаменты на В 1.jpg','rb'))
        bot.send_message(message.from_user.id,"Куда кидать")
        bot.send_photo(message.from_user.id, photo=open('Апартаменты на В 2.jpg', 'rb'))
        bot.send_message(message.from_user.id, "Куда прилетит")
        bot.send_photo(message.from_user.id, photo=open('Апартаменты на В 3.png', 'rb'))

    elif message.text == 'Ковры на A':
        markup = types.ReplyKeyboardMarkup(resize_keyboard=True)
        btn1 = types.KeyboardButton('🔙 Позиции за КТ Мираж')
        markup.add(btn1)
        bot.send_message(message.from_user.id, "Куда вставать", reply_markup=markup)
        bot.send_photo(message.from_user.id, photo=open('Ковры на А 1.jpg', 'rb'))
        bot.send_message(message.from_user.id, "Куда кидать")
        bot.send_photo(message.from_user.id, photo=open('Ковры на А 2.jpg', 'rb'))
        bot.send_message(message.from_user.id, "Куда прилетит")
        bot.send_photo(message.from_user.id, photo=open('Ковры на А 3.png', 'rb'))

    elif message.text == 'Подвал':
        markup = types.ReplyKeyboardMarkup(resize_keyboard=True)
        btn1 = types.KeyboardButton('🔙 Позиции за КТ Мираж')
        markup.add(btn1)
        bot.send_message(message.from_user.id, "Куда вставать", reply_markup=markup)
        bot.send_photo(message.from_user.id, photo=open('Подвал 1.jpg', 'rb'))
        bot.send_message(message.from_user.id, "Куда кидать")
        bot.send_photo(message.from_user.id, photo=open('Подвал 2.jpg', 'rb'))
        bot.send_message(message.from_user.id, "Куда прилетит")
        bot.send_photo(message.from_user.id, photo=open('Подвал 3.png', 'rb'))


    elif message.text == 'Рампа на А':
        markup = types.ReplyKeyboardMarkup(resize_keyboard=True)
        btn1 = types.KeyboardButton('🔙 Позиции за КТ Мираж')
        markup.add(btn1)
        bot.send_message(message.from_user.id, "Куда вставать", reply_markup=markup)
        bot.send_photo(message.from_user.id, photo=open('Рампа на А 1.jpg', 'rb'))
        bot.send_message(message.from_user.id, "Куда кидать")
        bot.send_photo(message.from_user.id, photo=open('Рампа на А 2.jpg', 'rb'))
        bot.send_message(message.from_user.id, "Куда прилетит")
        bot.send_photo(message.from_user.id, photo=open('Рампа на А 3.png', 'rb'))
    elif message.text == 'Топ мид':
        markup = types.ReplyKeyboardMarkup(resize_keyboard=True)
        btn1 = types.KeyboardButton('🔙 Позиции за КТ Мираж')
        markup.add(btn1)
        bot.send_message(message.from_user.id, "Куда вставать", reply_markup=markup)
        bot.send_photo(message.from_user.id, photo=open('Топ-мид за КТ 1.jpg', 'rb'))
        bot.send_message(message.from_user.id, "Куда кидать")
        bot.send_photo(message.from_user.id, photo=open('Топ-мид за КТ 2.jpg', 'rb'))
        bot.send_message(message.from_user.id, "Куда прилетит")
        bot.send_photo(message.from_user.id, photo=open('Топ-мид за КТ 3.png', 'rb'))
    elif message.text == 'Шорт':
        markup = types.ReplyKeyboardMarkup(resize_keyboard=True)
        btn1 = types.KeyboardButton('🔙 Позиции за КТ Мираж')
        markup.add(btn1)
        bot.send_message(message.from_user.id, "Куда вставать", reply_markup=markup)
        bot.send_photo(message.from_user.id, photo=open('Шорт 1.jpg', 'rb'))
        bot.send_message(message.from_user.id, "Куда кидать")
        bot.send_photo(message.from_user.id, photo=open('Шорт 2.jpg', 'rb'))
        bot.send_message(message.from_user.id, "Куда прилетит")
        bot.send_photo(message.from_user.id, photo=open('Шорт 3.png', 'rb'))
    elif message.text == '🔙 Позиции за КТ Мираж':
        markup = types.ReplyKeyboardMarkup(resize_keyboard=True)
        btn1 = types.KeyboardButton('Апартаменты на B')
        btn2 = types.KeyboardButton('Ковры на A')
        btn3 = types.KeyboardButton('Подвал')
        btn4 = types.KeyboardButton('Рампа на А')
        btn5 = types.KeyboardButton('Топ мид')
        btn6 = types.KeyboardButton('Шорт')
        markup.add(btn1, btn2, btn3, btn4, btn5, btn6)
        bot.send_message(message.from_user.id, 'Выберите позицию', reply_markup=markup)
    #KT MIRAGE END



    #T MIRAGE
    elif message.text == 'Т Мираж':
        markup = types.ReplyKeyboardMarkup(resize_keyboard=True)
        btn1 = types.KeyboardButton('Голова')
        btn2 = types.KeyboardButton('Дверь на кухню')
        btn3 = types.KeyboardButton('Дельпан')
        btn4 = types.KeyboardButton('Джангл')
        btn5 = types.KeyboardButton('Коннектор')
        btn6 = types.KeyboardButton('Окно на кухню')
        btn8 = types.KeyboardButton('Окно на миде')
        btn9 = types.KeyboardButton('Топ мид за Т')
        btn10 = types.KeyboardButton('Форест')
        bnt7=types.KeyboardButton('🔙 Вернуться к выбору карты')
        markup.add(btn1, btn2, btn3, btn4, btn5, btn6,btn8,btn9,btn10,bnt7)
        bot.send_message(message.from_user.id, 'Выберите позицию', reply_markup=markup)
    elif message.text == 'Голова':
        markup = types.ReplyKeyboardMarkup(resize_keyboard=True)
        btn1 = types.KeyboardButton('🔙 Позиции за Т Мираж')
        markup.add(btn1)
        bot.send_message(message.from_user.id, "Куда вставать", reply_markup=markup)
        bot.send_photo(message.from_user.id, photo=open('Голова 1.jpg', 'rb'))
        bot.send_message(message.from_user.id, "Куда кидать")
        bot.send_photo(message.from_user.id, photo=open('Голова 2.jpg', 'rb'))
        bot.send_message(message.from_user.id, "Куда прилетит")
        bot.send_photo(message.from_user.id, photo=open('Голова 3.png', 'rb'))
    elif message.text == 'Дверь на кухню':
        markup = types.ReplyKeyboardMarkup(resize_keyboard=True)
        btn1 = types.KeyboardButton('🔙 Позиции за Т Мираж')
        markup.add(btn1)
        bot.send_message(message.from_user.id, "Куда вставать", reply_markup=markup)
        bot.send_photo(message.from_user.id, photo=open('Дверь на кухню 1.jpg', 'rb'))
        bot.send_message(message.from_user.id, "Куда кидать")
        bot.send_photo(message.from_user.id, photo=open('Дверь на кухню 2.jpg', 'rb'))
        bot.send_message(message.from_user.id, "Куда прилетит")
        bot.send_photo(message.from_user.id, photo=open('Дверь на кухню 3.png', 'rb'))
    elif message.text == 'Дельпан':
        markup = types.ReplyKeyboardMarkup(resize_keyboard=True)
        btn1 = types.KeyboardButton('🔙 Позиции за Т Мираж')
        markup.add(btn1)
        bot.send_message(message.from_user.id, "Куда вставать", reply_markup=markup)
        bot.send_photo(message.from_user.id, photo=open('Дельпан 1.jpg', 'rb'))
        bot.send_message(message.from_user.id, "Куда кидать")
        bot.send_photo(message.from_user.id, photo=open('Дельпан 2.jpg', 'rb'))
        bot.send_message(message.from_user.id, "Куда прилетит")
        bot.send_photo(message.from_user.id, photo=open('Дельпан 3.png', 'rb'))
    elif message.text == 'Джангл':
        markup = types.ReplyKeyboardMarkup(resize_keyboard=True)
        btn1 = types.KeyboardButton('🔙 Позиции за Т Мираж')
        markup.add(btn1)
        bot.send_message(message.from_user.id, "Куда вставать", reply_markup=markup)
        bot.send_photo(message.from_user.id, photo=open('Джангл 1.jpg', 'rb'))
        bot.send_message(message.from_user.id, "Куда кидать")
        bot.send_photo(message.from_user.id, photo=open('Джангл 2.jpg', 'rb'))
        bot.send_message(message.from_user.id, "Куда прилетит")
        bot.send_photo(message.from_user.id, photo=open('Джангл 3.png', 'rb'))
    elif message.text == 'Коннектор':
        markup = types.ReplyKeyboardMarkup(resize_keyboard=True)
        btn1 = types.KeyboardButton('🔙 Позиции за Т Мираж')
        markup.add(btn1)
        bot.send_message(message.from_user.id, "Куда вставать", reply_markup=markup)
        bot.send_photo(message.from_user.id, photo=open('Коннектор 1.jpg', 'rb'))
        bot.send_message(message.from_user.id, "Куда кидать")
        bot.send_photo(message.from_user.id, photo=open('Коннектор 2.jpg', 'rb'))
        bot.send_message(message.from_user.id, "Куда прилетит")
        bot.send_photo(message.from_user.id, photo=open('Коннектор 3.png', 'rb'))
    elif message.text == 'Окно на миде':
        markup = types.ReplyKeyboardMarkup(resize_keyboard=True)
        btn1 = types.KeyboardButton('🔙 Позиции за Т Мираж')
        markup.add(btn1)
        bot.send_message(message.from_user.id, "Куда вставать", reply_markup=markup)
        bot.send_photo(message.from_user.id, photo=open('Окно на миде 1.jpg', 'rb'))
        bot.send_message(message.from_user.id, "Куда кидать")
        bot.send_photo(message.from_user.id, photo=open('Окно на миде 2.jpg', 'rb'))
        bot.send_message(message.from_user.id, "Куда прилетит")
        bot.send_photo(message.from_user.id, photo=open('Окно на миде 3.png', 'rb'))
    elif message.text == 'Окно на кухню':
        markup = types.ReplyKeyboardMarkup(resize_keyboard=True)
        btn1 = types.KeyboardButton('🔙 Позиции за Т Мираж')
        markup.add(btn1)
        bot.send_message(message.from_user.id, "Куда вставать", reply_markup=markup)
        bot.send_photo(message.from_user.id, photo=open('Окно на кухню 1.jpg', 'rb'))
        bot.send_message(message.from_user.id, "Куда кидать")
        bot.send_photo(message.from_user.id, photo=open('Окно на кухню 2.jpg', 'rb'))
        bot.send_message(message.from_user.id, "Куда прилетит")
        bot.send_photo(message.from_user.id, photo=open('Окно на кухню 3.png', 'rb'))
    elif message.text == 'Топ мид за Т':
        markup = types.ReplyKeyboardMarkup(resize_keyboard=True)
        btn1 = types.KeyboardButton('🔙 Позиции за Т Мираж')
        markup.add(btn1)
        bot.send_message(message.from_user.id, "Куда вставать", reply_markup=markup)
        bot.send_photo(message.from_user.id, photo=open('Топ-мид за Т 1.jpg', 'rb'))
        bot.send_message(message.from_user.id, "Куда кидать")
        bot.send_photo(message.from_user.id, photo=open('Топ-мид за Т 2.jpg', 'rb'))
        bot.send_message(message.from_user.id, "Куда прилетит")
        bot.send_photo(message.from_user.id, photo=open('Топ-мид за Т 3.png', 'rb'))
    elif message.text == 'Форест':
        markup = types.ReplyKeyboardMarkup(resize_keyboard=True)
        btn1 = types.KeyboardButton('🔙 Позиции за Т Мираж')
        markup.add(btn1)
        bot.send_message(message.from_user.id, "Куда вставать", reply_markup=markup)
        bot.send_photo(message.from_user.id, photo=open('Форест 1.jpg', 'rb'))
        bot.send_message(message.from_user.id, "Куда кидать")
        bot.send_photo(message.from_user.id, photo=open('Форест 2.jpg', 'rb'))
        bot.send_message(message.from_user.id, "Куда прилетит")
        bot.send_photo(message.from_user.id, photo=open('Форест 3.png', 'rb'))
    elif message.text == '🔙 Позиции за Т Мираж':
        markup = types.ReplyKeyboardMarkup(resize_keyboard=True)
        btn1 = types.KeyboardButton('Голова')
        btn2 = types.KeyboardButton('Дверь на кухню')
        btn3 = types.KeyboardButton('Дельпан')
        btn4 = types.KeyboardButton('Джангл')
        btn5 = types.KeyboardButton('Коннектор')
        btn6 = types.KeyboardButton('Окно на кухню')
        btn8 = types.KeyboardButton('Окно на миде')
        btn9 = types.KeyboardButton('Топ мид за Т')
        btn10 = types.KeyboardButton('Форест')
        bnt7 = types.KeyboardButton('🔙 Вернуться к выбору карты')
        markup.add(btn1, btn2, btn3, btn4, btn5, btn6, btn8, btn9, btn10, bnt7)
        bot.send_message(message.from_user.id, 'Выберите позицию', reply_markup=markup)
    #t mirage end



    #dust 2
    if message.text == 'Dust 2':
        markup = types.ReplyKeyboardMarkup(resize_keyboard=True)
        btn1 = types.KeyboardButton('KT Dust 2')
        btn2 = types.KeyboardButton('Т Dust 2')
        btn3 = types.KeyboardButton('🔙 Вернуться к выбору карты')
        markup.add(btn1, btn2, btn3)
        bot.send_message(message.from_user.id, '👀 Выберите сторону', reply_markup=markup)
    #kt dust 2


    elif message.text == 'KT Dust 2':
        markup = types.ReplyKeyboardMarkup(resize_keyboard=True)
        btn1 = types.KeyboardButton('Двери на длине')
        btn2 = types.KeyboardButton('Двойные двери')
        btn3 = types.KeyboardButton('Туннель с мида')
        btn4 = types.KeyboardButton('Шорт близи')
        btn5 = types.KeyboardButton('Шорт вдалеке')
        bnt7 = types.KeyboardButton('🔙 Вернуться к выбору карты')
        markup.add(btn1, btn2, btn3, btn4, btn5, bnt7)
        bot.send_message(message.from_user.id, 'Выберите позицию', reply_markup=markup)

    elif message.text == 'Двери на длине':
        markup = types.ReplyKeyboardMarkup(resize_keyboard=True)
        btn1 = types.KeyboardButton('🔙 Позиции за КТ Dust 2')
        markup.add(btn1)
        bot.send_message(message.from_user.id, "Куда вставать", reply_markup=markup)
        bot.send_photo(message.from_user.id, photo=open('Двери на длине 1.png', 'rb'))
        bot.send_message(message.from_user.id, "Куда кидать")
        bot.send_photo(message.from_user.id, photo=open('Двери на длине 2.png', 'rb'))
        bot.send_message(message.from_user.id, "Куда прилетит")
        bot.send_photo(message.from_user.id, photo=open('Двери на длине 3.png', 'rb'))

    elif message.text == 'Двойные двери':
        markup = types.ReplyKeyboardMarkup(resize_keyboard=True)
        btn1 = types.KeyboardButton('🔙 Позиции за КТ Dust 2')
        markup.add(btn1)
        bot.send_message(message.from_user.id, "Куда вставать", reply_markup=markup)
        bot.send_photo(message.from_user.id, photo=open('Двойные двери на миде.png', 'rb'))
        bot.send_message(message.from_user.id, "Куда кидать")
        bot.send_photo(message.from_user.id, photo=open('Двойные двери на миде 2.png', 'rb'))
        bot.send_message(message.from_user.id, "Куда прилетит")
        bot.send_photo(message.from_user.id, photo=open('Двойные двери на миде 3.png', 'rb'))

    elif message.text == 'Туннель с мида':
        markup = types.ReplyKeyboardMarkup(resize_keyboard=True)
        btn1 = types.KeyboardButton('🔙 Позиции за КТ Dust 2')
        markup.add(btn1)
        bot.send_message(message.from_user.id, "Куда вставать", reply_markup=markup)
        bot.send_photo(message.from_user.id, photo=open('Туннель с мида 1.png', 'rb'))
        bot.send_message(message.from_user.id, "Куда кидать")
        bot.send_photo(message.from_user.id, photo=open('Туннель с мида 2.png', 'rb'))
        bot.send_message(message.from_user.id, "Куда прилетит")
        bot.send_photo(message.from_user.id, photo=open('Туннель с мида 3.png', 'rb'))


    elif message.text == 'Шорт вблизи':
        markup = types.ReplyKeyboardMarkup(resize_keyboard=True)
        btn1 = types.KeyboardButton('🔙 Позиции за КТ Dust 2')
        markup.add(btn1)
        bot.send_message(message.from_user.id, "Куда вставать", reply_markup=markup)
        bot.send_photo(message.from_user.id, photo=open('Шорт вблизи 1.png', 'rb'))
        bot.send_message(message.from_user.id, "Куда кидать")
        bot.send_photo(message.from_user.id, photo=open('Шорт вблизи 2.png', 'rb'))
        bot.send_message(message.from_user.id, "Куда прилетит")
        bot.send_photo(message.from_user.id, photo=open('Шорт вблизи 3.png', 'rb'))
    elif message.text == 'Шорт вдалеке':
        markup = types.ReplyKeyboardMarkup(resize_keyboard=True)
        btn1 = types.KeyboardButton('🔙 Позиции за КТ Dust2')
        markup.add(btn1)
        bot.send_message(message.from_user.id, "Куда вставать", reply_markup=markup)
        bot.send_photo(message.from_user.id, photo=open('Шорт вдалеке 1.png', 'rb'))
        bot.send_message(message.from_user.id, "Куда кидать")
        bot.send_photo(message.from_user.id, photo=open('Шорт вдалеке 2.png', 'rb'))
        bot.send_message(message.from_user.id, "Куда прилетит")
        bot.send_photo(message.from_user.id, photo=open('Шорт вдалеке 3.png', 'rb'))
    elif message.text == '🔙 Позиции за КТ Dust 2':
        markup = types.ReplyKeyboardMarkup(resize_keyboard=True)
        btn1 = types.KeyboardButton('Двери на длине')
        btn2 = types.KeyboardButton('Двойные двери')
        btn3 = types.KeyboardButton('Туннель с мида')
        btn4 = types.KeyboardButton('Шорт близи')
        btn5 = types.KeyboardButton('Шорт вдалеке')
        bnt7 = types.KeyboardButton('🔙 Вернуться к выбору карты')
        markup.add(btn1, btn2, btn3, btn4, btn5, bnt7)
        bot.send_message(message.from_user.id, 'Выберите позицию', reply_markup=markup)
    # kt dust 2 end


    #t dust 2
    elif message.text == 'Т Dust 2':
        markup = types.ReplyKeyboardMarkup(resize_keyboard=True)
        btn1 = types.KeyboardButton('Глубокий смок на КТ')
        btn2 = types.KeyboardButton('Дверь на B')
        btn3 = types.KeyboardButton('Иксбокс')
        btn4 = types.KeyboardButton('Окно на B')
        btn5 = types.KeyboardButton('Смок на КТ')
        btn6 = types.KeyboardButton('Угол на длине')
        bnt7 = types.KeyboardButton('🔙 Вернуться к выбору карты')
        markup.add(btn1, btn2, btn3, btn4, btn5,btn6, bnt7)
        bot.send_message(message.from_user.id, 'Выберите позицию', reply_markup=markup)

    elif message.text == 'Глубокий смок на КТ':
        markup = types.ReplyKeyboardMarkup(resize_keyboard=True)
        btn1 = types.KeyboardButton('🔙 Позиции за Т Dust 2')
        markup.add(btn1)
        bot.send_message(message.from_user.id, "Куда вставать", reply_markup=markup)
        bot.send_photo(message.from_user.id, photo=open('Глубокий смок на КТ 1.png', 'rb'))
        bot.send_message(message.from_user.id, "Куда кидать")
        bot.send_photo(message.from_user.id, photo=open('Глубокий смок на КТ 2.png', 'rb'))
        bot.send_message(message.from_user.id, "Куда прилетит")
        bot.send_photo(message.from_user.id, photo=open('Глубокий смок на КТ 3.png', 'rb'))

    elif message.text == 'Дверь на B':
        markup = types.ReplyKeyboardMarkup(resize_keyboard=True)
        btn1 = types.KeyboardButton('🔙 Позиции за Т Dust 2')
        markup.add(btn1)
        bot.send_message(message.from_user.id, "Куда вставать", reply_markup=markup)
        bot.send_photo(message.from_user.id, photo=open('Дверь на В 1.png', 'rb'))
        bot.send_message(message.from_user.id, "Куда кидать")
        bot.send_photo(message.from_user.id, photo=open('Дверь на В 2.png', 'rb'))
        bot.send_message(message.from_user.id, "Куда прилетит")
        bot.send_photo(message.from_user.id, photo=open('Дверь на В 3.png', 'rb'))

    elif message.text == 'Иксбокс':
        markup = types.ReplyKeyboardMarkup(resize_keyboard=True)
        btn1 = types.KeyboardButton('🔙 Позиции за Т Dust 2')
        markup.add(btn1)
        bot.send_message(message.from_user.id, "Куда вставать", reply_markup=markup)
        bot.send_photo(message.from_user.id, photo=open('Иксбокс 1.png', 'rb'))
        bot.send_photo(message.from_user.id, photo=open('Иксбокс 2.png', 'rb'))
        bot.send_message(message.from_user.id, "Куда кидать")
        bot.send_photo(message.from_user.id, photo=open('Иксбокс 3.png', 'rb'))
        bot.send_message(message.from_user.id, "Куда прилетит")
        bot.send_photo(message.from_user.id, photo=open('Иксбокс 4.png', 'rb'))


    elif message.text == 'Окно на B':
        markup = types.ReplyKeyboardMarkup(resize_keyboard=True)
        btn1 = types.KeyboardButton('🔙 Позиции за Т Dust 2')
        markup.add(btn1)
        bot.send_message(message.from_user.id, "Куда вставать", reply_markup=markup)
        bot.send_photo(message.from_user.id, photo=open('Окно на В 1.png', 'rb'))
        bot.send_message(message.from_user.id, "Куда кидать")
        bot.send_photo(message.from_user.id, photo=open('Окно на В 2.png', 'rb'))
        bot.send_message(message.from_user.id, "Куда прилетит")
        bot.send_photo(message.from_user.id, photo=open('Окно на В 3.png', 'rb'))
    elif message.text == 'Смок на КТ':
        markup = types.ReplyKeyboardMarkup(resize_keyboard=True)
        btn1 = types.KeyboardButton('🔙 Позиции за Т Dust 2')
        markup.add(btn1)
        bot.send_message(message.from_user.id, "Куда вставать", reply_markup=markup)
        bot.send_photo(message.from_user.id, photo=open('Смок КТ для прохода на В 1.png', 'rb'))
        bot.send_message(message.from_user.id, "Куда кидать")
        bot.send_photo(message.from_user.id, photo=open('Смок КТ для прохода на В 2.png', 'rb'))
        bot.send_message(message.from_user.id, "Куда прилетит")
        bot.send_photo(message.from_user.id, photo=open('Смок КТ для прохода на В 3.png', 'rb'))
    elif message.text == 'Угол на длине':
        markup = types.ReplyKeyboardMarkup(resize_keyboard=True)
        btn1 = types.KeyboardButton('🔙 Позиции за Т Dust 2')
        markup.add(btn1)
        bot.send_message(message.from_user.id, "Куда вставать", reply_markup=markup)
        bot.send_photo(message.from_user.id, photo=open('Угол на длине 1.png', 'rb'))
        bot.send_message(message.from_user.id, "Куда кидать")
        bot.send_photo(message.from_user.id, photo=open('Угол на длине 2.png', 'rb'))
        bot.send_message(message.from_user.id, "Куда прилетит")
        bot.send_photo(message.from_user.id, photo=open('Угол на длине 3.png', 'rb'))
    elif message.text == '🔙 Позиции за Т Dust 2':
        markup = types.ReplyKeyboardMarkup(resize_keyboard=True)
        btn1 = types.KeyboardButton('Глубокий смок на КТ')
        btn2 = types.KeyboardButton('Дверь на B')
        btn3 = types.KeyboardButton('Иксбокс')
        btn4 = types.KeyboardButton('Окно на B')
        btn5 = types.KeyboardButton('Смок на КТ')
        btn6 = types.KeyboardButton('Угол на длине')
        bnt7 = types.KeyboardButton('🔙 Вернуться к выбору карты')
        markup.add(btn1, btn2, btn3, btn4, btn5, btn6, bnt7)
        bot.send_message(message.from_user.id, 'Выберите позицию', reply_markup=markup)
    # T DUST 2 END


    # Inferno
    if message.text == 'Inferno':
        markup = types.ReplyKeyboardMarkup(resize_keyboard=True)
        btn1 = types.KeyboardButton('KT Inferno')
        btn2 = types.KeyboardButton('T Inferno')
        btn3 = types.KeyboardButton('🔙 Вернуться к выбору карты')
        markup.add(btn1, btn2, btn3)
        bot.send_message(message.from_user.id, '👀 Выберите сторону', reply_markup=markup)

    elif message.text == 'KT Inferno':
        markup = types.ReplyKeyboardMarkup(resize_keyboard=True)
        btn1 = types.KeyboardButton('Банан')
        btn2 = types.KeyboardButton('Мид')
        btn3 = types.KeyboardButton('Рампа')
        bnt7 = types.KeyboardButton('🔙 Вернуться к выбору карты')
        markup.add(btn1, btn2, btn3, bnt7)
        bot.send_message(message.from_user.id, 'Выберите позицию', reply_markup=markup)

    elif message.text == 'Банан':
        markup = types.ReplyKeyboardMarkup(resize_keyboard=True)
        btn1 = types.KeyboardButton('🔙 Позиции за КТ Inferno')
        markup.add(btn1)
        bot.send_message(message.from_user.id, "Куда вставать", reply_markup=markup)
        bot.send_photo(message.from_user.id, photo=open('Банан 1.png', 'rb'))
        bot.send_message(message.from_user.id, "Куда кидать")
        bot.send_photo(message.from_user.id, photo=open('Банан 2.png', 'rb'))
        bot.send_message(message.from_user.id, "Куда прилетит")
        bot.send_photo(message.from_user.id, photo=open('Банан 3.png', 'rb'))

    elif message.text == 'Мид':
        markup = types.ReplyKeyboardMarkup(resize_keyboard=True)
        btn1 = types.KeyboardButton('🔙 Позиции за КТ Inferno')
        markup.add(btn1)
        bot.send_message(message.from_user.id, "Куда вставать", reply_markup=markup)
        bot.send_photo(message.from_user.id, photo=open('Мид 1.png', 'rb'))
        bot.send_message(message.from_user.id, "Куда кидать")
        bot.send_photo(message.from_user.id, photo=open('Мид 2.png', 'rb'))
        bot.send_message(message.from_user.id, "Куда прилетит")
        bot.send_photo(message.from_user.id, photo=open('Мид 3.png', 'rb'))

    elif message.text == 'Рампа':
        markup = types.ReplyKeyboardMarkup(resize_keyboard=True)
        btn1 = types.KeyboardButton('🔙 Позиции за КТ Inferno')
        markup.add(btn1)
        bot.send_message(message.from_user.id, "Куда вставать", reply_markup=markup)
        bot.send_photo(message.from_user.id, photo=open('Рампа 1.png', 'rb'))
        bot.send_message(message.from_user.id, "Куда кидать")
        bot.send_photo(message.from_user.id, photo=open('Рампа 2.png', 'rb'))
        bot.send_message(message.from_user.id, "Куда прилетит")
        bot.send_photo(message.from_user.id, photo=open('Рампа 3.png', 'rb'))
    elif message.text == '🔙 Позиции за КТ Inferno':
        markup = types.ReplyKeyboardMarkup(resize_keyboard=True)
        btn1 = types.KeyboardButton('Двери на длине')
        btn2 = types.KeyboardButton('Двойные двери')
        btn3 = types.KeyboardButton('Туннель с мида')
        btn4 = types.KeyboardButton('Шорт близи')
        btn5 = types.KeyboardButton('Шорт вдалеке')
        bnt7 = types.KeyboardButton('🔙 Вернуться к выбору карты')
        markup.add(btn1, btn2, btn3, btn4, btn5, bnt7)
        bot.send_message(message.from_user.id, 'Выберите позицию', reply_markup=markup)
     #KT INFERNO END


    #T INFERNO
    elif message.text == 'T Inferno':
        markup = types.ReplyKeyboardMarkup(resize_keyboard=True)
        btn1 = types.KeyboardButton('Библиотека')
        btn2 = types.KeyboardButton("Гробы")
        btn3 = types.KeyboardButton('Заход в плент B')
        btn4 = types.KeyboardButton('КТ проход на B')
        btn5 = types.KeyboardButton("Левая сторона мида")
        btn6 = types.KeyboardButton('Пески')
        btn8 = types.KeyboardButton('Правая часть мида')
        bnt7 = types.KeyboardButton('🔙 Вернуться к выбору карты')
        markup.add(btn1, btn2, btn3,btn4,btn5,btn6,btn8,bnt7)
        bot.send_message(message.from_user.id, 'Выберите позицию', reply_markup=markup)

    elif message.text == 'Библиотека':
        markup = types.ReplyKeyboardMarkup(resize_keyboard=True)
        btn1 = types.KeyboardButton('🔙 Позиции за Т Inferno')
        markup.add(btn1)
        bot.send_message(message.from_user.id, "Куда вставать", reply_markup=markup)
        bot.send_photo(message.from_user.id, photo=open('Библиотека 1.png', 'rb'))
        bot.send_message(message.from_user.id, "Куда кидать")
        bot.send_photo(message.from_user.id, photo=open('Библиотека 2.png', 'rb'))
        bot.send_message(message.from_user.id, "Куда прилетит")
        bot.send_photo(message.from_user.id, photo=open('Библиотека 3.png', 'rb'))

    elif message.text == 'Гробы':
        markup = types.ReplyKeyboardMarkup(resize_keyboard=True)
        btn1 = types.KeyboardButton('🔙 Позиции за Т Inferno')
        markup.add(btn1)
        bot.send_message(message.from_user.id, "Куда вставать", reply_markup=markup)
        bot.send_photo(message.from_user.id, photo=open('Гробы 1.png', 'rb'))
        bot.send_photo(message.from_user.id, photo=open('Гробы 2.png', 'rb'))
        bot.send_message(message.from_user.id, "Куда кидать")
        bot.send_photo(message.from_user.id, photo=open('Гробы 3.png', 'rb'))
        bot.send_message(message.from_user.id, "Куда прилетит")
        bot.send_photo(message.from_user.id, photo=open('Гробы 4.png', 'rb'))

    elif message.text == 'Заход в плент B':
        markup = types.ReplyKeyboardMarkup(resize_keyboard=True)
        btn1 = types.KeyboardButton('🔙 Позиции за Т Inferno')
        markup.add(btn1)
        bot.send_message(message.from_user.id, "Куда вставать", reply_markup=markup)
        bot.send_photo(message.from_user.id, photo=open('Заход в плент В 1.png', 'rb'))
        bot.send_message(message.from_user.id, "Куда кидать")
        bot.send_photo(message.from_user.id, photo=open('Заход в плент В 2.png', 'rb'))
        bot.send_message(message.from_user.id, "Куда прилетит")
        bot.send_photo(message.from_user.id, photo=open('Заход в плент В 3.png', 'rb'))
    elif message.text == 'КТ проход на B':
        markup = types.ReplyKeyboardMarkup(resize_keyboard=True)
        btn1 = types.KeyboardButton('🔙 Позиции за Т Inferno')
        markup.add(btn1)
        bot.send_message(message.from_user.id, "Куда вставать", reply_markup=markup)
        bot.send_photo(message.from_user.id, photo=open('КТ-проход на В 1.png', 'rb'))
        bot.send_message(message.from_user.id, "Куда кидать")
        bot.send_photo(message.from_user.id, photo=open('КТ-проход на В 2.png', 'rb'))
        bot.send_message(message.from_user.id, "Куда прилетит")
        bot.send_photo(message.from_user.id, photo=open('КТ-проход на В 3.png', 'rb'))
    elif message.text == 'Левая сторона мида':
        markup = types.ReplyKeyboardMarkup(resize_keyboard=True)
        btn1 = types.KeyboardButton('🔙 Позиции за Т Inferno')
        markup.add(btn1)
        bot.send_message(message.from_user.id, "Куда вставать", reply_markup=markup)
        bot.send_photo(message.from_user.id, photo=open('Левая сторона мида 1.png', 'rb'))
        bot.send_message(message.from_user.id, "Куда кидать")
        bot.send_photo(message.from_user.id, photo=open('Левая сторона мида 2.png', 'rb'))
        bot.send_message(message.from_user.id, "Куда прилетит")
        bot.send_photo(message.from_user.id, photo=open('Левая сторона мида 3.png', 'rb'))
    elif message.text == 'Пески':
        markup = types.ReplyKeyboardMarkup(resize_keyboard=True)
        btn1 = types.KeyboardButton('🔙 Позиции за Т Inferno')
        markup.add(btn1)
        bot.send_message(message.from_user.id, "Куда вставать", reply_markup=markup)
        bot.send_photo(message.from_user.id, photo=open('Пески 1.png', 'rb'))
        bot.send_message(message.from_user.id, "Куда кидать")
        bot.send_photo(message.from_user.id, photo=open('Пески 2.png', 'rb'))
        bot.send_message(message.from_user.id, "Куда прилетит")
        bot.send_photo(message.from_user.id, photo=open('Пески 3.png', 'rb'))
    elif message.text == 'Правая часть мида':
        markup = types.ReplyKeyboardMarkup(resize_keyboard=True)
        btn1 = types.KeyboardButton('🔙 Позиции за Т Inferno')
        markup.add(btn1)
        bot.send_message(message.from_user.id, "Куда вставать", reply_markup=markup)
        bot.send_photo(message.from_user.id, photo=open('Правая часть мида 1.png', 'rb'))
        bot.send_message(message.from_user.id, "Куда кидать")
        bot.send_photo(message.from_user.id, photo=open('Правая часть мида 2.png', 'rb'))
        bot.send_message(message.from_user.id, "Куда прилетит")
        bot.send_photo(message.from_user.id, photo=open('Правая часть мида 3.png', 'rb'))
    elif message.text == '🔙 Позиции за Т Inferno':
        markup = types.ReplyKeyboardMarkup(resize_keyboard=True)
        btn1 = types.KeyboardButton('Библиотека')
        btn2 = types.KeyboardButton("Гробы")
        btn3 = types.KeyboardButton('Заход в плент B')
        btn4 = types.KeyboardButton('КТ проход на B')
        btn5 = types.KeyboardButton("Левая сторона мида")
        btn6 = types.KeyboardButton('Пески')
        btn8 = types.KeyboardButton('Правая часть мида')
        bnt7 = types.KeyboardButton('🔙 Вернуться к выбору карты')
        markup.add(btn1, btn2, btn3, btn4, btn5, btn6, btn8, bnt7)
        bot.send_message(message.from_user.id, 'Выберите позицию', reply_markup=markup)


bot.polling(none_stop=True, interval=0)