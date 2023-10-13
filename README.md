
# Cuentas - Moviminetos

Es una aplicación de .NET 6 diseñada para gestionar la información de cuentas y movimientos asociados. Se basa en una arquitectura limpia (Clean Architecture) y está compuesta por varios componentes, incluyendo una API y tres bibliotecas de clases. Su objetivo principal es proporcionar una interfaz para crear, leer, actualizar y eliminar registros de cuentas, así como gestionar los movimientos asociados a estas cuentas, manteniendo una estructura organizada y desacoplada.

La aplicación permite realizar las siguientes operaciones:




## API Reference


 ###  Cuenta


```http
GET     /api/Cuentas     :  Obtiene una lista de todas las cuentas disponibles.
POST     /api/Cuentas    : Crea una nueva cuenta.
PUT     /api/Cuentas/{Id}: Actualiza una cuenta existente por su identificador.
GET     /api/Cuentas/{Id}: Obtiene una cuenta por su identificador.
DELETE  /api/Cuentas/{Id}: Elimina una cuenta por su identificador.
```

|Parameter | Type     | Description                |
| :-------- | :------- | :------------------------- |
|CuentasId|	int|	Identificador único de la cuenta.|
|NumeroCuenta|	int| **Required**	Número de cuenta.|
|TipoCuenta|	string| **Required**	Tipo de cuenta.|
|SaldoInicial|	decimal|**Required**	Saldo inicial de la cuenta.|
|Estado|	bool	|Estado de la cuenta.|
|ClienteId|	int	| **Required** Identificador único del cliente asociado|
|Movimientos|	array	|Lista de movimientos asociados a la cuenta.|



 ###  Movimientos

Movimientos

```http
GET     /api/Movimientos        : Obtiene una lista de todos los movimientos disponibles.
POST    /api/Movimientos        : Crea un nuevo movimiento.
GET     /api/Movimientos/{Id}   : Obtiene un movimiento por su identificador.
GET     /api/Movimientos/cuenta/{IdCuenta}: Obtiene todos los movimientos asociados a una cuenta por su identificador.
PUT     /api/Movimientos/{Id}   : Actualiza un movimiento existente por su identificador.
DELETE  /api/Movimientos/{Id}   : Elimina un movimiento por su identificador.
```


| Parameter | Type     | Description                |
| :-------- | :------- | :------------------------- |
|MovimientosId|	int|	Identificador único del movimiento|
|Fecha|	datetime	|Fecha y hora del movimiento.|
|TipoMovimiento|	string|	Tipo de movimiento.|
|Valor|	decimal|	Monto del movimiento.|
|Saldo|	decimal|	Saldo después del movimiento.|
|Estado|	bool|	Estado del movimiento.|
|CuentaId|	int|	Identificador único de la cuenta asociada.|
|Cuenta|	object|	Información sobre la cuenta asociada.|


## Configuration de Base Datos

Configuration de string conexion.

#### Cuenta.API/appsettings.json
```bash
  "DefaultConnection": {{ConnectionStrings}}
```
## Configuration de conexion a servicio de Cliente 

Este servicio se encuentra en el siguiente repositorio en 

[/Client.Domain (github.com)](https://github.com/JohandryPena/Client.Domain)

#### Cuenta.API/appsettings.json
```bash
 "servicioCliente": "https://localhost:7238/api/Clientes",
```

## Migraticion de Base Datos

para aplicar las migraciones a una base de datos. 
Ejecutar con la consola nguet. 

```bash
update-database 
```




    
## Authors

- [JOHANDRI PEÑA PACHECO](https://github.com/JohandryPena)

