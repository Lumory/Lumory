export default defineNuxtRouteMiddleware((to, from) => {
	const userCookie = useCookie('user').value
	if (userCookie === undefined) {
		setLoggedOut()
		return navigateTo('/signin')
	}
})