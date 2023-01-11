export default defineNuxtRouteMiddleware((to, from) => {
	const userCookie = useCookie('JWT').value
	if (userCookie === undefined) {
		return navigateTo('/signin')
	}
})