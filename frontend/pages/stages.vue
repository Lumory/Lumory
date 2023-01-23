<!-- main index for matched interns -->
<template>
  <n-message-provider>
    <!-- Titel of matched students in Lumory Container -->
    <Container class="input-container">
      <h1 class="title">Mijn stages</h1>
    </Container>
    <div class="underline"/>
    <!-- This Lumory Container contains and shows all matched interns -->
    <Container class="card-container" v-if="matchedinternresults.length">
      <n-scrollbar>
        <n-grid>

        </n-grid>
        <n-space class="scroll" trigger="none">
            <!-- V-for looping through card component, then shows it in an array on the left-hand side on index -->
          <a :href="`/s/${matchedintern.id}`"
             v-for="(matchedintern) in matchedinternresults"
          >
            <MatchedCardForCompany
                style="border-radius: 3px; margin-bottom: 15px"
                :intern="matchedintern"></MatchedCardForCompany>
          </a>
        </n-space>
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
import {NScrollbar, NCard, NSpace, useMessage, NGrid} from "naive-ui";
import {defineComponent, ref} from 'vue';

import MatchedCardForCompany from "../components/MatchedCardforCompany"
export default defineComponent({
  data() {
    return {
      message: useMessage(),
      clicked: false,
      matchedinternresults: '',
      currentHighlightedIntern: 0,
    }
  },
  components: {
    MatchedCardForCompany,
    NScrollbar,
    NCard,
    NSpace,
    NGrid
  },
  name: 'Stages',
  // intercepts axios request. Upon error, shows error message on index
  mounted: function () {
    // axios GET request. Error handling provided upon specific error.
    // Error handling is work in progress, but a working first iteration is implemented.
    axios.get('http://localhost:3001/User', {})
        .then(response =>
            this.matchedinternresults = response.data)
        .catch(error => {
          console.log(error)
          this.message.error(error.message)
        })
        .catch((val) => {
          console.log(val)
        })
  },
  methods: {
    cardClick(index) {
      this.currentHighlightedIntern = index
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

</style>
