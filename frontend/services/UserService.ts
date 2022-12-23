import axios from "axios";

export async function postNewUser(data) {

const response = await axios.post('http://localhost:3001/user', data);
return response.data;
}

export async function getAllUsers() {

  const response = await axios.get('http://localhost:3001/user');
  return response.data;
}