# Proyecto Proceso-CRUD con Visual C# y MySQL Server
Este proyecto de Windows Form App desarrollado en Visual C# y MySQL Server implementa un sistema CRUD (Crear, Leer, Actualizar y Eliminar) para gestionar información sobre artículos. Se incluye funcionalidad para realizar consultas, agregar articulos, actualizarlos y eliminarlos de forma no permanente para su recuperacion en caso que se esté ante un escenario de eliminacion accidental de un articulo. Además se agregó una funcionalidad de generación de reportes de los artículos disponibles en la base de datos.

##Tablas Usadas en MySQL

### `tb_articulos`

- `codigo_ar`: Código del artículo (Clave primaria)
- `descripcion_ar`: Descripción del artículo
- `marca_ar`: Marca del artículo
- `codigo_um`: Código de unidad de medida (Clave foránea)
- `codigo_ca`: Código de categoría (Clave foránea)
- `stock_actual`: Cantidad actual en inventario
- `fecha_crea`: Fecha de creación del artículo
- `fecha_modifica`: Fecha de última modificación del artículo
- `estado`: Estado del artículo (activo = 1, inactivo = 0, etc)

### `tb_categorias`

- `codigo_ca`: Código de la categoría (Clave primaria)
- `descripcion_ca`: Descripción de la categoría

### `tb_unidades_medidas`

- `codigo_um`: Código de la unidad de medida (Clave primaria)
- `descripcion_um`: Descripción de la unidad de medida


## Funcionalidades del Proyecto

1. **Lectura de Información a través de Consultas:**
   - El sistema permite realizar consultas para recuperar información detallada de los artículos, incluyendo su descripción, marca, categoría, unidad de medida, stock actual, fechas de creación y modificación, así como el estado del artículo.

2. **Agregar Datos:**
   - Los usuarios pueden agregar nuevos artículos al sistema, proporcionando la descripción, marca, categoría, unidad de medida, y la cantidad inicial en inventario. La fecha de creación se registra automáticamente.

3. **Actualizar Datos:**
   - Se proporciona una interfaz para actualizar la información de los artículos, incluyendo su descripción, marca, categoría, unidad de medida, y estado. Las modificaciones quedan registradas con la fecha de modificación.

4. **Eliminar Datos de Forma No Permanente:**
   - Se expone la opción de eliminar los artículos de forma NO permanente para su posterior recuperacion en caso que se esté ante un escenario de eliminacion accidental de un articulo.

5. **Generación de Reportes de Artículos:**
   - El sistema permite generar reportes que incluyen información detallada sobre los artículos, facilitando la revisión y análisis de inventario.

## Configuración del Entorno de Desarrollo

Este proyecto fue desarrollado en un entorno .NET utilizando Windows Form App. Asegúrate de tener instalados los siguientes elementos antes de ejecutar la aplicación:

- **Visual Studio:** Utilizamos Visual Studio como el IDE para desarrollar este proyecto. Asegúrate de tenerlo instalado en tu sistema.
- **MySQL Server:** La base de datos se aloja en MySQL Server. Asegúrate de tener un servidor MySQL configurado y de haber importado las tablas necesarias en tu base de datos.

## Configuración de la Conexión a la Base de Datos

Para configurar la conexión a la base de datos, asegúrate de modificar el archivo de configuración `app.config` o `web.config` con los detalles de tu servidor MySQL, incluyendo la dirección del servidor, nombre de la base de datos, usuario y contraseña.

## Licencia

Este proyecto está licenciado bajo la Licencia MIT.
