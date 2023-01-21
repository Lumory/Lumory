import axios from "axios"
import InternshipService from '../services/InternshipService'

jest.mock("axios")
describe('GET request', () => {

    test('to see if data is being received',  async () => {
        const mockedAxios = axios as jest.Mocked<typeof axios>
        const data = {
            id: '',
            companyId: '',
            problem: '',
            problemDescription: '',
            skillsIntern: '',
            skillsInternDescription: '',
            qualitiesIntern: '',
            qualitiesInternDescription: '',
            sector: '',
            sectorDescription: '',
            teamwork: '',
            teamworkDescription: '',
            mentorship: '',
            mentorshipDescription: '',
            money: '',
            remoteWork: '',
            function: '',
            responsability: '',
            workExperience: '',
            staff: '',
            website: '',
            streetAddress: '',
            city: '',
            contactPersonFirstName: '',
            contactPersonLastName: '',
            contactPersonEmail: '',
            international: '',
            dateStart: '',
            hours: 0,
            applyBefore: '',
            createdAt: '',
            updatedAt: '',
        }
        mockedAxios.get.mockResolvedValue({data:data})
        const get = await InternshipService.getInternships()
        expect(get).toEqual(data)
    })

})