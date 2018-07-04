<template>
  <v-navigation-drawer :clipped="$vuetify.breakpoint.lgAndUp"
                       style="background: linear-gradient(#004B6F, #176A8E);"
                       dark
                       v-model="drawer"
                       fixed
                       app
                       permanent
                       hide-overlay
                       stateless>
    <v-list dense>
      <template v-for="item in items">
        <v-divider v-if="item.divider" :key="item.header"></v-divider>
        <v-layout v-if="item.heading" :key="item.heading" row align-center>
          <v-flex xs6>
            <v-subheader v-if="item.heading">
              {{ item.heading }}
            </v-subheader>
          </v-flex>
          <v-flex xs6 class="text-xs-center">
            <a href="#!" class="body-2 black--text">EDIT</a>
          </v-flex>
        </v-layout>
        <v-list-group v-else-if="item.children"
                      v-model="item.model"
                      :key="item.text"
                      :prepend-icon="item.model ? item.icon : item['icon-alt']"
                      append-icon="">
          <v-list-tile slot="activator">
            <v-list-tile-content>
              <v-list-tile-title>
                {{ item.title }}
              </v-list-tile-title>
            </v-list-tile-content>
          </v-list-tile>
          <v-list-tile v-for="(child, i) in item.children"
                       :key="i"
                       @click=""
                       :to="child.route"
                       class="customChild"
                       dense="true">
            <v-list-tile-action v-if="child.icon">
              <v-icon>{{ child.icon }}</v-icon>
            </v-list-tile-action>
            <v-list-tile-content>
              <v-list-tile-title>
                {{ child.title }}
              </v-list-tile-title>
            </v-list-tile-content>
          </v-list-tile>
        </v-list-group>
        <v-list-tile v-else :key="item.text" @click="" :to="item.route">
          <v-list-tile-action>
            <v-icon>{{ item.icon }}</v-icon>
          </v-list-tile-action>
          <v-list-tile-content>
            <v-list-tile-title>
              {{ item.title }}
            </v-list-tile-title>

          </v-list-tile-content>
        </v-list-tile>
        <v-divider v-if="item.endDivider" :key="item.header"></v-divider>
      </template>
    </v-list>
  </v-navigation-drawer>
</template>

<script>
export default {
    data: () => ({
      dialog: false,
      drawer: null,
      items: [
        { icon: 'dashboard', title: 'Dashboard', route: '/dashboard' },
        { icon: 'keyboard_arrow_up',
          'icon-alt': 'keyboard_arrow_down',
          title: 'Registrants',
          model: true,
          children: [
            { icon: 'edit', title: 'Manage Registrants', route: '/manageregistrants' },
            {icon: 'access_time', title: 'Pending Applications', route: '/pendingApplication'},
            {icon: 'date_range', title: '6 Month Updates', route: '/6MonthUpdates'}
          ]
        },
        { icon: 'keyboard_arrow_up',
          'icon-alt': 'keyboard_arrow_down',
          title: 'Reporting',
          model: true,
          children: [
            { icon: 'timeline', title: 'Quick Reports', route: '/quickReports'},
            {icon: 'insert_drive_file', title: 'Shapefile', route: '/ShapeFile'},
            {icon: 'insert_chart_outlined', title: 'Interactive Reports', route: '/interactiveReports'}
          ]},
        {icon: 'help_outline', title: 'Help', route: '/help', divider: true},
        { icon: 'assignment_ind', title: 'Client Management', route: '/clientManagement' },
        { icon: 'assignment', title: 'Administration', route: '/administration' },
        { icon: 'supervised_user_circle', title: 'User Accounts', route: '/userAccount' },
        { icon: 'settings', title: 'WebsiteManagement', route: '/websiteManagement', endDivider: true},
      ]
    }),
    props: {
      source: String
    }
}
</script>

<style scoped>
  .customChild {
    border-left: 15px solid rgba(255,255,255,0.3);
  }
</style>

