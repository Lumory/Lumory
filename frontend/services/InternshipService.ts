import axios from 'axios'

async function getInternships() {
    const response = await axios.get('http://localhost:3001/Internships')
    return response.data
}
async function getInternship(id) {
    const response = await axios.get(`http://localhost:3001/Internship/${id}`)
    return response.data
}

async function getCompanyInternships(id) {
    const response = await axios.get(`http://localhost:3001/companies/${id}/internship`)
    return response.data
}

async function postInternship(companyId, data) {
    const response = await axios.post(`http://localhost:3001/companies/${companyId}/internship`, data)
    return response.data
}

const internshipService  = {
    getInternships,
    getInternship,
    getCompanyInternships,
    postInternship,
}

export default internshipService

