import axios from "axios";

class FirstClass {
  path = "http://localhost:44380/api/Person";
  createPerson = data => {
    return axios.post(`${this.path}/Create`);
  };

  GetData = () => {
    return axios.get(`${this.path}`);
  };

  getPerson = id => {
    return axios.get(`${this.path}/${id}`);
  };
}

export default FirstClass;
