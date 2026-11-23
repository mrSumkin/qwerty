# -*- coding: utf-8 -*-
import os
import sys

def merge_cs_files(output_file="all_code.txt"):
    current_dir = os.getcwd()
    cs_files = []
    
    # Рекурсивно находим все .cs файлы
    for root, dirs, files in os.walk(current_dir):
        for file in files:
            if file.endswith('.cs'):
                cs_files.append(os.path.join(root, file))
    
    print("Найдено {} файлов .cs".format(len(cs_files)))
    
    # Собираем всё в один файл
    with open(output_file, 'w', encoding='utf-8') as out:
        for filepath in cs_files:
            rel_path = os.path.relpath(filepath, current_dir)
            out.write("\n" + "="*80 + "\n")
            out.write("FILE: {}\n".format(rel_path))
            out.write("="*80 + "\n\n")
            
            try:
                with open(filepath, 'r', encoding='utf-8') as f:
                    out.write(f.read())
                    out.write("\n")
            except Exception as e:
                out.write("[ERROR reading file: {}]\n".format(e))
                print("Ошибка чтения {}: {}".format(filepath, e))
    
    print("Готово! Файл сохранён: {}".format(output_file))
    size_mb = os.path.getsize(output_file) / 1024.0 / 1024.0
    print("Размер: {:.2f} MB".format(size_mb))

if __name__ == "__main__":
    output = sys.argv[1] if len(sys.argv) > 1 else "all_code.txt"
    merge_cs_files(output)