<template>
  <v-toolbar :clipped-left="$vuetify.breakpoint.lgAndUp"
             light
             app
             fixed>
    <v-toolbar-title style="width: 300px" class="ml-0 pl-3">
      <span class="hidden-sm-and-down"><img src="../img/VPR_Logo_NoText.png" alt="VPR" style="margin-left:30px;  width:80px;"></span>
    </v-toolbar-title>
    <v-spacer></v-spacer>
    <form>
      <input type="text" name="search" placeholder="Search.." />
    </form>
    <v-btn icon>
      <v-icon>notifications</v-icon>
    </v-btn>
    <v-menu v-model="menu"
            :close-on-content-click="false"
            :nudge-width="200"
            offset-x>
      <v-btn slot="activator" icon style="margin-right:20px">
        <v-icon>person</v-icon>
      </v-btn>

      <v-card>
        <v-list>
          <v-list-tile avatar>
            <v-list-tile-avatar>
              <img src="../img/ProfileImage.png" alt="John">
            </v-list-tile-avatar>
            <v-list-tile-content>
              <v-list-tile-title>Guillaume D'Amour</v-list-tile-title>
              <v-list-tile-sub-title>VPR Coordinator</v-list-tile-sub-title>
            </v-list-tile-content>
          </v-list-tile>
        </v-list>

        <v-divider></v-divider>

        <v-list>
          <v-list-tile @click="" centered>
              <v-list-tile-title class="center-text">Enable messages</v-list-tile-title>
          </v-list-tile>

          <v-list-tile @click="">
            <v-list-tile-title class="center-text">Enable hints</v-list-tile-title>
          </v-list-tile>
        </v-list>

        <v-card-actions >
          <v-btn class="centered-btn" flat @click="menu = false">Cancel</v-btn>
        </v-card-actions>
      </v-card>
    </v-menu>
  </v-toolbar>
</template>

<script>
export default {
    data: () =>  ({
      menu: false
    })
}
</script>

<style scoped>
  input[type=text] {
  width: 80%;
  box-sizing: border-box;
  border: 2px solid #ccc;
  border-radius: 20px;
  font-size: 16px;
  background-color: white;
  background-image: url('../img/search.png');
  background-size:18px;
  background-position: 13px 15.2px;
  background-repeat: no-repeat;
  padding: 12px 20px 12px 40px;
  -webkit-transition: width 0.4s ease-in-out;
  transition: width 0.4s ease-in-out;
  }

  input[type=text]:focus {
  width: 100%;
  outline-style: inherit;
  }

  v-toolbar {
    background-color: #F9FBFF;
  }

  .centered-btn {
    width: 100%;
    text-align: center;

  }

  .center-text{
    text-align: center;
  }
</style>


