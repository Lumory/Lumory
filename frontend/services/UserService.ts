import axios from "axios";

async function postNewUser(data) {

  const response = await axios.post('http://localhost:3001/user', data);
  return response.data;
}

async function getAllUsers() {
  const response = await axios.get('http://localhost:3001/user');
  return response.data;
}

async function getUser(id) {
  const response = await axios.get(`http://localhost:3001/User/${id}`);
  return response.data
}

async function postNewCompany(data) {
  const response = await axios.post('http://localhost:3001/Company', data)
  return response.data;
}

const userService = {
  postNewUser,
  getAllUsers,
  getUser,
  postNewCompany
}

export default userService

