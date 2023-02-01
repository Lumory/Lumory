<!-- main index for matched interns -->
<template>
    <!-- Titel of matched students in Lumory Container -->
  <Container>
    <n-space justify="space-between" align="end">
      <h1 class="title">Mijn stages</h1>
      <nuxt-link to="/stage-aanmaken">
        <n-button class="create-internship__button" secondary round>Stage aanmaken</n-button>
      </nuxt-link>
    </n-space>
    <n-divider />
    <!-- This Lumory Container contains and shows all matched interns -->
    <n-grid class="card-container" v-if="stages.length" :cols="3" x-gap="20" y-gap="20">
      <n-grid-item v-for="(matchedintern) in stages">
        <nuxt-link :to="`/s/${matchedintern.id}`">
          <MatchedCardForCompany style="border-radius: 3px; margin-bottom: 15px" :intern="matchedintern" />
        </nuxt-link>
      </n-grid-item>
    </n-grid>
    <n-card class="card-container" v-else>
      Bezig met laden...
    </n-card>
  </Container>
</template>

<script lang="ts">
import {NScrollbar, NCard, NSpace, useMessage, NGrid, NGridItem, NDivider, NButton} from "naive-ui";
import {defineComponent, ref} from 'vue';
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
    NGrid,
    NGridItem,
    NDivider,
    NButton
  },
  name: 'Stages',
  // intercepts axios request. Upon error, shows error message on index
  mounted: function () {
    const message = useMessage()
    internshipService.getCompanyInternships(getCookieValue('company').id).then(response => {
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
  font-weight: normal;
  padding-bottom: 0;
}
.create-internship__button{
  background-color: var(--color-primary);
  border: none;
}

</style>
