CREATE TABLE users (
    id INT PRIMARY KEY IDENTITY,
    nama NVARCHAR(100) NOT NULL,
    password NVARCHAR(100) NOT NULL UNIQUE,
    status NVARCHAR(255) NOT NULL,
    Role NVARCHAR(50) NOT NULL
);

CREATE TABLE supplier (
    id INT PRIMARY KEY IDENTITY,
    nama NVARCHAR(100) NOT NULL,
    kontak NVARCHAR(255),
    status NVARCHAR(50)
);

CREATE TABLE barang (
    id INT PRIMARY KEY IDENTITY,
    nama NVARCHAR(100) NOT NULL,
    qty int NOT NULL,
    hargajual int NOT NULL,
    hargabeli int NOT NULL,
    status varchar(50) NOT NULL
);

CREATE TABLE hpo (
    id INT PRIMARY KEY IDENTITY,
    supplier INT NOT NULL,
    UserID INT NOT NULL,
    date_ordered DATE NOT NULL,
    date_arrived DATE NOT NULL,
    total_bill int,
	total_paid int,
	status varchar(50),
    FOREIGN KEY (supplier) REFERENCES supplier(id),
    FOREIGN KEY (UserID) REFERENCES Users(id)
);

CREATE TABLE dpo (
    id INT PRIMARY KEY IDENTITY,
    hpo INT NOT NULL,
    barang INT NOT NULL,
    qty INT NOT NULL,
    subtotal int NOT NULL,
    FOREIGN KEY (hpo) REFERENCES hpo(id),
    FOREIGN KEY (barang) REFERENCES barang(id)
);

CREATE TABLE htrans (
    id INT PRIMARY KEY IDENTITY,
    UserID INT NOT NULL,
    sale_date DATE NOT NULL,
    total_amount int,
	total_paid int,
    FOREIGN KEY (UserID) REFERENCES users(id)
);

CREATE TABLE dtrans (
    id INT PRIMARY KEY IDENTITY,
    htrans INT NOT NULL,
    barang INT NOT NULL,
    qty INT NOT NULL,
    UnitPrice int NOT NULL,
    FOREIGN KEY (htrans) REFERENCES htrans(id),
    FOREIGN KEY (barang) REFERENCES barang(id)
);

CREATE TABLE retur (
    id INT PRIMARY KEY IDENTITY,
    SupplierID INT NOT NULL,
    UserID INT NOT NULL,
    ProductID INT NOT NULL,
    ReturnDate DATE NOT NULL,
    Quantity INT NOT NULL,
    Reason NVARCHAR(255),
    FOREIGN KEY (SupplierID) REFERENCES supplier(id),
    FOREIGN KEY (UserID) REFERENCES users(id),
    FOREIGN KEY (ProductID) REFERENCES barang(id)
);
