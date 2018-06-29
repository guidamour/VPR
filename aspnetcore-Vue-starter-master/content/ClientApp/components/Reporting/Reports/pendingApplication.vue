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
        <td>{{ props.item.Name }}</td>
        <td class="text-xs-right">{{ props.item.Date }}</td>
        <td class="text-xs-right">{{ props.item.Address }}</td>
        <td class="text-xs-right">{{ props.item.Method }}</td>
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
                    {text:"Name", value:"Name"},
                    {text:"Date", value:"Date"}, 
                    {text:"Address", value:"Address"},
                    {text:"Method", value:"Method"}
                ],
                generalColumnData: [
                    {
                        Name: "Derek Jones",
                        Date: "11-Jun-2018",
                        Address: "45 Chambers Avenue, SSM",
                        Method: "In-Person"
                    },
                    {
                        Name: "Jeff Munchin",
                        Date: "25-Apr-2018",
                        Address: "2335 Queen Street E., SSM",
                        Method: "Paper"
                    },
                    {
                        Name: "Alfred Jimps",
                        Date: "23-Nov-2018",
                        Address: "1415 Queen Street W., SSM",
                        Method: "Online"
                    },
                    {
                        Name: "DeeDee Florence",
                        Date: "1-Apr-2017",
                        Address: "154 Third Ave, SSM",
                        Method: "Online"
                    },
                    {
                        Name: "Nester Hollingsworth",
                        Date: "3-Feb-2018",
                        Address: "1454 Second Line W., SSM",
                        Method: "Manual"
                    }
                ]
            }
        }, props:{
            datatitle: String
        }
}
</script>

