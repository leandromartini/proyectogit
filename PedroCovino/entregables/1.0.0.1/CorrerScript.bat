sqlcmd -S SISTEMAS40 -i C:\Users\leandro.lacrouts\proyectogit\PedroCovino\sql\001_CREATE_TABLE_Errores.sql
sqlcmd -S SISTEMAS40 -i C:\Users\leandro.lacrouts\proyectogit\PedroCovino\sql\002_CREATE_TABLE_insumos.sql
sqlcmd -S SISTEMAS40 -i C:\Users\leandro.lacrouts\proyectogit\PedroCovino\sql\003_CREATE_TABLE_insumosPrecio.sql
sqlcmd -S SISTEMAS40 -i C:\Users\leandro.lacrouts\proyectogit\PedroCovino\sql\004_CREATE_TABLE_insumosStock.sql
sqlcmd -S SISTEMAS40 -i C:\Users\leandro.lacrouts\proyectogit\PedroCovino\sql\005_CREATE_TABLE_insumosPrecioHist.sql

sqlcmd -S SISTEMAS40 -i C:\Users\leandro.lacrouts\proyectogit\PedroCovino\sql\00100_CREATE_SP_errores_actualizarRegistro.sql 
sqlcmd -S SISTEMAS40 -i C:\Users\leandro.lacrouts\proyectogit\PedroCovino\sql\00101_CREATE_SP_insumos_actualizarRegistro.sql
sqlcmd -S SISTEMAS40 -i C:\Users\leandro.lacrouts\proyectogit\PedroCovino\sql\00101_CREATE_SP_insumos_obtenerLista.sql
sqlcmd -S SISTEMAS40 -i C:\Users\leandro.lacrouts\proyectogit\PedroCovino\sql\00101_CREATE_SP_insumos_obtenerListaDetalle.sql
sqlcmd -S SISTEMAS40 -i C:\Users\leandro.lacrouts\proyectogit\PedroCovino\sql\00102_CREATE_SP_insumosPrecios_actualizarRegistro.sql
sqlcmd -S SISTEMAS40 -i C:\Users\leandro.lacrouts\proyectogit\PedroCovino\sql\00103_CREATE_SP_insumosStock_actualizarRegistro.sql

Pause