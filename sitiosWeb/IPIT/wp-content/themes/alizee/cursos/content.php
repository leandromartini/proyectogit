<?php
/**
 * @package Alizee
 */
$query = "";
$opts = array('http' =>
		array(
			'method'  => 'GET',
			'content' => $postdata
			)
		);
	$context  = stream_context_create($opts);
	$listaCursos = file_get_contents("https://www.cpbaonline.com.ar/apps/Cursos/listaImplementacion/CursosPublicacionWeb".$query, false, $context);
 
?>

<article >

<!--	echo '<div style="width: 100%; text-align:center">';
<?php for( $i = 0; $i < $listaCursos ; $i++ )
{
	if( $i == 0 )
		$imgDot = 'dotActivo.png';
	else
		$imgDot = 'dotInactivo.png';
	echo '<img src="/images/'.$imgDot.'" style="cursor:pointer" id=dotProxCap_'.$i.' onclick="proxCapCambiarPagina('.$i.')" />';
}?>
echo '</div>';
echo '<div style="clear:both; height: 4px">&nbsp;</div>';-->

</article><!-- #post-## -->