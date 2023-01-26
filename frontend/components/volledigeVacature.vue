<!-- child component showing clicked intern card with more detail -->

<template>
  <n-space vertical>
    <n-card>
    <n-space class="card-title">Dit ga je leren tijdens je stage</n-space>
    </n-card>
    <n-card>
      <n-space class="card-title">
        {{stages.problem}}
      </n-space>
    </n-card>

    <n-card>
      <template #header>
        <n-space class="card-title">
          {{ stages.function }}
        </n-space>
        <n-space class="card-city">
          {{ stages.city }}, {{stages.streetAddress}}
        </n-space>
      </template>
      <n-space>
        <n-tag class="tag">Marketing</n-tag>
        <n-tag class="tag">Advertising</n-tag>
      </n-space>
      <template class="tutoring-container">
        <n-space>
          <person-sharp size="20" class="field-header__person-icon"/>
          <n-space class="tutoring">Gemiddelde begeleiding</n-space>
        </n-space>
      </template>
      <n-space style="font-weight: bolder">
        Volledige Vacaturetekst
      </n-space>
      <n-space class="description-text">
        {{stages.problemDescription }}
      </n-space>
    </n-card>
  </n-space>
</template>

<script>
import {PersonSharp} from "@vicons/ionicons5";
import {NCard, NTag, NSpace, useMessage} from "naive-ui";
import getService from "../services/InternshipService";
import internshipService from "../services/InternshipService";
export default {
  data() {
    return {
      message: useMessage(),
      stages: ''
    }
  },
  components: {
    PersonSharp,
    NCard,
    NTag,
    NSpace
  },
  mounted: async function () {
    const message = useMessage()
    const route = useRoute()
    await internshipService.getInternship(route.params.id).then(response => {
      this.stages = response
    }).catch(error => {
      if (error.response.status === 404) {
        message.error('Geen internetverbinding')
      } else {
        message.error('Neem contact op met Lumory')
      }
    })
  },

  name: "VolledigeVacature",
  matchedresults: [],
  props: {
    internship: {}
  },

}
</script>
<style scoped>
.field-header__person-icon {
  height: 20px;
}

.card-title {
  font-weight: 800;
  font-size: 32px;
  line-height: 1;
}

.description-text {
  font-size: 14px;
}

.card-city {
  color: grey;
  font-size: 14px;
}

.tag {
  color: grey;
}

.tutoring-container {
  display: flex;
  flex-direction: row;
  margin-top: 15px;
  margin-bottom: 15px;
}
</style>
