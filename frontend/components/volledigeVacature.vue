<template>
  <div class="page-grid__main-content page-grid__col-span-2">
    <StudentProfilePreferenceHeader class="col-span-6" title="Dit kan de student leren tijdens de stage"/>
    <QuestionnaireItemCard class="col-span-6" size="large" :skill="questionnaire.problem[this.internship?.problem]" />
    <QuestionnaireItemCard class="col-span-2" v-for="skill in this.internship?.skillsToLearnIntern?.split(',')" size="small" :key="skill" :skill="questionnaire.skills[skill]" />

    <StudentProfilePreferenceHeader class="col-span-6" title="Gewenste eigenschappen student"/>
    <QuestionnaireItemCard class="col-span-2" v-for="skill in this.internship?.qualitiesIntern?.split(',')" size="small" :key="skill" :skill="questionnaire.qualities[skill]" />
    <QuestionnaireItemCard class="col-span-2" v-for="skill in this.internship?.skillsIntern?.split(',')" size="small" :key="skill" :skill="questionnaire.skills[skill]" />

    <StudentProfilePreferenceHeader class="col-span-6" title="Binnen deze sector zijn wij werkzaam"/>
    <QuestionnaireItemCard class="col-span-3" v-for="skill in this.internship?.sector?.split(',')" size="medium" :key="skill" :skill="questionnaire.sector[skill]" />

    <StudentProfilePreferenceHeader class="col-span-6" title="Zo wil ik graag mijn begeleiding hebben"/>
    <QuestionnaireItemCard class="col-span-6" size="large" :skill="questionnaire.culture[this.internship?.teamwork]" />
    <QuestionnaireItemCard class="col-span-3" v-for="skill in this.internship?.mentorship?.split(',')" size="medium" :key="skill" :skill="questionnaire.mentorship[skill]" />


    <n-card class="col-span-6">
      <n-space class="card-title">
        {{ this.internship.function }}
      </n-space>
      <p class="internship__section-title">{{ this.internship.problem }}</p>
      <p>{{ questionnaire.problem[this.internship.problem]?.description}}</p>
      <br />
      <p> {{this.internship.problemDescription}}</p>
      <br />
      <div v-for="skill in this.internship.skillsIntern?.split(',')">
        <p class="internship__section-title">{{ skill }}</p>
        <p> {{ this.questionnaire.skills[skill]?.description}}</p>
        <br />
      </div>
      <p> {{this.internship.skillsInternDescription}}</p>
      <br />
      <div v-for="sector in this.internship.sector?.split(',')">
        <p class="internship__section-title">{{sector}}</p>
        <p> {{ this.questionnaire.sector[sector]?.description}}</p>
        <br />
      </div>
      <p> {{this.internship.sectorDescription}}</p>
      <br />
      <p class="internship__section-title">Vergoeding</p>
      <p> {{this.internship.money}}</p>
      <br />
      <p class="internship__section-title">Verantwoordelijkheden</p>
      <p> {{this.internship.responsability}}</p>
      <br />
      <p class="internship__section-title">Aantal uur per week</p>
      <p>{{this.internship.hours}}</p>
      <br />
    </n-card>
  </div>
</template>

<script>
import {PersonSharp} from "@vicons/ionicons5";
import {NCard, NTag, NSpace, useMessage} from "naive-ui";
import internshipService from "../services/InternshipService";
import questionnaireData from "../assets/json/questionaire.json";
export default {
  data() {
    return {
      message: useMessage(),
      internship: '',
      questionnaire: questionnaireData
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
      this.internship = response
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
.page-grid__main-content {
  display: grid;
  grid-template-columns: repeat(6, minmax(0, 1fr));
  flex-direction: column;
  gap: 20px;
}
.col-span-2 {
  grid-column: span 6;
}
.col-span-3 {
  grid-column: span 6;
}
.col-span-6 {
  grid-column: span 6;
}
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
@media (min-width: 1024px) {
  .page-grid__col-span-2 {
    grid-column: span 2;
  }

  .col-span-2 {
    grid-column: span 3;
  }

  .col-span-3 {
    grid-column: span 6;
  }

  .col-span-6 {
    grid-column: span 6;
  }
}
@media (min-width: 1280px) {
  .col-span-2 {
    grid-column: span 2;
  }
  .col-span-3 {
    grid-column: span 3;
  }
  .col-span-6 {
    grid-column: span 6;
  }
}
</style>
