<!-- child component showing clicked intern card with more detail -->

<template>
  <!-- Titel of matched interns in Lumory Container -->
  <n-card content-style="display: flex; flex-direction: column; gap: 15px">
    <div>
      <n-space justify="space-between" align="center" style="flex-wrap: nowrap">
        <h3 class="card-title">{{ internship.function }}</h3>
        <n-button class="contact-info__button" secondary round @click="showModal = true">Contact info</n-button>
      </n-space>
      <p class="city-text">{{internship.streetAddress}}, {{ internship.city }}</p>
    </div>
    <n-space>
      <n-tag class="tag" v-for="skill in internship.skillsToLearnIntern.split(',')">{{ skill }}</n-tag>
    </n-space>
    <div class="card-content">
      <p class="internship__section-title">{{ internship.problem }}</p>
      <p>{{ questionnaire.problem[internship.problem].description}}</p>
      <br />
      <p> {{internship.problemDescription}}</p>
      <br />
      <div v-for="skill in internship.skillsIntern.split(',')">
        <p class="internship__section-title">{{ skill }}</p>
        <p> {{ questionnaire.skills[skill].description}}</p>
        <br />
      </div>
      <p> {{internship.skillsInternDescription}}</p>
      <br />
      <div v-for="sector in internship.sector.split(',')">
        <p class="internship__section-title">{{sector}}</p>
        <p> {{ questionnaire.sector[sector].description}}</p>
        <br />
      </div>
      <p> {{internship.sectorDescription}}</p>
      <br />
      <p class="internship__section-title">Vergoeding</p>
      <p> {{internship.money}}</p>
      <br />
      <p class="internship__section-title">Verantwoordelijkheden</p>
      <p> {{internship.responsability}}</p>
      <br />
      <p class="internship__section-title">Aantal uur per week</p>
      <p>{{internship.hours}}</p>
      <br />
    </div>
  </n-card>
  <n-modal
    :show="showModal"
    :on-esc="() => {this.showModal = false}"
    :on-mask-click="() => {this.showModal = false}"
    preset="card"
    style="width: 600px"
    title="Contact gegevens"
    :bordered="false"
    size="huge"
    role="dialog"
    aria-modal="true"
    :on-close="() => {this.showModal = false}"
  >
    <p>{{internship.contactPersonFirstName + ' ' + internship.contactPersonLastName}}</p>
    <p>{{internship.contactPersonEmail}}</p>
  </n-modal>
</template>

<script>
import {PersonSharp} from "@vicons/ionicons5";
import { ref } from 'vue'
import {NModal, NCard, NTag, NSpace, NButton} from "naive-ui";
import questionnaireData from '../assets/json/questionaire.json'

export default {
  components: {
    PersonSharp,
    NModal,
    NCard,
    NTag,
    NSpace,
    NButton
  },
  name: "DetailedCard",
  props: {
    internship: {}
  },
  setup: () => {
    return{
      questionnaire: questionnaireData,
      showModal: ref(false)
    }
}
}
</script>
<style scoped>
.contact-info__button {
  background-color: var(--color-primary);
}

.field-header__person-icon {
  height: 20px;
}

.card-title {
  font-size: 32px;
  font-weight: bolder;
  padding: 0;
  margin: 0;
  line-height: 1;
}

.description-text {
  font-size: 14px;
}

.city-text {
  color: grey;
  font-size: 14px;
  padding: 0;
  margin: 0;
}

.tag {
  color: grey;
}
.internship__section-title {
  font-weight: bold;
}

</style>
