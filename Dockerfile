FROM nginx:1.19.6
COPY ./site /usr/share/nginx/html
EXPOSE 80