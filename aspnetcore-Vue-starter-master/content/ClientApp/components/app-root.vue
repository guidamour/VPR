<template>
  <v-app id="inspire">
    <nav-bar></nav-bar>
    <nav-sidemenu></nav-sidemenu>
    <v-content>
      <router-view />
    </v-content>
  </v-app>
</template>

<script>
  import NavBar from './HtmlComponents/navbar'
  import NavMenu from './HtmlComponents/navbar-sidemenu'

  export default {
    components: {
      'nav-bar': NavBar,
      'nav-sidemenu': NavMenu
    },

    data() {
      return {}
    }
  }
</script>
<style>

</style>
