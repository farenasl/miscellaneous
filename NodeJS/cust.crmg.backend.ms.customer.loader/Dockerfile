FROM mypersonaldomain.azurecr.io/secaas/node:8-latest

RUN mkdir -p /home/node/app/node_modules && chown -R node:node /home/node/app
WORKDIR /home/node/app

ARG NODE_ENV
ENV NODE_ENV $NODE_ENV

COPY package.json /home/node/app/
RUN npm install

COPY . /home/node/app/

ENV env start

CMD [ "npm", "run", "start" ]