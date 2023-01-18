import axios from "axios"
import InternshipService from '../services/InternshipService'

jest.mock("axios")

test("good response", () => {
    axios.get.mockImplementation(() => Promise.resolve({ data: {status: 200} }));
});