<template>
  <v-form ref="form" v-model="valid" lazy-validation>
    <v-container fluid>
      <v-layout row wrap>
        <v-flex xs12 sm6>
          <v-text-field v-model="email"
                        :rules="emailRules"
                        label="E-mail"
                        required></v-text-field>

          <v-text-field v-model="password"
                        :append-icon="show ? 'visibility_off' : 'visibility'"
                        :rules="[rules.required, rules.min]"
                        :type="show ? 'text' : 'password'"
                        name="input-10-1"
                        label="Please enter your password"
                        hint="At least 8 characters"
                        counter
                        @click:append="show = !show"></v-text-field>

          <v-btn :disabled="!valid"
                 @click="submit">
            Login
          </v-btn>
          <v-btn @click="clear">Cancel</v-btn>

        </v-flex>
      </v-layout>
    </v-container>
  </v-form>
</template>

<script>
  export default {
    data() {
      return {
        valid: true,
        email: '',
        emailRules: [
          v => !!v || 'E-mail is required',
          v => /.+@.+/.test(v) || 'E-mail must be valid'
        ],
        show: false,
        password: '',
        rules: {
          required: value => !!value || 'Required.',
          min: v => v.length >= 8 || 'Min 8 characters',
          emailMatch: () => ('The email and password you entered don\'t match')
        }
      }
    },
    methods: {
      submit() {
        const self = this;
        if (this.$refs.form.validate()) {
          // Native form submission is not yet supported
          this.$http.post('/api/login', {
            email: this.email,
            password: this.password
          }).then(response => {
            const token = response.data.token;
            localStorage.setItem('user-token', token);
            self.$router.push('/');
          })
            .catch(error => {
              localStorage.removeItem('user-token');
              console.log(error.value);
            })

          if (status == '200') {
            self.$router.push('/dashboard');
          }
          
        }
        
      },
      clear() {
        this.$refs.form.reset()
      }
    }
  }
</script>
