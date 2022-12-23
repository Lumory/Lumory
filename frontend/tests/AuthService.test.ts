import axios from 'axios'
import authService from '../services/AuthService'

jest.mock('axios')
describe('Login', () => {


	test('if gets correct response with good data', async () => {
		const mockedAxios = axios as jest.Mocked<typeof axios>
		const data = 	{
				generatedToken: 'eyJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbG…AxIn0.Lyqb8n0c8d-1ulVxspSmd_2GDwykuOAWUT5WwC5M78A',
			 	id: 1
			}
    mockedAxios.post.mockResolvedValue({data:data}) 
		const testData = {
			email: 'henk.pieter.test@gmail.com',
			password: 'Wachtwoord'
		}
		const auth = await authService.logIn(testData)
		expect(auth).toEqual(data)
	})

})