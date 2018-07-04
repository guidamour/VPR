<template>
  <v-card>
    <v-card-title class="elevation-10">
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
      class="elevation-10"
      :loading="true"
    >
    <v-progress-circular slot="progress" indeterminate color="red"></v-progress-circular>
      <template slot="items" slot-scope="props">
        <td>{{ props.item.name }}</td>
        <td class="text-xs-right">{{ props.item.phone }}</td>
        <td class="text-xs-right">{{ props.item.email }}</td>
        <td class="text-xs-right">{{ props.item.streetAddress }}</td>
        <td class="text-xs-right">{{ props.item.city }}</td>
        <td class="text-xs-right">{{ props.item.postalCode }}</td>
        <td class="text-xs-right">{{ props.item.country }}</td>
      </template>
      <v-alert slot="no-results" :value="true" color="error" icon="warning">
        Your search for "{{ search }}" found no results.
      </v-alert>
    </v-data-table>
  </v-card>
</template>

<script>
export default {
    name: "customerdatatable",
    data()  {
        return {
                search : '',
                title: this.datatitle,
                //Change the right side to the correct array
                generalColumnNames: [
                    { text: "Name", value: "name" },
                    { text: "Phone", value: "phone"},
                    { text: "Email", value: "email"},
                    { text: "StreetAddress", value: "streetAddress"},
                    { text: "City", value: "city"},
                    { text: "PostalCode", value:"postalCode"},
                    { text: "Country", value: "country"}
                ],
                generalColumnData: []
        }
    },
    props:{
        datatitle: String
    },
    mounted() {
      this.$http.get('api/reports/customers')
        .then(data => { this.generalColumnData = data.data.value })
        .catch(error => { console.log(error) })
    }
}
</script>

