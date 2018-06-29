<template>
        <v-container grid-list-md text-xs-center>
        <v-layout row wrap>
            <v-flex xs12>
                <v-card>
                    <div id="Registrants">
                        <!-- Data will be added from vue.js -->
                        <registrantsdata datatitle="Registrants - 6 Months update"></registrantsdata>
                    </div>
                </v-card>
            </v-flex>
            
            <v-flex xs12>
                <div id="PendingApplication">
                    <!-- Data will be added from vue.js -->
                    <pendingapplication datatitle="Pending Application"></pendingapplication>
                </div>
            </v-flex>
            <v-flex xs12>
                <div id="customerdatatableid">
                    <!-- Data will be added from vue.js -->
                    <customersdatatable datatitle="Customers"></customersdatatable>
                </div>
            </v-flex>
        </v-layout>
    </v-container>
</template>

<script>
import pendingapplication from "./reports/pendingApplication.vue"
import customersdatatable from "./reports/customersdatatable.vue"
import registrantsdata from "./reports/registrants.vue"
export default {
    name: 'quickReports',
    components :{
        pendingapplication,
        customersdatatable,
        registrantsdata
    }
}
</script>

