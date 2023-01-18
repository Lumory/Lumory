<!-- main index for matched interns -->

<template>
  <n-message-provider>
    <!-- Titel of matched interns in Lumory Container -->
    <Container class="input-container">
      <h1 class="title">Gematchte stages</h1>
    </Container>
    <div class="underline"/>
    <!-- This Lumory Container contains and shows all matched intern cards -->
    <Container class="card-container" v-if="matchedresults.length">
      <n-scrollbar class="scroll" style="max-height: 700px; padding-right:15px" trigger="none">
        <n-space vertical>
          <!-- V-for looping through card component, then shows it in an array on the left-hand side on index -->
          <MatchedCard v-for="(matchedresult, index) in matchedresults" style="border-radius: 3px; margin-bottom: 15px"
                       @click="cardClick(index)" :internship="matchedresult"/>
        </n-space>
      </n-scrollbar>
      <n-scrollbar style="max-height: 700px; padding-right:15px" trigger="none">
        <!-- On-click result; shows more detail about selected/clicked internship -->
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
import {defineComponent, ref} from 'vue';
import getService from "../services/InternshipService";

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
  // intercepts axios request. Upon error, shows error message on index
  mounted: function () {
    getService.getInternships().then(response => {
      this.matchedresults = response.data
    })
    axios.interceptors.response.use(undefined, (error => {
      if (error.message === 'Network Error' && !error.response) {
        alert('Er is een fout opgetreden. Herlaad deze pagina.')
      }
    }))
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
