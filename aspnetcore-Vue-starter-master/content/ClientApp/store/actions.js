import axios from 'axios'
export const actions = {
  async getAllTodos({ commit }, data) {
    let response = await axios.get('/api/reports');

    if (response && response.data) {
      let updatedMonth = response.data;
      commit('loadMonth', updatedMonth);
    }
  },
  async addTodo({ dispatch }, data) {
    // Todo: save a new to-do item
    await dispatch('getAllTodos', data.$auth);
  },
  async toggleTodo({ dispatch }, data) {
    // Todo: toggle to-do item completed/not completed
    await dispatch('getAllTodos', data.$auth);
  },
  async deleteTodo({ dispatch }, data) {
    // Todo: delete to-do item
    await dispatch('getAllTodos', data.$auth);
  }
}
