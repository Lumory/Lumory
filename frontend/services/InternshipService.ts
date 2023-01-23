import axios from 'axios'

async function getInternships() {
    const response = await axios.get('http://localhost:3001/Internships')
    return response.data
}
const getService = {
    getInternships
}

export default getService