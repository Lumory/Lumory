<template>
  <n-space class="steps-container" vertical justify="start">
    <div class="wrapper option-1 option-1-1">
      <ol class="c-stepper">
        <template v-for="(step, index) in this.steps">
          <li class="c-stepper__item" >
              <a @click="currentStep=index">
                <h3 class="c-stepper__title">{{ step.title }}</h3>
                <p class="c-stepper__desc">{{ step.description }}</p>
              </a>
          </li>
        </template>
      </ol>
    </div>

  <!-- Steps content -->
    <component :is="steps[currentStep].component" v-model="currentStep" @userTypeSelected="onUserTypeSelected"></component>

  <!-- Steps controls -->
    <n-button type="primary" class="stepper__next-button" :key="this.steps[currentStep]" size="large" @click="onNextButtonClick">
      Volgende stap</n-button>
  </n-space>
</template>

<script>
import Step1 from "./SignUpStep1";
import Step2 from "./SignUpStep2";
import Step3 from "./SignUpStep2Internship";
import Step4 from "./SignUpInternshipCompanyContactPerson";
import { NButton, NSpace } from "naive-ui"

const studentSteps = [
  {
    title: "Stap 1",
    description: "Account type",
    component: "Step1",
    required: true,
  },
  {
    title: "Stap 2",
    description: "Persoonlijke informatie",
    component: "step2",
    required: true,
    userType: "student"
  }
];

const internshipSteps = [
  {
    title: "Stap 1",
    description: "Account type",
    component: "Step1",
    required: true,
  },
  {
    title: "Stap 2",
    description: "Bedrijfsinformatie",
    component: "Step3",
    required: true,
    userType: "internshipCompany"
  },
  {
    title: "Stap 3",
    description: "Contactpersoon",
    component: "Step4",
    required: true,
    userType: "internshipCompany"
  }
];

export default {
  components: {Step1, Step2, Step3, Step4, NButton, NSpace},
  methods: {
    onUserTypeSelected (value) {
      this.userType = value
      if (value === "internshipCompany") {
        this.steps = internshipSteps
      }
      else if (value === "student") {
        this.steps = studentSteps
      }
      console.log(this.steps)
    },
    onNextButtonClick () {
      this.currentStep++
    }
  },
  computed: {
    computedSteps(userType) {
      return steps.filter(step => step.userType===userType)
    }
  },
  data() {
    return {
      currentStep: 0,
      steps: studentSteps,
      userType: "student",
    }
  }
}
</script>

<style scoped>
.c-stepper {
  --circle-size: clamp(1.5rem, 5vw, 3rem);
  --spacing: clamp(0.25rem, 2vw, 0.5rem);
}

.c-stepper {
  display: flex;
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
   content: "";
   display: block;
   width: var(--circle-size);
   height: var(--circle-size);
   border-radius: 50%;
   background-color: var(--color-primary);
   margin: 0 auto 1rem;
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

*,
*:before,
*:after {
  box-sizing: border-box;
}

.steps-container {
  width: 100%;
  margin: 0 auto;
}
.stepper__next-button {
  width: 100%;
  margin-top: 25px;
  background: var(--color-primary);
  border: none;
}

.stepper__next-button:hover {
  background: var(--color-primary);
}

@media (min-width: 640px) {
  .steps-container {
    max-width: 550px;
  }
}

</style>