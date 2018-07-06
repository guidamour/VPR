import Vue from 'vue'
import VueRouter from 'vue-router'
import { routes } from './routes'

Vue.use(VueRouter)

let router = new VueRouter({
  mode: 'history',
  routes
});

//router.beforeEach((to, from, next) => {
//  this.$identity.authenticate().then(function () { console.log("Logged in!") })
//});

router.beforeEach((to, from, next) => {
  if (to.meta.requiresAuth) {
    const authUser = JSON.parse(window.localStorage.getItem('lbUser'))
    if (!authUser || !authUser.token) {
      next('/login')
    }
    else if (to.meta.adminAuth) {
      const authUser = JSON.parse(window.localStorage.getItem('lbUser'))
      if (authUser.data.role_id === 'ADMIN') {
        next()
      } else {
        next('/resident')
      }
    } else if (to.meta.residentAuth) {
      const authUser = JSON.parse(window.localStorage.getItem('lbUser'))
      if (authUser.data.role_id === 'RESIDENT') {
        next()
      } else {
        console.log('Im in admin')
        next('/admin')
      }
    }
  } else {
    next()
  }
})
export default router;
