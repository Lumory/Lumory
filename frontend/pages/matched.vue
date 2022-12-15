<template>
  <Container class="input-container">
    <h1 style="font-size: 34px">Gematchte stages</h1>
  </Container>
  <Container class="card-container">
    <n-scrollbar style="max-height: 500px" trigger="none">
      <n-list style=" margin-right: 25px" class="scrollable-cards">
        <n-list-item v-for="(matchedresult, index) in matchedresults" style=" box-shadow: 0px 2px 2px rgba(0, 0, 0, 0.25); border-radius: 3px; margin-bottom: 25px">
          <MatchedCard @click="cardClick(index)" :internship="matchedresult"/>
        </n-list-item>
      </n-list>
    </n-scrollbar>
    <n-scrollbar style="max-height: 500px" trigger="none">
      <ResultCard v-if="matchedresults" :internship="matchedresults[this.currentHighlightedInternship]">
        <h1>test</h1>
      </ResultCard>
    </n-scrollbar>
  </Container>
</template>
<script>
import Container from "../components/Container";
import {NList, NListItem, NThing, NTag, NSpace, NScrollbar, NButton, NInput} from "naive-ui";
import axios from "axios"

export default {
  components: {
    NList,
    NListItem,
    NThing,
    NTag,
    NSpace,
    NScrollbar,
    NButton,
    NInput
  },
  name: 'Matched',
  data() {
    return {
      myStyle: {
        backgroundColor: "#16a085"
      },
      matchedresults: [],
      currentHighlightedInternship: 0
    }
  },

  mounted: function () {
    axios.get('https://run.mocky.io/v3/7070ec6f-57eb-4834-81bd-e51f808c0d2c', {
      headers: {
        'accept': '/',
        'Access-Control-Allow-Origin': '<origin>'
      }
    }) .then(response => this.matchedresults = response.data)
  },
  methods: {
    cardClick(index) {
      this.currentHighlightedInternship = index
      console.log(this.matchedresults[this.currentHighlightedInternship])
    }
  }
  // fetchO
  //
  // nServer: true,
  // matchedresults: await axios.get(`https://run.mocky.io/v3/0ec0aef6-82bc-4ce3-b91f-a6cbed7a693d`, {
  //   headers: {
  //     //   'accept': '/',
  //     //   'Access-Control-Allow-Origin': 'http://localhost:3001/Company'
  //     // }
  //   }
  // })
  //     .then(results => console.log(results))
};
</script>
<style scoped>
.card-container {
  display: flex;
  flex-direction: row;
  gap: 50px;
  margin-top: 25px;
}
</style>