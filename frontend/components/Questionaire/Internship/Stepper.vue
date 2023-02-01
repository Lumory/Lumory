<template>
  <n-space class="steps-container" vertical justify="start">
    <div class="wrapper">
      <ol class="c-stepper">
        <template v-for="(step, index) in this.steps">
          <li class="c-stepper__item" :class="index <= currentStep && 'complete'">
            <a @click="currentStep=index">
              <h3 class="c-stepper__title" v-if="step.title">{{ step.title }}</h3>
              <p class="c-stepper__desc" v-if="step.description">{{ step.description }}</p>
            </a>
          </li>
        </template>
      </ol>
    </div>

    <!-- Steps content -->
    <component :is="steps[currentStep].component" v-model="currentStep" ref="stepRef"></component>

    <!-- Steps controls -->
    <n-space class="stepper-controls" justify="end">
      <n-button quaternary strong size="large" @click="onPreviousButtonClick" v-if="this.currentStep != 0">
        Terug
      </n-button>
      <n-button secondary strong class="stepper__next-button" size="large" @click="onNextButtonClick" v-if="this.currentStep < this.steps.length -1">
        Volgende stap
      </n-button>
      <n-button secondary strong class="stepper__next-button" size="large" @click="onCompleteButtonClick" v-if="this.currentStep === this.steps.length -1">
        Voltooien
      </n-button>
    </n-space>
  </n-space>
</template>

<script>
import Problem from "../Internship/Problem";
import SkillsToLearn from "../Internship/SkillsToLearn";
import StrongQualities from "../Internship/StrongQualities";
import StrongSkills from "../Internship/StrongSkills";
import Sector from "../Internship/Sector";
import Teamwork from "../Internship/Teamwork";
import Mentorship from "../Internship/Mentorship"
import StudentQuestionnaireForm from "../Internship/Form";
import { NButton, NSpace, useMessage } from "naive-ui"
import questionnaireService from "../../../services/QuestionnaireService";
import {ref} from "vue";
import internshipService from "../../../services/InternshipService";

const steps = [
  {
    component: "Problem",
    required: true,
  },
  {
    component: "SkillsToLearn",
    required: true,
  },
  {
    component: "StrongQualities",
    required: true,
  },
  {
    component: "StrongSkills",
    required: true,
  },
  {
    component: "Sector",
    required: true,
  },
  {
    component: "Teamwork",
    required: true,
  },
  {
    component: "Mentorship",
    required: true,
  },
  {
    component: "StudentQuestionnaireForm",
    required: true,
  }
];

let questionnaireData = {
  problem: '',
  problemDescription: '',
  skillsToLearnIntern: '',
  skillsToLearnInternDescription: '',
  qualitiesIntern: '',
  qualitiesInternDescription: '',
  skillsIntern: '',
  skillsInternDescription: '',
  sector: '',
  sectorDescription: '',
  teamwork: '',
  teamworkDescription: '',
  mentorship: '',
  mentorshipDescription: '',
  money: '',
  remoteWork: '',
  function: '',
  responsability: '',
  workExperience: '',
  staff: '',
  website: '',
  streetAddress: '',
  city: '',
  contactPersonFirstName: '',
  contactPersonLastName: '',
  contactPersonEmail: '',
  international: '',
  dateStart: '',
  hours: '',
  applyBefore: ''
}

const isSubmitting = ref(false)

export default {
  components: {Problem, SkillsToLearn, StrongQualities, StrongSkills, Sector, Teamwork, Mentorship, StudentQuestionnaireForm, NButton, NSpace},
  methods: {
    validateCurrentStep() {
      return this.$refs.stepRef.handleValidateClick()
    },
    assignFormValues(formValues) {
      Object.keys(formValues).forEach(function(key) {
        if (key in questionnaireData) {
          questionnaireData[key] = formValues[key].toString();
        }
      });
      console.log(questionnaireData)
    },
    onPreviousButtonClick () {
      if(this.currentStep > 0) {
        this.currentStep--
      }
    },
    onNextButtonClick() {
      this.validateCurrentStep()
          .then((formValues) => {
            this.assignFormValues(formValues)
            if (this.currentStep < this.steps.length - 1) {
              this.currentStep++
            }
          })
          .catch((val) => {
            console.log(val)
          })
    },
    async onCompleteButtonClick() {
      isSubmitting.value = true
      this.validateCurrentStep()
          .then((formValues) => {
            this.assignFormValues(formValues)
            internshipService.postInternship(getCookieValue('company').id, questionnaireData)
                .then(() => {
                  navigateTo('/stages')
                })
                .catch(error => {
                  this.message.error(error.message)
                })
          })
          .catch((val) => {
            console.log(val)
          })
      isSubmitting.value = false
    }
  },
  data() {
    return {
      message: useMessage(),
      currentStep: 0,
      steps,
      isSubmitting,
    }
  }
}
</script>

<style scoped>
.c-stepper {
  --circle-size: clamp(1.5rem, 5vw, 3rem);
  --spacing: clamp(0.25rem, 2vw, 0.5rem);
  counter-reset: stepper-item;
}

.c-stepper {
  display: flex;
}
.stepper-controls {
  margin-top: 25px;
}

.c-stepper__item {
  display: flex;
  flex-direction: column;
  flex: 1;
  text-align: center;
}
.c-stepper__item a {
  cursor: pointer;
}

.c-stepper__item:before {
  --size: 3rem;
  display: flex;
  justify-content: center;
  align-items: center;
  width: var(--circle-size);
  height: var(--circle-size);
  border-radius: 50%;
  background-color: white;
  margin: 0 auto 1rem;
  counter-increment: stepper-item;
  font-weight: 700;
  content: counter(stepper-item);
}
.c-stepper__item.complete:before {
  background-color: var(--color-primary);
}
.c-stepper__item:not(:last-child):after {
  content: "";
  position: relative;
  top: calc(var(--circle-size) / 2);
  width: calc(100% - var(--circle-size) - calc(var(--spacing) * 2));
  left: calc(50% + calc(var(--circle-size) / 2 + var(--spacing)));
  height: 2px;
  background-color: #e0e0e0;
  order: -1;
}

.c-stepper__title {
  font-weight: bold;
  font-size: clamp(1rem, 4vw, 1.25rem);
  margin-bottom: 0.5rem;
}

.c-stepper__desc {
  color: grey;
  font-size: clamp(0.85rem, 2vw, 1rem);
  padding-left: var(--spacing);
  padding-right: var(--spacing);
}
.wrapper {
  max-width: 1000px;
  margin: 2rem auto 0;
}

.steps-container {
  width: 100%;
  margin: 0 auto;
}
.stepper__next-button {
  background: var(--color-primary);
  border: none;
}

@media (min-width: 640px) {
  .steps-container {
    max-width: 800px;
  }
}

</style>