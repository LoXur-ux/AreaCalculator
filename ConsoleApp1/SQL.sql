-- ��������
CREATE TABLE product (
    id INT IDENTITY(1,1) PRIMARY KEY,
    title VARCHAR(255)
);

-- ���������
CREATE TABLE category (
    id INT IDENTITY(1,1) PRIMARY KEY,
    title VARCHAR(255)
);

-- �������, ����������� ����� "Many-to-many" ����� ���������� � �����������
CREATE TABLE product_category (
    product_id INT,
    category_id INT,
    FOREIGN KEY (product_id) REFERENCES product(id),
    FOREIGN KEY (category_id) REFERENCES category(id)
);

-- ����� ���� ������� � ��������� � ���� ���������.
SELECT p.title, c.title FROM product p
LEFT JOIN product_category pc ON p.id = pc.product_id
LEFT JOIN category c ON c.id = pc.category_id;