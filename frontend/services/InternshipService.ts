import axios from 'axios'

async function getInternships() {
    const response = await axios.get('http://localhost:3001/Internships')
    return response.data
}
async function getInternship(id) {
    const response = await axios.get(`http://localhost:3001/Internship/${id}`)
    return response.data
}

const internshipService  = {
    getInternships,
    getInternship
}

export default internshipService
