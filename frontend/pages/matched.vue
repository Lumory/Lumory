<template>
    <Container class="input-container">
      <h1 style="font-size: 32px; font-weight:lighter">Gematchte stages</h1>
    </Container>
  <div class="underline" style="border-bottom: 1px solid #EFEFEF"/>
    <Container class="card-container">
      <n-scrollbar style="max-height: 700px; padding-right:15px" trigger="none">
        <MatchedCard v-for="(matchedresult, index) in matchedresults" style="border-radius: 3px; margin-bottom: 15px"
                     @click="cardClick(index)" :internship="matchedresult"/>
      </n-scrollbar>
      <n-scrollbar style="max-height: 700px; padding-right:15px" trigger="none">
        <ResultCard v-if="matchedresults" :internship="matchedresults[this.currentHighlightedInternship]"/>
      </n-scrollbar>
    </Container>
</template>
<script>
import Container from "../components/Container";
import {NList, NListItem, NThing, NTag, NScrollbar, NButton, NInput, NSpace} from "naive-ui";
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
      clicked: false,
      matchedresults: [],
      currentHighlightedInternship: 0
    }
  },

  mounted: function () {
    axios.get('http://localhost:3001/Company', {
      headers: {
        'accept': '/',
        'Access-Control-Allow-Origin': '<*>'
      }
    }).then(response => this.matchedresults = response.data)
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
  gap: 10px;
  margin-top: 25px;
}
</style>