<?php
/**
 * This is the main generic template file of the theme
 *
 * @package Baskerville 2
 */
get_header(); ?>

<div class="wrapper section medium-padding clear">

	<main class="content section-inner" id="content" role="main">
            
            <div class="section-title text-center">
				<h3>PROPIEDADES DESTACADAS</h3>
				<p>Conoce nuestras propiedades destacadas</p>
                                
	    </div>
            
		<?php if ( have_posts() ) :

			if ( is_home() && ! is_front_page() ) : ?>
				<header>
					<h1 class="page-title screen-reader-text"><?php single_post_title(); ?></h1>
				</header>

			<?php
			endif; ?>
			<div class="posts" id="posts">

				<div class="spinner-container">
					<div id="spinner">
						<div class="double-bounce1"></div>
						<div class="double-bounce2"></div>
					</div>
				</div>

				<?php while ( have_posts() ) : the_post();
					get_template_part( 'content', get_post_format() );
				endwhile; ?>
			</div> <!-- /posts -->
			<?php the_posts_navigation(); ?>
			<?php else :
				get_template_part( 'content', 'none' );
			?>
		<?php endif; ?>

	</main> <!-- /content -->       
         
</div> <!-- /wrapper -->
<div class="parallax">
<div class="container">
			<div class="row">
				<div class="col-lg-6 my-auto">
											<h1 class="site-title"><a href="http://localhost:8080/wordpress/" rel="home">inmobiliaria</a></h1>  
									</div>
				<div class="col-lg-5 offset-lg-1 pl-lg-0">
					<div class="section-title text-white">
					<h3>NUESTROS SERVICIOS</h3>
                                        <p>Brindamos el servicio perfecto para</p>
					</div>
					<div class="services">
						<div class="service-item">
							<i class="fa fa-home"></i>
							<div class="service-text">
								<h5>Alquileres</h5>
								<p>Te brindamos toda la información que necesitás saber para ingresar a un alquiler (Garantías, condiciones, etc).</p>
							</div>
						</div>
						<div class="service-item">
							<i class="fas fa-handshake"></i>
							<div class="service-text">
								<h5>Ventas</h5>
								<p>Nuestros Profesionales están para asesorarte en la compra/venta y ayudarte a encontrar lo que buscás.</p>
							</div>
						</div>
						<div class="service-item">
							<i class="fas fa-edit"></i>
							<div class="service-text">
								<h5>Tasaciones</h5>
								<p>Tasamos tu Propiedad con el mayor compromiso. Contamos con profesionales capacitados acompañándote siempre.</p>
							</div>
						</div>
											</div>
				</div>
			</div>
</div>
</div>
<div class="wrapper section medium-padding clear">

	<main class="content section-inner" id="content" role="">
            
            <div class="section-title text-center">
				<h3>PROPIEDADES RECIENTES</h3>
				<p>Conoce nuestras propiedades recientes</p>
                                
	    </div>
            
		<?php if ( have_posts() ) :

			if ( is_home() && ! is_front_page() ) : ?>
				<header>
					<h1 class="page-title screen-reader-text"><?php single_post_title(); ?></h1>
				</header>

			<?php
			endif; ?>
			<div class="posts" id="posts">

				<div class="spinner-container">
					<div id="spinner">
						<div class="double-bounce1"></div>
						<div class="double-bounce2"></div>
					</div>
				</div>

				<?php while ( have_posts() ) : the_post();
					get_template_part( 'content', get_post_format() );
				endwhile; ?>
			</div> <!-- /posts -->
			<?php the_posts_navigation(); ?>
			<?php else :
				get_template_part( 'content', 'none' );
			?>
		<?php endif; ?>

	</main> <!-- /content -->       
         
</div> <!-- /wrapper -->         
<?php get_footer(); ?>
