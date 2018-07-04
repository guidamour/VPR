<template>
  <v-card color="red">
    <v-card-title class="elevation-10" >
      {{ title }}
      <v-spacer></v-spacer>
      <v-text-field
        v-model="search"
        append-icon="search"
        label="Search"
        single-line
        hide-details
      ></v-text-field>
    </v-card-title>
    <v-data-table
      :headers="generalColumnNames"
      :items="generalColumnData"
      :search="search"
      :loading="true"
      class="elevation-10"
    >
      <v-progress-linear slot="progress" color="red" indeterminate></v-progress-linear>
      <template slot="items" slot-scope="props">
        <td>{{ props.item.name }}</td>
        <td class="text-xs-right">{{ props.item.date }}</td>
        <td class="text-xs-right">{{ props.item.address }}</td>
        <td class="text-xs-right">{{ props.item.method }}</td>
      </template>
      <v-alert slot="no-results" :value="true" color="error" icon="warning">
        Your search for "{{ search }}" found no results.
      </v-alert>
    </v-data-table>
  </v-card>
</template>

<script>
export default {
    data() {
            return {
                search: '',
                title: this.datatitle,
                //Change the right side to the correct array
                generalColumnNames: [
                    {text:"Name", value:"name"},
                    {text:"Date", value:"date"}, 
                    {text:"Address", value:"address"},
                    {text:"Method", value:"method"}
                ],
                generalColumnData: []
            }
        }, props:{
            datatitle: String
        },
        mounted() {
          this.$http.get('api/reports/pendingapplications')
            .then(data => { this.generalColumnData = data.data.value })
            .catch(error => { console.log(error) })
        }
}
</script>

