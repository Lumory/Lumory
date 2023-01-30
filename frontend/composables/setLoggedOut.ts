export default function setLoggedOut() {
	useCookie('JWT').value = null;
	useCookie('user').value = null;
}