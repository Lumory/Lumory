export default defineNuxtRouteMiddleware((to, from) => {
	const userCookie = useCookie('user').value
	if (userCookie === undefined) {
		console.log('not logged in')
		return navigateTo('/signin')
	}
})