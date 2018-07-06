import Vue from 'vue';
import axios from 'axios';
export default {


  login(value, cb) {
    return new Promise(function (resolve, reject) {
      axios.post('http://localhost:61513/api/login', value)
        .then(function (res) {
          resolve(res.data);
        })
        .catch(function (err) {
          reject(err.response.data)
        })
    });
  }
}
