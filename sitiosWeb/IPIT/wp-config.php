<?php
/**
 * The base configuration for WordPress
 *
 * The wp-config.php creation script uses this file during the
 * installation. You don't have to use the web site, you can
 * copy this file to "wp-config.php" and fill in the values.
 *
 * This file contains the following configurations:
 *
 * * MySQL settings
 * * Secret keys
 * * Database table prefix
 * * ABSPATH
 *
 * @link https://codex.wordpress.org/Editing_wp-config.php
 *
 * @package WordPress
 */

// ** MySQL settings - You can get this info from your web host ** //
/** The name of the database for WordPress */
define( 'DB_NAME', 'ipit' );

/** MySQL database username */
define( 'DB_USER', 'root' );

/** MySQL database password */
define( 'DB_PASSWORD', '' );

/** MySQL hostname */
define( 'DB_HOST', 'localhost' );

/** Database Charset to use in creating database tables. */
define( 'DB_CHARSET', 'utf8mb4' );

/** The Database Collate type. Don't change this if in doubt. */
define( 'DB_COLLATE', '' );

/**#@+
 * Authentication Unique Keys and Salts.
 *
 * Change these to different unique phrases!
 * You can generate these using the {@link https://api.wordpress.org/secret-key/1.1/salt/ WordPress.org secret-key service}
 * You can change these at any point in time to invalidate all existing cookies. This will force all users to have to log in again.
 *
 * @since 2.6.0
 */
define( 'AUTH_KEY',         '_&vKCIJk8f/_5,$P*M{ &J{d2o3]2QhAI-aoxI5I+~NW+mBO{`,~:jmD9u@J.5lE' );
define( 'SECURE_AUTH_KEY',  '^FCW1Fn/X&u#sS3eKO*O1%e`<~HHn2U085 @X,^VuM={uF[zlZPQJ5<-&Xyrq((A' );
define( 'LOGGED_IN_KEY',    'K$jR K*vR?VR/?:U;L~RM6?qX*Z0.AjC2O#m1}vWL#GT+G>fLf%T{mGR*+q`{BHd' );
define( 'NONCE_KEY',        ':nQQc]EiE6;gO;8lM)5)q=Y!y(pay-*<L6ZuJ|#Xn^_pFNt[e?OQK)j|@K.Zq9cz' );
define( 'AUTH_SALT',        'By>f7LKrwbsRJm(8nRjr@WLXOOo#,{1<E:d%[ePDXj hhe9G[[8=y%e0*yJej=wF' );
define( 'SECURE_AUTH_SALT', '0c+N2Zr$e&v 6=qNN-TlDiBPan+MyBqSbcKQlPJZBq>kt_0(>k3f$qzwtA7QK8./' );
define( 'LOGGED_IN_SALT',   '_QZa9>YHx.XaL u: GRi?<1?|;lsN=(a=i/GC#v=wr@ bbvW]Z|ePTg_A=F9eo}-' );
define( 'NONCE_SALT',       '~S{6yJHqkUz_`tBYpM+Tl!AYd(n,Vq,1E%au:jiNLhBHkEgubhQ34hFML[gkO=T;' );

/**#@-*/

/**
 * WordPress Database Table prefix.
 *
 * You can have multiple installations in one database if you give each
 * a unique prefix. Only numbers, letters, and underscores please!
 */
$table_prefix = 'wp_';

/**
 * For developers: WordPress debugging mode.
 *
 * Change this to true to enable the display of notices during development.
 * It is strongly recommended that plugin and theme developers use WP_DEBUG
 * in their development environments.
 *
 * For information on other constants that can be used for debugging,
 * visit the Codex.
 *
 * @link https://codex.wordpress.org/Debugging_in_WordPress
 */
define( 'WP_DEBUG', false );

/* That's all, stop editing! Happy publishing. */

/** Absolute path to the WordPress directory. */
if ( ! defined( 'ABSPATH' ) ) {
	define( 'ABSPATH', dirname( __FILE__ ) . '/' );
}

/** Sets up WordPress vars and included files. */
require_once( ABSPATH . 'wp-settings.php' );
