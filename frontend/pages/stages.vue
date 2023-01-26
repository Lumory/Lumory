<!-- main index for matched interns -->
<template>
  <n-message-provider>
    <!-- Titel of matched students in Lumory Container -->
    <Container class="input-container">
      <h1 class="title">Mijn stages</h1>
    </Container>
    <div class="underline"/>
    <!-- This Lumory Container contains and shows all matched interns -->
    <Container class="card-container" v-if="stages.length">
      <n-scrollbar>
        <n-space class="scroll" trigger="none">
            <!-- V-for looping through card component, then shows it in an array on the left-hand side on index -->
          <nuxt-link :to="`/s/${matchedintern.id}`"
             v-for="(matchedintern) in stages"
          >
            <MatchedCardForCompany
                style="border-radius: 3px;
                margin-bottom: 15px"
                :intern="matchedintern"
            />
          </nuxt-link>
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
import {NScrollbar, NCard, NSpace, useMessage, NGrid} from "naive-ui";
import {defineComponent, ref} from 'vue';
import getService from "../services/InternshipService"
import MatchedCardForCompany from "../components/MatchedCardforCompany"
import internshipService from "../services/InternshipService";
export default defineComponent({
  data() {
    return {
      message: useMessage(),
      clicked: false,
      stages: '',
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
    const message = useMessage()
    internshipService.getInternships().then(response => {
      this.stages = response
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
