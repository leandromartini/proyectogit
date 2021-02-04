sqlcmd -S SISTEMAS40 -i C:\Proyectosgit\PedroCovino\sql\_EliminarTablaOREliminarContenidoTablasReiniciarIdentity.sql

sqlcmd -S SISTEMAS40 -i \001_CREATE_TABLE_Errores.sql
sqlcmd -S SISTEMAS40 -i \002_CREATE_TABLE_insumos.sql
sqlcmd -S SISTEMAS40 -i \003_CREATE_TABLE_insumosPrecio.sql
sqlcmd -S SISTEMAS40 -i \004_CREATE_TABLE_insumosStock.sql
sqlcmd -S SISTEMAS40 -i \005_CREATE_TABLE_insumosPrecioHist.sql

sqlcmd -S SISTEMAS40 -i \00100_CREATE_SP_errores_actualizarRegistro.sql 
sqlcmd -S SISTEMAS40 -i \00101_CREATE_SP_insumos_actualizarRegistro.sql
sqlcmd -S SISTEMAS40 -i \00101_CREATE_SP_insumos_obtenerLista.sql
sqlcmd -S SISTEMAS40 -i \00101_CREATE_SP_insumos_obtenerListaDetalle.sql
sqlcmd -S SISTEMAS40 -i \00102_CREATE_SP_insumosPrecios_actualizarRegistro.sql
sqlcmd -S SISTEMAS40 -i \00103_CREATE_SP_insumosStock_actualizarRegistro.sql

Pause