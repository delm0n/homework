if __name__ == '__main__':

    import os
    import aes128
    

    while True:
        print('Нажмите 1 для шифрования или 2 для дешифрования')
        way = input()
        if way not in ['1', '2']:
            print('Действие отклонено')
            continue
        else:
            break
    print()


    while True:
        print('Введите путь и имя файла:')
        input_path = os.path.abspath(input())

        if os.path.isfile(input_path):
            break
        else:
            print('Произошла ошибка')
            continue
    print()


    while True:
        print('Введите свой Ключ для шифрования / дешифрования. '
              'Ключ должен быть меньше 16 символов. Используйте только латинский алфавит и цифры')
        key = input()
        
        if len(key) > 16:
            print('Слишком длинный ключ!')
            continue
        
        for symbol in key:
            if ord(symbol) > 0xff:
                print('Используйте только латинский алфавит и цифры!')
                continue
        
        break

    with open(input_path, 'rb') as f:
        data = f.read()    

    if way == '1': #шифрование
        crypted_data = []
        temp = []
        for byte in data:
            temp.append(byte)
            if len(temp) == 16:
                crypted_part = aes128.encrypt(temp, key)
                crypted_data.extend(crypted_part)
                del temp[:]
        else:
            if 0 < len(temp) < 16:
                empty_spaces = 16 - len(temp)
                for i in range(empty_spaces - 1):
                    temp.append(0)
                temp.append(1)
                crypted_part = aes128.encrypt(temp, key)
                crypted_data.extend(crypted_part)

        out_path = os.path.join(os.path.dirname(input_path) , 'crypted_' + os.path.basename(input_path))


        with open(out_path, 'xb') as ff:
            ff.write(bytes(crypted_data))

    else: # дешифрование
        decrypted_data = []
        temp = []
        for byte in data:
            temp.append(byte)
            if len(temp) == 16:
                decrypted_part = aes128.decrypt(temp, key)
                decrypted_data.extend(decrypted_part)
                del temp[:] 
        else:
            if 0 < len(temp) < 16:
                empty_spaces = 16 - len(temp)
                for i in range(empty_spaces - 1):
                    temp.append(0)
                temp.append(1)
                decrypted_part = aes128.encrypt(temp, key)
                decrypted_data.extend(crypted_part) 

        out_path = os.path.join(os.path.dirname(input_path) , 'decrypted_' + os.path.basename(input_path))


        with open(out_path, 'xb') as ff:
            ff.write(bytes(decrypted_data))


    
print('\nНовый файл здесь:', out_path)
print('До свидания!')