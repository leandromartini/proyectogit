<?php
/**
 * The Header for our theme.
 *
 * Displays all of the <head> section and everything up till <div id="content">
 *
 * @package Alizee
 */
?><!DOCTYPE html>
<html <?php language_attributes(); ?>>
    <head>
        <meta charset="<?php bloginfo('charset'); ?>">
        <meta name="viewport" content="width=device-width, initial-scale=1">
        <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.4/css/bootstrap.min.css">
        <script src="https://cdnjs.cloudflare.com/ajax/libs/jquery/2.1.3/jquery.min.js"></script>
        <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.4/js/bootstrap.min.js"></script>
        <link rel="profile" href="http://gmpg.org/xfn/11">
        <link rel="pingback" href="<?php bloginfo('pingback_url'); ?>">
        <?php if (get_theme_mod('site_favicon')) : ?>
            <link rel="shortcut icon" href="<?php echo esc_url(get_theme_mod('site_favicon')); ?>" />
        <?php endif; ?>

        <?php wp_head(); ?>
    </head>


    <body <?php body_class(); ?>>

        <div id="page" class="hfeed site">
            <a class="skip-link screen-reader-text" href="#content"><?php _e('Skip to content', 'alizee'); ?></a>

            <div id="headertop" class="fix" style="background-color: #013413">
                <div class="container">
                    <div class="row">
                        <div class="col-md-4 col-sm-3 col-xs-4">   
                            <h1 style="color: #ffffff;">IPIT</h1>                            
                        </div>
                        <div class="col-md-8 col-sm-9 col-xs-8">
                        </div>                    
                    </div>
                </div>
            </div><!-- #headertop --> 

            <section class="awSlider">
                <div class="carousel slide" data-ride="carousel">

                    <ol class="carousel-indicators">
                        <li data-target=".carousel" data-slide-to="0" class=""></li>
                        <li data-target=".carousel" data-slide-to="1" class="active"></li>
                        <li data-target=".carousel" data-slide-to="2" class=""></li>
                        <li data-target=".carousel" data-slide-to="3" class=""></li>
                    </ol>
                    <nav id="site-navigation" class="main-navigation" role="navigation">
                        <div class="container">
                            <button class="menu-toggle btn"><i class="fa fa-bars"></i></button>
                            <?php wp_nav_menu(array('theme_location' => 'primary')); ?>
                        </div>	
                    </nav><!-- #site-navigation -->
                    <div class="carousel-inner" role="listbox">                            
                        <div class="item active left">
                            <img src="http://localhost:8080/IPIT/wp-content/themes/alizee/images/image1.jpg">
                            <div class="carousel-caption">Agregar una leyenda</div>
                        </div>
                        <div class="item next left">
                            <img src="http://localhost:8080/IPIT/wp-content/themes/alizee/images/image1.jpg">
                            <div class="carousel-caption">Agregar una leyenda</div>
                        </div>
                        <div class="item">
                            <img src="http://localhost:8080/IPIT/wp-content/themes/alizee/images/image1.jpg">
                            <div class="carousel-caption">Agregar una leyenda</div>
                        </div>
                        <div class="item">
                            <img src="http://localhost:8080/IPIT/wp-content/themes/alizee/images/image1.jpg">
                            <div class="carousel-caption">Agregar una leyenda</div>
                        </div>
                    </div>

                    <a class="left carousel-control" href=".carousel" role="button" data-slide="prev">
                        <span class="glyphicon glyphicon-chevron-left" aria-hidden="true"></span>
                        <span class="sr-only">Geri</span>
                    </a>
                    <a class="right carousel-control" href=".carousel" role="button" data-slide="next">
                        <span class="glyphicon glyphicon-chevron-right" aria-hidden="true"></span>
                        <span class="sr-only">İleri</span>
                    </a>
                </div>		
            </section> <!-- #awSlider --> 	

            <?php if (get_header_image()) : ?>
                <header id="masthead" class="site-header has-banner" role="banner">
                <?php else : ?>
                    <header id="masthead" class="site-header" role="banner">
                    <?php endif; ?>                       
                    <div class="container">
                        <div class="site-branding">
                            <?php if (get_theme_mod('site_logo')) : ?>
                                <a href="<?php echo esc_url(home_url('/')); ?>" title="<?php bloginfo('name'); ?>"><img src="<?php echo esc_url(get_theme_mod('site_logo')); ?>" alt="<?php bloginfo('name'); ?>" /></a>
                            <?php else : ?>
                                <?php if (display_header_text()) : ?>
                                    <?php if (is_front_page() && is_home()) :
                                        ?>
                                        <h1 class="site-title"><a href="<?php echo esc_url(home_url('/')); ?>" rel="home"><?php bloginfo('name'); ?></a></h1>
                                        <?php
                                    else :
                                        ?>
                                        <p class="site-title"><a href="<?php echo esc_url(home_url('/')); ?>" rel="home"><?php bloginfo('name'); ?></a></p>
                                    <?php endif; ?>
                                    <p class="site-description"><?php bloginfo('description'); ?></p>
                                <?php endif; ?>
                            <?php endif; ?>
                        </div>
                    </div>
                    <?php if (is_home()) : ?>
                        <div class="sidebar-toggle"><i class="fa fa-plus"></i></div>
                    <?php endif; ?>
                    <?php if (has_nav_menu('social')) : ?>
                        <nav class="social-navigation clearfix">
                            <?php wp_nav_menu(array('theme_location' => 'social', 'link_before' => '<span class="screen-reader-text">', 'link_after' => '</span>', 'container_class' => 'container', 'menu_class' => 'menu clearfix', 'fallback_cb' => false)); ?>
                        </nav>
                        <div class="social-toggle"><i class="fa fa-facebook"></i></div>
                    <?php endif; ?>
                </header><!-- #masthead -->

                <div id="content" class="site-content container">