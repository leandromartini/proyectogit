sqlcmd -S USUARIO-PC -i C:\ProyectoPedro\entregables\1.0.0.1\sql\001_CREATE_TABLE_Errores.sql
sqlcmd -S USUARIO-PC -i C:\ProyectoPedro\entregables\1.0.0.1\sql\002_CREATE_TABLE_insumos.sql
sqlcmd -S USUARIO-PC -i C:\ProyectoPedro\entregables\1.0.0.1\sql\003_CREATE_TABLE_insumosPrecio.sql
sqlcmd -S USUARIO-PC -i C:\ProyectoPedro\entregables\1.0.0.1\sql\004_CREATE_TABLE_insumosStock.sql
sqlcmd -S USUARIO-PC -i C:\ProyectoPedro\entregables\1.0.0.1\sql\005_CREATE_TABLE_insumosPrecioHist.sql
sqlcmd -S USUARIO-PC -i C:\ProyectoPedro\entregables\1.0.0.1\sql\006_CREATE_TABLE_insumosProveedoresMarca.sql
sqlcmd -S USUARIO-PC -i C:\ProyectoPedro\entregables\1.0.0.1\sql\007_CREATE_TABLE_Proveedores.sql

sqlcmd -S USUARIO-PC -i C:\ProyectoPedro\entregables\1.0.0.1\sql\00100_CREATE_SP_errores_actualizarRegistro.sql 
sqlcmd -S USUARIO-PC -i C:\ProyectoPedro\entregables\1.0.0.1\sql\00101_CREATE_SP_insumos_actualizarRegistro.sql
sqlcmd -S USUARIO-PC -i C:\ProyectoPedro\entregables\1.0.0.1\sql\00101_CREATE_SP_insumos_obtenerLista.sql
sqlcmd -S USUARIO-PC -i C:\ProyectoPedro\entregables\1.0.0.1\sql\00101_CREATE_SP_insumos_obtenerListaDetalle.sql
sqlcmd -S USUARIO-PC -i C:\ProyectoPedro\entregables\1.0.0.1\sql\00102_CREATE_SP_insumosPrecios_actualizarRegistro.sql
sqlcmd -S USUARIO-PC -i C:\ProyectoPedro\entregables\1.0.0.1\sql\00103_CREATE_SP_insumosStock_actualizarRegistro.sql
sqlcmd -S USUARIO-PC -i C:\ProyectoPedro\entregables\1.0.0.1\sql\00104_CREATE_SP_insumosStock_actualizarRegistro.sql
Pause