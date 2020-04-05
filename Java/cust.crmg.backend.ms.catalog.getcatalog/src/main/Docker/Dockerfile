FROM  personaldomain.azurecr.io/tmp/alpine-netty

# Default to UTF-8 file.encoding
ENV LANG C.UTF-8

ADD *.jar /api/app.jar

# Default workspace dir
WORKDIR /api

ENTRYPOINT [ \
    "java", \
    "-jar", \
    "/api/app.jar" \
]
