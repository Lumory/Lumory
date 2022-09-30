// https://v3.nuxtjs.org/api/configuration/nuxt.config
export default defineNuxtConfig({
  css: [
    // CSS file in the project
    '@/assets/css/global.css',
  ],
  alias: {
    '~  ': '<rootDir>/assets'
  },
  head: {
    meta: [
      {name: 'viewport', content: 'width=device-width, initial-scale=1'}
    ],
  },
  ssr: false,
})
