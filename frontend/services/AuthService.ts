import axios from	'axios'

function logIn(config) {
	axios.post('http://localhost:3001/Auth/Login', config)
	.then(response => {
		console.log(response.data)
	})
	.catch(error => {
		console.log(error)
	})
}

const authService = {
	logIn
}

export default authService