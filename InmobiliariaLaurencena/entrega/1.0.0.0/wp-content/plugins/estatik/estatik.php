<?php

/**
 * Plugin Name:       Estatik
 * Plugin URI:        http://estatik.net
 * Description:       A simple version of Estatik Real Estate plugin for Wordpress.
 * Version:           3.9.9
 * Author:            Estatik
 * Author URI:        http://estatik.net
 * Text Domain:       es-plugin
 * License:           GPL2
 * License URI:       http://www.gnu.org/licenses/gpl-2.0.txt
 * Domain Path:       /languages
 */

if ( ! defined( 'WPINC' ) ) {
    die;
}

define( 'ES_PLUGIN_URL',               plugin_dir_url( __FILE__ ) );
define( 'ES_PLUGIN_PATH',              dirname( __FILE__ ) );
define( 'ES_ADMIN_IMAGES_URL',         ES_PLUGIN_URL  . 'admin/assets/images/' );
define( 'ES_ADMIN_CUSTOM_STYLES_URL',  ES_PLUGIN_URL  . '/admin/assets/css/custom/' );
define( 'ES_ADMIN_VENDOR_STYLES_URL',  ES_PLUGIN_URL  . '/admin/assets/css/vendor/' );
define( 'ES_ADMIN_CUSTOM_SCRIPTS_URL', ES_PLUGIN_URL  . '/admin/assets/js/custom/'  );
define( 'ES_ADMIN_VENDOR_SCRIPTS_URL', ES_PLUGIN_URL  . '/admin/assets/js/vendor/'  );
define( 'ES_ADMIN_TEMPLATES',          ES_PLUGIN_PATH . '/admin/templates/'         );
define( 'ES_TEMPLATES',                ES_PLUGIN_PATH . '/templates/'               );
define( 'ES_DS',                       DIRECTORY_SEPARATOR                          );
define( 'ES_PLUGIN_BASENAME',          plugin_basename(__FILE__)               );

// Main plugin class.
require_once 'classes/class-estatik-init.php';

// Register function on activate plugin action.
register_activation_hook( __FILE__, array( 'Estatik', 'install' ) );

/**
 * Load plugin textdomain.
 *
 * @since 1.0.0
 */
function es_load_textdomain() {
	load_plugin_textdomain( 'es-plugin', false, dirname( plugin_basename( __FILE__ ) ) . '/languages/' );
}
add_action( 'plugins_loaded', 'es_load_textdomain' );

// Initialize plugin.
Estatik::run();

register_deactivation_hook( __FILE__, array( 'Estatik', 'deactivation' ) );
register_activation_hook( __FILE__, array( 'Estatik', 'activation' ) );

function es_sale_notices() {
    $time_start = strtotime( "2020-12-23T00:00:00" );
    $time_end = strtotime( "2021-01-04T00:00:00" );
    $time_curr = time();

    if ( ! get_option( 'es-xmas' ) && $time_curr < $time_end && $time_curr > $time_start ) : ?>
        <style>
            .notice-xmas {
                background-color: #fff;
                background-size: contain;
                background-repeat: no-repeat;
                background-image: url(<?php echo ES_ADMIN_IMAGES_URL . 'xmas.png'; ?>);
                font-family: 'Open Sans', sans-serif;
                border: 0;
                padding: 5px 0 5px 180px;
                font-size: 10px;
                position: relative;
            }

            .notice-xmas p {
                margin: 0;
                font-size: inherit;
            }

            @media screen and (max-width: 1190px) {
                .notice-xmas {
                    padding: 5px 0 5px 135px;
                    font-size: 8px !important;
                }
            }

            @media screen and (max-width: 850px) {
                .notice-xmas {
                    padding: 5px 0 5px 170px;
                    font-size: 7px !important;
                }
            }

            @media screen and (max-width: 500px) {
                .notice-xmas {
                    background: #fff;
                    padding: 5px 10px;
                }
            }
        </style>
        <div class="es-notice notice notice-xmas">
            <p><span style="color: #E00000; font-style: normal; font-weight: 600; font-size: 1.9em;">Merry Christmas & Happy New Year Sale!</span> <a style="color: #409DE1; font-weight: 600; font-size: 1.9em;" target="_blank" href="https://estatik.net/choose-your-version/">Become PRO</a>
                <span style="color: #212121; font-size: 1.9em;">with up to 25% off discount!</span></p>
            <p style="color: #838383; font-size: 1.6em;">Offer valid till January, 3rd. Do it now.</p>
            <a href="<?php echo add_query_arg( 'es-dismiss-xmas', 1 ); ?>" style="text-decoration: none" class="notice-dismiss"><span class="screen-reader-text">Dismiss this notice.</span></a>
        </div>
    <?php endif;
}
add_action( 'admin_notices', 'es_sale_notices' );

function es_dismiss_xmas() {
    if ( current_user_can( 'manage_options' ) && ! empty( $_GET['es-dismiss-xmas'] ) ) {
        update_option( 'es-xmas', 1 );
    }
}
add_action( 'init', 'es_dismiss_xmas' );