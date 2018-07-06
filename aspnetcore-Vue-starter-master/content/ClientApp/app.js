import Vue from 'vue';
import axios from 'axios';
import router from './router/index';
import store from './store';
import header from './config'
import { sync } from 'vuex-router-sync';
import App from 'components/app-root';
import { FontAwesomeIcon } from './icons';
import Vuetify from 'vuetify';
import vuex from 'vuex';
import VueResource from 'vue-resource';
import VueIdentity from 'vue-identity';


// Registration of global components
Vue.component('icon', FontAwesomeIcon);
Vue.component('app-header', header);
Vue.use(Vuetify);
Vue.prototype.$http = axios;
Vue.use(vuex);
Vue.use(VueResource);
Vue.use(VueIdentity,
  {
    url: "/login"
  });

sync(store, router);

const app = new Vue({
  store,
  router,
  ...App
});

export {
  app,
  router,
  store
}
