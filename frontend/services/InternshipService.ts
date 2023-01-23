import axios from 'axios'

async function postInternship(companyId, data) {
    const response = await axios.post(`http://localhost:3001/companies/${companyId}/internship`, data)
    return response.data
}

const internshipService = {
    postInternship
}

export default internshipService