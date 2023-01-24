import userService from "~~/services/UserService"

export default function deleteUserProfile(userType: string) {
	switch (userType) {
		case "Student":
			userService.deleteUser(getCookieValue('JWT').id)
			break
		default:
			return new Error("An error occured while deleting your profile.")
	}
}