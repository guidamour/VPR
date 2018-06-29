<template>
  <v-card  >
    <v-card-title>
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
    <v-progress-linear slot="progress" color="blue lighten-2" indeterminate></v-progress-linear>
      <template slot="items" slot-scope="props">
        <td>{{ props.item.Name }}</td>
        <td class="text-xs-right">{{ props.item.Date }}</td>
        <td class="text-xs-right">{{ props.item.Text }}</td>
        <td class="text-xs-right">{{ props.item.State }}</td>
      </template>
      <v-alert slot="no-results" :value="true" color="blue lighten-2" icon="warning">
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
                    {text:"Text", value: "Text"},
                    {text:"State", value: "State"}
                ],
                generalColumnData: [
                    {
                        Name: "Greg Rakozy",
                        Date: "12-Jan-2018",
                        Text: "Lorem ipsum dolor sit amet, aliquam fabulas denique",
                        State: "Active"
                    },
                    {
                        Name: "Paula Diorza",
                        Date: "15-Dec-2016",
                        Text: "Ad homero efficiantur usu, ut sed essent maiorum.",
                        State: "Active"
                    },
                    {
                        Name: "Jeffery D'Amidio",
                        Date: "23-Nov-2017",
                        Text: "In sea porro temporibus.",
                        State: "Active"
                    },
                    {
                        Name: "Lawrence Dorence",
                        Date: "1-Apr-2017",
                        Text: "Id vix saepe impetus ceteros, te simul essent rationibus sed, facilis voluptua qui id.",
                        State: "Active"
                    },
                    {
                        Name: "Daniel Nog",
                        Date: "3-Feb-2017",
                        Text: "Cu vis dicit nominavi pericula, his urbanitas scripserit ad, te cum possit interesset referrentur.",
                        State: "Active"
                    },
                    {
                        Name: "Greg Rakozy",
                        Date: "12-Jan-2018",
                        Text: "Lorem ipsum dolor sit amet, aliquam fabulas denique",
                        State: "Active"
                    },
                    {
                        Name: "Paula Diorza",
                        Date: "15-Dec-2016",
                        Text: "Ad homero efficiantur usu, ut sed essent maiorum.",
                        State: "Active"
                    },
                    {
                        Name: "Jeffery D'Amidio",
                        Date: "23-Nov-2017",
                        Text: "In sea porro temporibus.",
                        State: "Active"
                    },
                    {
                        Name: "Lawrence Dorence",
                        Date: "1-Apr-2017",
                        Text: "Id vix saepe impetus ceteros, te simul essent rationibus sed, facilis voluptua qui id.",
                        State: "Active"
                    },
                    {
                        Name: "Daniel Nog",
                        Date: "3-Feb-2017",
                        Text: "Cu vis dicit nominavi pericula, his urbanitas scripserit ad, te cum possit interesset referrentur.",
                        State: "Active"
                    },
                    {
                        Name: "Greg Rakozy",
                        Date: "12-Jan-2018",
                        Text: "Lorem ipsum dolor sit amet, aliquam fabulas denique",
                        State: "Active"
                    },
                    {
                        Name: "Paula Diorza",
                        Date: "15-Dec-2016",
                        Text: "Ad homero efficiantur usu, ut sed essent maiorum.",
                        State: "Active"
                    },
                    {
                        Name: "Jeffery D'Amidio",
                        Date: "23-Nov-2017",
                        Text: "In sea porro temporibus.",
                        State: "Active"
                    },
                    {
                        Name: "Lawrence Dorence",
                        Date: "1-Apr-2017",
                        Text: "Id vix saepe impetus ceteros, te simul essent rationibus sed, facilis voluptua qui id.",
                        State: "Active"
                    },
                    {
                        Name: "Daniel Nog",
                        Date: "3-Feb-2017",
                        Text: "Cu vis dicit nominavi pericula, his urbanitas scripserit ad, te cum possit interesset referrentur.",
                        State: "Active"
                    },
                    {
                        Name: "Greg Rakozy",
                        Date: "12-Jan-2018",
                        Text: "Lorem ipsum dolor sit amet, aliquam fabulas denique",
                        State: "Active"
                    },
                    {
                        Name: "Paula Diorza",
                        Date: "15-Dec-2016",
                        Text: "Ad homero efficiantur usu, ut sed essent maiorum.",
                        State: "Active"
                    },
                    {
                        Name: "Jeffery D'Amidio",
                        Date: "23-Nov-2017",
                        Text: "In sea porro temporibus.",
                        State: "Active"
                    },
                    {
                        Name: "Lawrence Dorence",
                        Date: "1-Apr-2017",
                        Text: "Id vix saepe impetus ceteros, te simul essent rationibus sed, facilis voluptua qui id.",
                        State: "Active"
                    },
                    {
                        Name: "Daniel Nog",
                        Date: "3-Feb-2017",
                        Text: "Cu vis dicit nominavi pericula, his urbanitas scripserit ad, te cum possit interesset referrentur.",
                        State: "Active"
                    },
                    {
                        Name: "Greg Rakozy",
                        Date: "12-Jan-2018",
                        Text: "Lorem ipsum dolor sit amet, aliquam fabulas denique",
                        State: "Active"
                    },
                    {
                        Name: "Paula Diorza",
                        Date: "15-Dec-2016",
                        Text: "Ad homero efficiantur usu, ut sed essent maiorum.",
                        State: "Active"
                    },
                    {
                        Name: "Jeffery D'Amidio",
                        Date: "23-Nov-2017",
                        Text: "In sea porro temporibus.",
                        State: "Active"
                    },
                    {
                        Name: "Lawrence Dorence",
                        Date: "1-Apr-2017",
                        Text: "Id vix saepe impetus ceteros, te simul essent rationibus sed, facilis voluptua qui id.",
                        State: "Active"
                    },
                    {
                        Name: "Daniel Nog",
                        Date: "3-Feb-2017",
                        Text: "Cu vis dicit nominavi pericula, his urbanitas scripserit ad, te cum possit interesset referrentur.",
                        State: "Active"
                    },
                    {
                        Name: "Greg Rakozy",
                        Date: "12-Jan-2018",
                        Text: "Lorem ipsum dolor sit amet, aliquam fabulas denique",
                        State: "Active"
                    },
                    {
                        Name: "Paula Diorza",
                        Date: "15-Dec-2016",
                        Text: "Ad homero efficiantur usu, ut sed essent maiorum.",
                        State: "Active"
                    },
                    {
                        Name: "Jeffery D'Amidio",
                        Date: "23-Nov-2017",
                        Text: "In sea porro temporibus.",
                        State: "Active"
                    },
                    {
                        Name: "Lawrence Dorence",
                        Date: "1-Apr-2017",
                        Text: "Id vix saepe impetus ceteros, te simul essent rationibus sed, facilis voluptua qui id.",
                        State: "Active"
                    },
                    {
                        Name: "Daniel Nog",
                        Date: "3-Feb-2017",
                        Text: "Cu vis dicit nominavi pericula, his urbanitas scripserit ad, te cum possit interesset referrentur.",
                        State: "Active"
                    },
                    {
                        Name: "Greg Rakozy",
                        Date: "12-Jan-2018",
                        Text: "Lorem ipsum dolor sit amet, aliquam fabulas denique",
                        State: "Active"
                    },
                    {
                        Name: "Paula Diorza",
                        Date: "15-Dec-2016",
                        Text: "Ad homero efficiantur usu, ut sed essent maiorum.",
                        State: "Active"
                    },
                    {
                        Name: "Jeffery D'Amidio",
                        Date: "23-Nov-2017",
                        Text: "In sea porro temporibus.",
                        State: "Active"
                    },
                    {
                        Name: "Lawrence Dorence",
                        Date: "1-Apr-2017",
                        Text: "Id vix saepe impetus ceteros, te simul essent rationibus sed, facilis voluptua qui id.",
                        State: "Active"
                    },
                    {
                        Name: "Daniel Nog",
                        Date: "3-Feb-2017",
                        Text: "Cu vis dicit nominavi pericula, his urbanitas scripserit ad, te cum possit interesset referrentur.",
                        State: "Active"
                    },
                    {
                        Name: "Greg Rakozy",
                        Date: "12-Jan-2018",
                        Text: "Lorem ipsum dolor sit amet, aliquam fabulas denique",
                        State: "Active"
                    },
                    {
                        Name: "Paula Diorza",
                        Date: "15-Dec-2016",
                        Text: "Ad homero efficiantur usu, ut sed essent maiorum.",
                        State: "Active"
                    },
                    {
                        Name: "Jeffery D'Amidio",
                        Date: "23-Nov-2017",
                        Text: "In sea porro temporibus.",
                        State: "Active"
                    },
                    {
                        Name: "Lawrence Dorence",
                        Date: "1-Apr-2017",
                        Text: "Id vix saepe impetus ceteros, te simul essent rationibus sed, facilis voluptua qui id.",
                        State: "Active"
                    },
                    {
                        Name: "Daniel Nog",
                        Date: "3-Feb-2017",
                        Text: "Cu vis dicit nominavi pericula, his urbanitas scripserit ad, te cum possit interesset referrentur.",
                        State: "Active"
                    },
                    {
                        Name: "Greg Rakozy",
                        Date: "12-Jan-2018",
                        Text: "Lorem ipsum dolor sit amet, aliquam fabulas denique",
                        State: "Active"
                    },
                    {
                        Name: "Paula Diorza",
                        Date: "15-Dec-2016",
                        Text: "Ad homero efficiantur usu, ut sed essent maiorum.",
                        State: "Active"
                    },
                    {
                        Name: "Jeffery D'Amidio",
                        Date: "23-Nov-2017",
                        Text: "In sea porro temporibus.",
                        State: "Active"
                    },
                    {
                        Name: "Lawrence Dorence",
                        Date: "1-Apr-2017",
                        Text: "Id vix saepe impetus ceteros, te simul essent rationibus sed, facilis voluptua qui id.",
                        State: "Active"
                    },
                    {
                        Name: "Daniel Nog",
                        Date: "3-Feb-2017",
                        Text: "Cu vis dicit nominavi pericula, his urbanitas scripserit ad, te cum possit interesset referrentur.",
                        State: "Active"
                    },
                    {
                        Name: "Greg Rakozy",
                        Date: "12-Jan-2018",
                        Text: "Lorem ipsum dolor sit amet, aliquam fabulas denique",
                        State: "Active"
                    },
                    {
                        Name: "Paula Diorza",
                        Date: "15-Dec-2016",
                        Text: "Ad homero efficiantur usu, ut sed essent maiorum.",
                        State: "Active"
                    },
                    {
                        Name: "Jeffery D'Amidio",
                        Date: "23-Nov-2017",
                        Text: "In sea porro temporibus.",
                        State: "Active"
                    },
                    {
                        Name: "Lawrence Dorence",
                        Date: "1-Apr-2017",
                        Text: "Id vix saepe impetus ceteros, te simul essent rationibus sed, facilis voluptua qui id.",
                        State: "Active"
                    },
                    {
                        Name: "Daniel Nog",
                        Date: "3-Feb-2017",
                        Text: "Cu vis dicit nominavi pericula, his urbanitas scripserit ad, te cum possit interesset referrentur.",
                        State: "Active"
                    },
                    {
                        Name: "Greg Rakozy",
                        Date: "12-Jan-2018",
                        Text: "Lorem ipsum dolor sit amet, aliquam fabulas denique",
                        State: "Active"
                    },
                    {
                        Name: "Paula Diorza",
                        Date: "15-Dec-2016",
                        Text: "Ad homero efficiantur usu, ut sed essent maiorum.",
                        State: "Active"
                    },
                    {
                        Name: "Jeffery D'Amidio",
                        Date: "23-Nov-2017",
                        Text: "In sea porro temporibus.",
                        State: "Active"
                    },
                    {
                        Name: "Lawrence Dorence",
                        Date: "1-Apr-2017",
                        Text: "Id vix saepe impetus ceteros, te simul essent rationibus sed, facilis voluptua qui id.",
                        State: "Active"
                    },
                    {
                        Name: "Daniel Nog",
                        Date: "3-Feb-2017",
                        Text: "Cu vis dicit nominavi pericula, his urbanitas scripserit ad, te cum possit interesset referrentur.",
                        State: "Active"
                    },
                    {
                        Name: "Greg Rakozy",
                        Date: "12-Jan-2018",
                        Text: "Lorem ipsum dolor sit amet, aliquam fabulas denique",
                        State: "Active"
                    },
                    {
                        Name: "Paula Diorza",
                        Date: "15-Dec-2016",
                        Text: "Ad homero efficiantur usu, ut sed essent maiorum.",
                        State: "Active"
                    },
                    {
                        Name: "Jeffery D'Amidio",
                        Date: "23-Nov-2017",
                        Text: "In sea porro temporibus.",
                        State: "Active"
                    },
                    {
                        Name: "Lawrence Dorence",
                        Date: "1-Apr-2017",
                        Text: "Id vix saepe impetus ceteros, te simul essent rationibus sed, facilis voluptua qui id.",
                        State: "Active"
                    },
                    {
                        Name: "Daniel Nog",
                        Date: "3-Feb-2017",
                        Text: "Cu vis dicit nominavi pericula, his urbanitas scripserit ad, te cum possit interesset referrentur.",
                        State: "Active"
                    },
                    {
                        Name: "Greg Rakozy",
                        Date: "12-Jan-2018",
                        Text: "Lorem ipsum dolor sit amet, aliquam fabulas denique",
                        State: "Active"
                    },
                    {
                        Name: "Paula Diorza",
                        Date: "15-Dec-2016",
                        Text: "Ad homero efficiantur usu, ut sed essent maiorum.",
                        State: "Active"
                    },
                    {
                        Name: "Jeffery D'Amidio",
                        Date: "23-Nov-2017",
                        Text: "In sea porro temporibus.",
                        State: "Active"
                    },
                    {
                        Name: "Lawrence Dorence",
                        Date: "1-Apr-2017",
                        Text: "Id vix saepe impetus ceteros, te simul essent rationibus sed, facilis voluptua qui id.",
                        State: "Active"
                    },
                    {
                        Name: "Daniel Nog",
                        Date: "3-Feb-2017",
                        Text: "Cu vis dicit nominavi pericula, his urbanitas scripserit ad, te cum possit interesset referrentur.",
                        State: "Active"
                    },
                    {
                        Name: "Greg Rakozy",
                        Date: "12-Jan-2018",
                        Text: "Lorem ipsum dolor sit amet, aliquam fabulas denique",
                        State: "Active"
                    },
                    {
                        Name: "Paula Diorza",
                        Date: "15-Dec-2016",
                        Text: "Ad homero efficiantur usu, ut sed essent maiorum.",
                        State: "Active"
                    },
                    {
                        Name: "Jeffery D'Amidio",
                        Date: "23-Nov-2017",
                        Text: "In sea porro temporibus.",
                        State: "Active"
                    },
                    {
                        Name: "Lawrence Dorence",
                        Date: "1-Apr-2017",
                        Text: "Id vix saepe impetus ceteros, te simul essent rationibus sed, facilis voluptua qui id.",
                        State: "Active"
                    },
                    {
                        Name: "Daniel Nog",
                        Date: "3-Feb-2017",
                        Text: "Cu vis dicit nominavi pericula, his urbanitas scripserit ad, te cum possit interesset referrentur.",
                        State: "Active"
                    },
                    {
                        Name: "Greg Rakozy",
                        Date: "12-Jan-2018",
                        Text: "Lorem ipsum dolor sit amet, aliquam fabulas denique",
                        State: "Active"
                    },
                    {
                        Name: "Paula Diorza",
                        Date: "15-Dec-2016",
                        Text: "Ad homero efficiantur usu, ut sed essent maiorum.",
                        State: "Active"
                    },
                    {
                        Name: "Jeffery D'Amidio",
                        Date: "23-Nov-2017",
                        Text: "In sea porro temporibus.",
                        State: "Active"
                    },
                    {
                        Name: "Lawrence Dorence",
                        Date: "1-Apr-2017",
                        Text: "Id vix saepe impetus ceteros, te simul essent rationibus sed, facilis voluptua qui id.",
                        State: "Active"
                    },
                    {
                        Name: "Daniel Nog",
                        Date: "3-Feb-2017",
                        Text: "Cu vis dicit nominavi pericula, his urbanitas scripserit ad, te cum possit interesset referrentur.",
                        State: "Active"
                    },
                    {
                        Name: "Greg Rakozy",
                        Date: "12-Jan-2018",
                        Text: "Lorem ipsum dolor sit amet, aliquam fabulas denique",
                        State: "Active"
                    },
                    {
                        Name: "Paula Diorza",
                        Date: "15-Dec-2016",
                        Text: "Ad homero efficiantur usu, ut sed essent maiorum.",
                        State: "Active"
                    },
                    {
                        Name: "Jeffery D'Amidio",
                        Date: "23-Nov-2017",
                        Text: "In sea porro temporibus.",
                        State: "Active"
                    },
                    {
                        Name: "Lawrence Dorence",
                        Date: "1-Apr-2017",
                        Text: "Id vix saepe impetus ceteros, te simul essent rationibus sed, facilis voluptua qui id.",
                        State: "Active"
                    },
                    {
                        Name: "Daniel Nog",
                        Date: "3-Feb-2017",
                        Text: "Cu vis dicit nominavi pericula, his urbanitas scripserit ad, te cum possit interesset referrentur.",
                        State: "Active"
                    },
                    {
                        Name: "Greg Rakozy",
                        Date: "12-Jan-2018",
                        Text: "Lorem ipsum dolor sit amet, aliquam fabulas denique",
                        State: "Active"
                    },
                    {
                        Name: "Paula Diorza",
                        Date: "15-Dec-2016",
                        Text: "Ad homero efficiantur usu, ut sed essent maiorum.",
                        State: "Active"
                    },
                    {
                        Name: "Jeffery D'Amidio",
                        Date: "23-Nov-2017",
                        Text: "In sea porro temporibus.",
                        State: "Active"
                    },
                    {
                        Name: "Lawrence Dorence",
                        Date: "1-Apr-2017",
                        Text: "Id vix saepe impetus ceteros, te simul essent rationibus sed, facilis voluptua qui id.",
                        State: "Active"
                    },
                    {
                        Name: "Daniel Nog",
                        Date: "3-Feb-2017",
                        Text: "Cu vis dicit nominavi pericula, his urbanitas scripserit ad, te cum possit interesset referrentur.",
                        State: "Active"
                    },
                    {
                        Name: "Greg Rakozy",
                        Date: "12-Jan-2018",
                        Text: "Lorem ipsum dolor sit amet, aliquam fabulas denique",
                        State: "Active"
                    },
                    {
                        Name: "Paula Diorza",
                        Date: "15-Dec-2016",
                        Text: "Ad homero efficiantur usu, ut sed essent maiorum.",
                        State: "Active"
                    },
                    {
                        Name: "Jeffery D'Amidio",
                        Date: "23-Nov-2017",
                        Text: "In sea porro temporibus.",
                        State: "Active"
                    },
                    {
                        Name: "Lawrence Dorence",
                        Date: "1-Apr-2017",
                        Text: "Id vix saepe impetus ceteros, te simul essent rationibus sed, facilis voluptua qui id.",
                        State: "Active"
                    },
                    {
                        Name: "Daniel Nog",
                        Date: "3-Feb-2017",
                        Text: "Cu vis dicit nominavi pericula, his urbanitas scripserit ad, te cum possit interesset referrentur.",
                        State: "Active"
                    },
                    {
                        Name: "Greg Rakozy",
                        Date: "12-Jan-2018",
                        Text: "Lorem ipsum dolor sit amet, aliquam fabulas denique",
                        State: "Active"
                    },
                    {
                        Name: "Paula Diorza",
                        Date: "15-Dec-2016",
                        Text: "Ad homero efficiantur usu, ut sed essent maiorum.",
                        State: "Active"
                    },
                    {
                        Name: "Jeffery D'Amidio",
                        Date: "23-Nov-2017",
                        Text: "In sea porro temporibus.",
                        State: "Active"
                    },
                    {
                        Name: "Lawrence Dorence",
                        Date: "1-Apr-2017",
                        Text: "Id vix saepe impetus ceteros, te simul essent rationibus sed, facilis voluptua qui id.",
                        State: "Active"
                    },
                    {
                        Name: "Daniel Nog",
                        Date: "3-Feb-2017",
                        Text: "Cu vis dicit nominavi pericula, his urbanitas scripserit ad, te cum possit interesset referrentur.",
                        State: "Active"
                    },
                    {
                        Name: "Greg Rakozy",
                        Date: "12-Jan-2018",
                        Text: "Lorem ipsum dolor sit amet, aliquam fabulas denique",
                        State: "Active"
                    },
                    {
                        Name: "Paula Diorza",
                        Date: "15-Dec-2016",
                        Text: "Ad homero efficiantur usu, ut sed essent maiorum.",
                        State: "Active"
                    },
                    {
                        Name: "Jeffery D'Amidio",
                        Date: "23-Nov-2017",
                        Text: "In sea porro temporibus.",
                        State: "Active"
                    },
                    {
                        Name: "Lawrence Dorence",
                        Date: "1-Apr-2017",
                        Text: "Id vix saepe impetus ceteros, te simul essent rationibus sed, facilis voluptua qui id.",
                        State: "Active"
                    },
                    {
                        Name: "Daniel Nog",
                        Date: "3-Feb-2017",
                        Text: "Cu vis dicit nominavi pericula, his urbanitas scripserit ad, te cum possit interesset referrentur.",
                        State: "Active"
                    }
                ]
            }
        }, props:{
            datatitle: String
        }
}
</script>
