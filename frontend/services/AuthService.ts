import axios from	'axios'

async function logIn(config: object) {
	const response = await axios.post('http://localhost:3001/Auth/Login', config)
	return response.data
}

const authService = {
	logIn
}

export default authService