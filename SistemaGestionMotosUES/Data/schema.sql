CREATE TABLE Motos (
    moto_id INTEGER PRIMARY KEY,
    nombre VARCHAR(50),
    descripcion VARCHAR(200),
    year INTEGER,
    modelo VARCHAR(50),
    color VARCHAR(25),
    tipo VARCHAR(50),
    precio DECIMAL(5,2),
    strock INTEGER
)

CREATE TABLE Vendedores (
    vendedor_id varchar(50),
	fecha_nacimiento DATE,
	telefono VARCHAR(12),
	correo VARCHAR(50),
	direccion VARCHAR(200),
	contraseña VARCHAR(50)
)

CREATE TABLE Ventas (
	venta_id SERIAL PRIMARY KEY,
	vendedor_id INTEGER,
	moto_id INTEGER,
	nombre_cliente VARCHAR(100),
	numero_tarjeta VARCHAR(100),
	metodo_pago VARCHAR(100),
	num_tarjeta VARCHAR(100),
	monto DECIMAL(5,2),
	IVA DECIMAL(5,2),
	Total DECIMAL(5,2)
)