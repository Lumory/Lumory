<template>
  <n-message-provider>
    <Container class="input-container">
      <h1 class="title">Gematchte stages</h1>
    </Container>
    <div class="underline"/>
    <Container class="card-container" v-if="matchedresults.length">
      <n-scrollbar class="scroll" style="max-height: 700px; padding-right:15px" trigger="none">
        <n-space vertical>
          <MatchedCard v-for="(matchedresult, index) in matchedresults" style="border-radius: 3px; margin-bottom: 15px"
                       @click="cardClick(index)" :internship="matchedresult"/>
        </n-space>
      </n-scrollbar>
      <n-scrollbar style="max-height: 700px; padding-right:15px" trigger="none">
        <DetailedCard :internship="matchedresults[this.currentHighlightedInternship]"/>
      </n-scrollbar>
    </Container>
    <n-card class="card-container" v-else>
      <template #header>
        <n-space vertical>
          Bezig met laden...
        </n-space>
      </template>
    </n-card>
  </n-message-provider>
</template>
<script lang="ts">
import axios from 'axios';
import {NScrollbar, NCard, NSpace, useMessage} from "naive-ui";
import { defineComponent, ref } from 'vue';
export default defineComponent({
  data() {
    return {
      clicked: false,
      matchedresults: '',
      currentHighlightedInternship: 0,
    }
  },
  components: {
    NScrollbar,
    NCard,
    NSpace,
  },
  name: 'Matched',
  mounted: function () {
    axios.interceptors.response.use(undefined, (error => {
      if (error.message === 'Network Error' && !error.response) {
        alert('Er is een fout opgetreden. Herlaad deze pagina.')
      }
    }))
    axios.get('http://localhost:3001/Internships', {})
        .then(response =>
            this.matchedresults = response.data)
        .catch(error => {
          if (error.response) {
            // The request was made but no response was received
            // `error.request` is an instance of XMLHttpRequest in the browser and an instance of
            // http.ClientRequest in node.js
            console.log(error.request);
          } else {
            // Something happened in setting up the request that triggered an Error
            console.log('Error', error.message);
          }
          console.log(error.config);
        });
  },
  methods: {
    cardClick(index) {
      this.currentHighlightedInternship = index
    }
  },
});
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
