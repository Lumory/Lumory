export default function getProfileInitials(cookieName: string) {
	let cookie = getCookieValue(cookieName)
	if (typeof cookie === "object") {
		let firstLetter = cookie.firstName.at(0)
		let lastLetter = cookie.lastName.at(0)
		let initials = firstLetter.toUpperCase() + "." + lastLetter.toUpperCase()
		return initials
	}
	return undefined
}