import Vue from 'vue'
import Vuex from 'vuex'

Vue.use(Vuex)

// TYPES


// STATE
const state = {
  currentJWT: ''
}

// MUTATIONS
const mutations = {
  setJWT(state, jwt) {
    state.currentJWT = jwt;
  }
}

// ACTIONS
const actions = {
  async fetchJWT({ commit }, { username, password }) {
    // const res = axios.get('url').then().catch()
    //commit('setJWT', await res.text());
  }
}

const getters = {
  jwt: state => state.currentJWT,
  jwtData: (state, getters) => state.currentJWT ? JSON.parse(atob(getters.jwt.split('.')[1])) : null,
  jwtSubject: (state, getters) => getters.jwtData ? getters.jwtData.sub : null,
  jwtIssuer: (state, getters) => getters.jwtData ? getters.jwtData.iss : null
}

export default new Vuex.Store({
  state,
  mutations,
  actions,
  getters
})
