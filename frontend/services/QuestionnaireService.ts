import axios from 'axios'

async function postQuestionnaire(userId, data) {
    const response = await axios.post(`http://localhost:3001/users/${userId}/userQuestionnaire`, data)
    return response.data
}

const questionnaireService = {
    postQuestionnaire
}

export default questionnaireService