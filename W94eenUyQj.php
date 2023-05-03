<?php
## Исполняемый PHP код в контенте записи WordPress.
## [exec]PHP_код[/exec]
##
## @version: 1.0
if( 'Исполняемый PHP код в контенте' ){

    add_filter( 'the_content', 'content_exec_php', 0 );

    function content_exec_php( $content ){
        return preg_replace_callback( '/\[exec( off)?\](.+?)\[\/exec\]/s', '_content_exec_php', $content );
    }

    function _content_exec_php( $matches ){

        if( ' off' === $matches[1] ){
            return "\n\n<".'pre>'. htmlspecialchars( $matches[2] ) .'</pre'.">\n\n";
        }
        else {
            eval( "ob_start(); {$matches[2]}; \$exec_php_out = ob_get_clean();" );
            return $exec_php_out;
        }

    }

}
?>
