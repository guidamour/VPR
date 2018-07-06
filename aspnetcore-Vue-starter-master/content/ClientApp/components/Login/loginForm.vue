<template>
  <v-form ref="form" v-model="valid" lazy-validation>
    <v-container fluid>
      <v-layout row wrap>
        <v-flex xs12 sm6>
          <v-text-field v-model="loginDetails.email"
                        :rules="emailRules"
                        label="E-mail"
                        required></v-text-field>

          <v-text-field v-model="loginDetails.password"
                        :append-icon="show ? 'visibility_off' : 'visibility'"
                        :rules="[rules.required, rules.min]"
                        :type="show ? 'text' : 'password'"
                        name="input-10-1"
                        label="Please enter your password"
                        hint="At least 8 characters"
                        counter
                        @click:append="show = !show"></v-text-field>

          <v-btn :disabled="!valid"
                 @click="loginUser">
            Login
          </v-btn>
          <v-btn @click="clear">Cancel</v-btn>

        </v-flex>
      </v-layout>
    </v-container>
  </v-form>
</template>

<script>
  import loginService from './loginService.js';
  export default {
    data() {
      return {
        valid: true, 
        emailRules: [
          v => !!v || 'E-mail is required',
          v => /.+@.+/.test(v) || 'E-mail must be valid'
        ],
        show: false,
        rules: {
          required: value => !!value || 'Required.',
          min: v => v.length >= 8 || 'Min 8 characters',
          emailMatch: () => ('The email and password you entered don\'t match')
        },
        loginDetails: {
          email: '',
          password: ''
        },
      }
    },
    methods: {
      loginUser: function () {
        const authUser = {}
        var app = this;
        loginService.login(this.loginDetails)
          .then(function (res) {
            if (res.status === "success") {
              authUser.data = res.data;
              authUser.token = res.token;
              app.$store.state.isLoggedIn = true
              window.localStorage.setItem('lbUser', JSON.stringify(authUser));
              //if (authUser.data.role_id === 'ADMIN') {
              //  app.$router.push('/admin');
              //} else {
              //  app.$router.push('/resident');
              //}
              app.$router.push('/quickReports');
            } else {
              app.$store.state.isLoggedIn = false;
            }
          })
          .catch(function (err) {
            console.log(err.data)
          })
      },
      loginAuth: function () {
        var app = this;
        const status = JSON.parse(window.localStorage.getItem('lbUser'));
        if (status === null || status === undefined) {
          app.$router.push('/login');
        }
        //else if (status.data.role_id === 'ADMIN') {
        //  app.$router.push('/quickReports');
        //}
        else {
          app.$router.push('/dashboard');
        }
      },
      clear() {
        this.$refs.form.reset()
      }
    },
    created: function () {
      this.loginAuth();
    }
  }
</script>
