# Product and Store API

## Descripción
Esta API REST permite gestionar tiendas y productos utilizando .NET 9 y SQLite. Implementa un patrón de diseño con DataContext, Repositories, Interfaces, DTOs y Controllers.

## Funcionalidades
- Crear una tienda
- Crear un producto
- Listar todas las tiendas con sus productos
- Visualizar un producto específico

## Tecnologías utilizadas
- .NET 9
- SQLite
- Entity Framework Core
- Swagger para documentación

## Instalación
1. Clonar el repositorio
   ```bash
   git clone https://github.com/Thetrolxs/product-api.git
   cd product_api
   ```
2. Restaurar paquetes
   ```bash
   dotnet restore
   ```
3. Crear la base de datos SQLite
   ```bash
   dotnet ef database update
   ```
4. Ejecutar la aplicación
   ```bash
   dotnet run
   ```

## Endpoints principales
### Tiendas
- Crear tienda: `POST /api/shop`
- Listar productos de la tienda: `GET /api/shop`

### Productos
- Crear producto: `POST /api/product`
- Obtener producto por ID: `GET /api/product/{id}`

## Ejemplos de uso
**Crear una tienda**
```
POST /api/shop
{
  "name": "Tienda A",
  "city": "Ciudad X",
  "products": []
}
```

**Crear un producto**
```
POST /api/product
{
  "name": "Producto 1",
  "price": 19.99
}
```

## Autor
Creado por [Thetrolxs].
