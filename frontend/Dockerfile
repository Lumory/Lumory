FROM node:lts-alpine

WORKDIR /app

COPY package*.json ./

RUN yarn install

COPY . .

RUN yarn build

WORKDIR /app

EXPOSE 3000

CMD [ "yarn", "start" ]