export default defineNuxtRouteMiddleware((to, from) => {
	const userCookie = useCookie('JWT').value
	if (userCookie === undefined) {
		setLoggedOut()
		return navigateTo('/signin')
	}
})