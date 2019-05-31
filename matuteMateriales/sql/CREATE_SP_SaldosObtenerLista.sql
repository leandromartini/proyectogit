USE [MatuteMateriales]
GO
/****** Object:  StoredProcedure [dbo].[ActividadOferta_obtenerLista]    Script Date: 31/05/2019 14:20:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE Procedure [dbo].[Saldos_obtenerLista] --1, -1, 0, -1, 3, '', '01/01/2011', '30/11/2012', -1, -1

@Nombre As [varchar](50) = '',
@fecDesde As Datetime = '01/01/1900',
@fecHasta As Datetime = '01/01/1900',
@LegProf As int = -1,
@CargaHoras As int = -1,

as

set nocount on
DECLARE @sWhere as varchar(512)
DECLARE @sOpe as varchar(7)
DECLARE @sComando as varchar(3072)
BEGIN	
	SET NOCOUNT ON;
	SELECT @sOpe = ' '
	SELECT @sWhere = ' WHERE '
	IF NOT (@codActividad = -1) BEGIN
		SELECT @sWhere = @sWhere + @sOpe + 'ao.codActividad = ' + CONVERT(varchar,@codActividad) 
		SELECT @sOpe = ' AND ' 
	END
	IF NOT (@TpoActividad = -1) BEGIN
		SELECT @sWhere = @sWhere + @sOpe + 'ao.TpoActividad = ' + CONVERT(varchar,@TpoActividad) 
		SELECT @sOpe = ' AND ' 
	END
	
	IF (@multiArea = 1) BEGIN
			SELECT @sWhere = @sWhere + @sOpe + 'at.multiArea = ' + CONVERT(varchar,@multiArea) 
			SELECT @sOpe = ' AND ' 
		END
	ELSE
		IF NOT (@AreaTematica = -1) BEGIN
			SELECT @sWhere = @sWhere + @sOpe + 'at.idArea = ' + CONVERT(varchar,@AreaTematica) 
			SELECT @sOpe = ' AND ' 
		END
		
	IF NOT (@LegProf = -1) BEGIN
		SELECT @sWhere = @sWhere + @sOpe + 'aca.leg_prof = ' + CONVERT(varchar,@LegProf) 
		SELECT @sOpe = ' AND ' 
	END

	IF NOT (@Institucion = -1) BEGIN
		SELECT @sWhere = @sWhere + @sOpe + 'ao.codInstitucion = ' + CONVERT(varchar,@Institucion) 
		SELECT @sOpe = ' AND ' 
	END
	IF NOT (@Nombre = '') BEGIN
		SELECT @sWhere = @sWhere + @sOpe + 'ao.Nombre like ' + '''%' + CONVERT(varchar,@Nombre) + '%'''
		SELECT @sOpe = ' AND ' 
	END

	IF NOT (@fecDesde IS NULL OR @fecDesde = '01/01/1900')
	BEGIN
		SELECT @sWhere = @sWhere + @sOpe + ' ao.fecCreacion between '
		 + '''' + CONVERT(varchar, @fecDesde, 103) + '''' + ' and ' + '''' + CONVERT(varchar, @fecHasta, 103) + ''''
		SELECT @sOpe = ' AND ' 
	END

	IF NOT (@CargaHoras = -1) BEGIN
		SELECT @sWhere = @sWhere + @sOpe + 'ao.CantHoras = ' + CONVERT(varchar,@CargaHoras) 
		SELECT @sOpe = ' AND ' 
	END

	IF NOT (@SFAP = -1) BEGIN
		SELECT @sWhere = @sWhere + @sOpe + 'ao.SFAP = ' + CONVERT(varchar,@SFAP) 
		SELECT @sOpe = ' AND ' 
	END
	
	IF @sWhere = ' WHERE '
		select distinct ao.IdOferta, ao.Nombre, ao.CantHoras as [CargaHoraria], ao.CantMinutos,
		(case at.multiArea
				when 1 then 'MultiArea'
				else tt.descrip 
				end) as [AreaTematica],
		a.descrip as Actividad, ta.descrip as [TipoActividad], ai.descrip as [Institucion], 
		ao.SFAP as [CodigoSFAP],
		(case ao.SFAP 
			when 1 then 'Sí'
			else 'No'
			end) as SFAP,
		ao.codActividad, ao.tpoActividad, ao.TPFinal, ao.cantCreditos, ao.CantHoras, 
		ao.codInstitucion, ao.cod_usu, ao.fecCreacion, CertifTercero,
		ao.NombreCortoWeb
		from ActividadOferta ao
			left join Actividades a ON (ao.codActividad = a.codActividad) 
			left join TposActividades ta ON (ao.codActividad = ta.codActividad and ao.tpoActividad = ta.tpoActividad) 
			left join ActividadInstituciones ai ON (ao.codInstitucion = ai.codInstitucion)
			left join actividadOfertaAreasTematicas at ON (ao.IdOferta = at.IdOferta)
			left join tpos_areas_tematicas tt ON (at.idArea = tt.idArea)
			left join dbo.ActividadClasesDocentes aca ON (aca.idDicta = ao.idOferta)
			--left join dbo.ActividadRolDocentes ard ON (aca.idRol = ard.idRol)
			--left join dbo.ActividadNivelDocentes anid ON (ard.nivelDocente = anid.idNivel)
			--group by ao.IdOferta
			
	ELSE BEGIN
	
		SELECT @sComando = 'select distinct ao.IdOferta, ao.Nombre, ao.CantHoras as [CargaHoraria], ao.CantMinutos,
		(case at.multiArea
				when 1 then ' + '''MultiArea''' + '
				else tt.descrip 
				end) as [AreaTematica],
		a.descrip as Actividad, ta.descrip as [TipoActividad], ai.descrip as [Institucion], 
		ao.SFAP as [CodigoSFAP],
		(case ao.SFAP 
			when 1 then ' + '''Sí''' + '
			else ' + '''No''' + '
			end) as SFAP,
		ao.codActividad, ao.tpoActividad, ao.TPFinal, ao.cantCreditos, ao.CantHoras, 
		ao.codInstitucion, ao.cod_usu, ao.fecCreacion, CertifTercero,
		ao.NombreCortoWeb
		from ActividadOferta ao
			left join Actividades a ON (ao.codActividad = a.codActividad) 
			left join TposActividades ta ON (ao.codActividad = ta.codActividad and ao.tpoActividad = ta.tpoActividad) 
			left join ActividadInstituciones ai ON (ao.codInstitucion = ai.codInstitucion)
			left join actividadOfertaAreasTematicas at ON (ao.IdOferta = at.IdOferta)
			left join tpos_areas_tematicas tt ON (at.idArea = tt.idArea)
			left join dbo.ActividadClasesDocentes aca ON (aca.idDicta = ao.idOferta) ' + @sWhere
			--+ 'group by IdOferta'
		SELECT @sComando = @sComando 
		
		EXECUTE (@sComando)
		--print (@sComando)
	END
END
