// https://v3.nuxtjs.org/api/configuration/nuxt.config
export default defineNuxtConfig({
	css: [
		'@/assets/css/cssVars.css',
		'@/assets/css/cssReset.css',
		'@/assets/css/typography.css',
    '@/assets/css/cssGlobal.css',
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
});
