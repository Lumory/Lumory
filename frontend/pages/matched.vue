<!-- main index for matched interns -->
<template>
  <!-- Titel of matched interns in Lumory Container -->
  <Container class="input-container">
    <n-space justify="space-between" align="end">
      <h1 class="title">Gematchte stages</h1>
    </n-space>
    <n-divider />
    <!-- This Lumory Container contains and shows all matched intern cards -->
    <n-grid :cols="2" x-gap="20" class="card-container" v-if="matchedresults.length">
      <n-grid-item>
        <n-scrollbar class="scroll" style="max-height: 700px; padding-right:15px" trigger="none">
          <n-space vertical y-gap="20">
            <!-- V-for looping through card component, then shows it in an array on the left-hand side on index -->
            <MatchedCardForCompany v-for="(matchedresult, index) in matchedresults" style="border-radius: 3px; margin-bottom: 15px"
                         @click="cardClick(index)" :intern="matchedresult"/>
          </n-space>
        </n-scrollbar>
      </n-grid-item>
      <n-grid-item>
        <n-scrollbar style="max-height: 700px; padding-right:15px" trigger="none">
          <!-- On-click result; shows more detail about selected/clicked internship -->
          <DetailedCard :internship="matchedresults[this.currentHighlightedInternship]"/>
        </n-scrollbar>
      </n-grid-item>
    </n-grid>
    <n-card class="card-container" v-else>
      Bezig met laden...
    </n-card>
  </Container>
</template>

<script lang="ts">
import {NScrollbar, NCard, NSpace, NGrid, NGridItem, NDivider, useMessage} from "naive-ui";
import { defineComponent, ref } from 'vue';
import internshipService from "../services/InternshipService";
import MatchedCardForCompany from "~/components/MatchedCardforCompany.vue";
const message = useMessage();

definePageMeta({
	middleware: "check-auth"
})

export default defineComponent({
  data() {
    return {
      message: useMessage(),
      clicked: false,
      matchedresults: '',
      currentHighlightedInternship: 0,
    }
  },
  components: {
    MatchedCardForCompany,
    NScrollbar,
    NCard,
    NSpace,
    NGrid,
    NGridItem,
    NDivider
  },
  name: 'Matched',
  // intercepts axios request. Upon error, shows error message on index
  mounted: function () {
    const message = useMessage()
    internshipService.getInternships().then(response => {
      this.matchedresults = response
    }).catch(error => {
      if (error.response.status === 404) {
        message.error('Geen internetverbinding')
      } else {
        message.error('Neem contact op met Lumory')
      }
    })
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
  font-weight: normal;
  padding-bottom: 0;
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
