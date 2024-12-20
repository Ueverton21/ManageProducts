CREATE TABLE Product(
	Id SERIAL PRIMARY KEY,
    Name VARCHAR(100) NOT NULL,
    Description TEXT,
    Price DECIMAL(10, 2) NOT NULL,
    Stock INT NOT NULL DEFAULT 0
);

CREATE TABLE Clients (
    Id SERIAL PRIMARY KEY,
    Name VARCHAR(100) NOT NULL,
    Address VARCHAR(255),
    Phone VARCHAR(20),
    Email VARCHAR(100) UNIQUE
);

CREATE TABLE Sales (
    Id SERIAL PRIMARY KEY,
    ClientId INT NOT NULL,
    ProductId INT NOT NULL,
    Quantity INT NOT NULL CHECK (Quantity > 0),
    SaleDate TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (ClientId) REFERENCES Clients(Id) ON DELETE CASCADE,
    FOREIGN KEY (ProductId) REFERENCES Product(Id) ON DELETE CASCADE
);