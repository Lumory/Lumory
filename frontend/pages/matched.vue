<template>
  <Container class="input-container">
    <h1 class="title">Gematchte stages</h1>
  </Container>
  <div class="underline"/>
  <Container class="card-container">
    <n-scrollbar class="scroll" style="max-height: 700px; padding-right:15px" trigger="none">
      <MatchedCard v-for="(matchedresult, index) in matchedresults" style="border-radius: 3px; margin-bottom: 15px"
                   @click="cardClick(index)" :internship="matchedresult"/>
    </n-scrollbar>
    <n-scrollbar style="max-height: 700px; padding-right:15px" trigger="none">
      <DetailedCard v-if="matchedresults" :internship="matchedresults[this.currentHighlightedInternship]"/>
    </n-scrollbar>
  </Container>
</template>
<script>
import {NScrollbar} from "naive-ui";
import axios from "axios"

export default {
  components: {
    NScrollbar,
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
    axios.get('http://localhost:3001/Company', {}).then(response => this.matchedresults = response.data)
  },
  methods: {
    cardClick(index) {
      this.currentHighlightedInternship = index
    }
  }
};
</script>
<style scoped>
.title {
  font-size: 32px;
  font-weight: lighter;
}

.underline {
  border-bottom: 1px solid #EFEFEF;
}

.card-container {
  display: flex;
  flex-direction: row;
  gap: 10px;
  margin-top: 25px;
}
</style>