
FROM python:3-alpine

LABEL maintainer "Rahul Chandra <1rahulchandra1@gmail.com>"

COPY . /usr/src/
WORKDIR /usr/src

RUN apk add --no-cache --virtual .build-deps \
    gcc libc-dev libxml2-dev libxslt-dev \
  && apk add --no-cache libxml2 libxslt \
  && apk add --no-cache libqrencode \
  && pip3 install --no-cache-dir . \
  && find /usr/local -name *.pyo -o -name *.pyc -exec rm -f '{}' \; \
  && apk del .build-deps && touch /root/.vipaccess

ENTRYPOINT ["/usr/local/bin/vipaccess"]
