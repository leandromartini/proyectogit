<?php
/**
 * This template is used for the website header
 *
 * @package Baskerville 2
 */
?>
<!DOCTYPE html>
<html <?php language_attributes(); ?>>
<head>
	<meta charset="<?php bloginfo( 'charset' ); ?>">
	<meta name="viewport" content="width=device-width, initial-scale=1.0" >
	<link rel="profile" href="http://gmpg.org/xfn/11" />
        <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css">
        <link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.9.0/css/all.css">
        <link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.9.0/css/v4-shims.css">
	<?php wp_head(); ?>
</head>

<body <?php body_class(); ?>>
        <div class="navigation section no-padding bg-dark">
		<nav id="site-navigation" class="navigation-inner section-inner clear" role="navigation">
			<button class="nav-toggle fleft" aria-controls="primary-menu" aria-expanded="false"><?php esc_html_e( 'Menu', 'baskerville-2' ); ?></button>
			<div class="main-navigation">
				<?php
					wp_nav_menu( array(
						'container'      => '',
						'theme_location' => 'menu-1',
						'menu_id'        => 'primary-menu',
					) );
				?>
			</div>

			<a class="search-toggle search-icon fright" href="#"><?php esc_html_e( 'Open Search', 'baskerville-2' ); ?></a>
		</nav> <!-- /navigation-inner -->
	</div> <!-- /navigation -->
	<a class="screen-reader-text skip-link" href="#content"><?php esc_html_e( 'Skip to content', 'baskerville-2' ); ?></a>

	<header class="header section small-padding bg-dark bg-image" style="background-image: url(<?php if ( '' !== get_header_image() ) { echo esc_url( get_header_image() ); } ?>);" role="banner">

		<a href="<?php echo esc_url( home_url( '/' ) ); ?>" rel="home">
			<div class="cover"></div>
		</a>

		<a href="#search-container" class="screen-reader-text search-toggle"><?php esc_html_e( 'Search', 'baskerville-2' ); ?></a>
		<div class="header-search-block bg-graphite hidden" id="search-container">
			<?php get_search_form(); ?>
		</div> <!-- /header-search-block -->

		<div class="header-inner section-inner">

			<?php the_custom_logo(); ?>

			<?php
			if ( is_front_page() && is_home() ) : ?>
				<h1 class="site-title"><a href="<?php echo esc_url( home_url( '/' ) ); ?>" rel="home"><?php bloginfo( 'name' ); ?></a></h1>
			<?php else : ?>
				<p class="site-title"><a href="<?php echo esc_url( home_url( '/' ) ); ?>" rel="home"><?php bloginfo( 'name' ); ?></a></p>
			<?php
			endif;
			$description = get_bloginfo( 'description', 'display' );
			if ( $description || is_customize_preview() ) : ?>
				<p class="site-description"><?php echo $description; /* WPCS: xss ok. */ ?></p>
			<?php
			endif; ?>

			<?php baskerville_2_social_menu(); ?>

		</div> <!-- /header-inner -->
	</header> <!-- /header -->

	<div class="filter-search">
		<div class="container">
			<form action="" class="filter-form" method="get">
				<select name="localidad">
                    <option selected="selected" disabled="disabled">Localidad</option>
                    <option value="el-bolson">El Bolsón</option><option value="el-hoyo">El Hoyo</option><option value="lago-puelo">Lago Puelo</option><option value="san-carlos-de-bariloche">San Carlos de Bariloche                </option></select>
				<select name="propiedades">
                    <option selected="selected" disabled="disabled">Propiedad</option>
                    <option value="cabanas">Cabañas</option><option value="campos">Campos</option><option value="casas">Casas</option><option value="chacras">Chacras</option><option value="complejos">Complejos</option><option value="departamentos">Departamentos</option><option value="duplex">Duplex</option><option value="loteos">Loteos</option><option value="terrenos">Terrenos                </option></select>
				<select name="operacion" id="select-operation" onchange="operationSelect()">
					<option selected="selected" disabled="disabled">Operación</option>
					<option value="alquiler por dia">Alquileres por día</option>
					<option value="alquiler 24 meses">Alquileres por 24 Meses</option>
					<option value="venta">Ventas</option>
				</select>
                <select name="precio" id="range-price">
                	<option selected="selected" disabled="disabled">Rango de Precios</option>
                	<option value="25000">0 - 25.000</option>
                	<option value="50000">25.000 - 50.000</option>
                	<option value="75000">50.000 - 75.000</option>
                	<option value="100000">75.000 - 100.000</option>
                	<option value="125000">100.000 - 125.000</option>
                	<option value="150000">125.000 - 150.000</option>
                	<option value="150001">+150.000</option>
                </select>
				<button class="site-btn fs-submit">BUSCAR</button>
			</form>
		</div>
	</div>
