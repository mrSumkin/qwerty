import os
import shutil

BATCH_SIZE = 500

BASE_DIR = os.path.dirname(os.path.abspath(__file__))
SCRIPT_NAME = os.path.basename(os.path.abspath(__file__))


def get_next_batch_dir(base_dir):
    i = 1
    while True:
        folder_name = "batch_{:03d}".format(i)
        full_path = os.path.join(base_dir, folder_name)
        if not os.path.exists(full_path):
            return full_path
        i += 1


def main():
    files = []

    for name in os.listdir(BASE_DIR):
        full_path = os.path.join(BASE_DIR, name)

        # Не трогаем сам скрипт
        if name == SCRIPT_NAME:
            continue

        # Только файлы, папки игнорируем
        if os.path.isfile(full_path):
            files.append(name)

    files.sort()

    if not files:
        print("Нет файлов для перемещения.")
        return

    total = len(files)

    for start in range(0, total, BATCH_SIZE):
        chunk = files[start:start + BATCH_SIZE]
        target_dir = get_next_batch_dir(BASE_DIR)
        os.makedirs(target_dir)

        for name in chunk:
            src = os.path.join(BASE_DIR, name)
            dst = os.path.join(target_dir, name)
            shutil.move(src, dst)

        print("Перемещено {} файлов в {}".format(len(chunk), target_dir))

    print("Готово. Всего обработано файлов: {}".format(total))


if __name__ == "__main__":
    main()