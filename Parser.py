def coutn_len_str():
    str = ["sadf", "sdf", "sq", "e", "21234", "!@#"]
    new_str = []
    for el in str:
        if len(el) <= 3:
            new_str.append(el)
    print(new_str)

coutn_len_str()