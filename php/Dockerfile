FROM php:7.4-cli
RUN pecl install \
	&& pecl install xdebug-2.8.1 \
	&& docker-php-ext-enable  xdebug

COPY --from=composer/composer:2-bin /composer /usr/bin/composer


