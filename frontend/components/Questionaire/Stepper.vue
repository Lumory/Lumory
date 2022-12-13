<template>
  <n-space class="steps-container" vertical justify="start">
    <div class="wrapper">
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
import Step1 from "./Step1";
import { NButton, NSpace } from "naive-ui"

const steps = [
  {
    title: "Stap 1",
    description: "Voorkeuren stage",
    component: "Step1",
    required: true,
  },
  {
    title: "Stap 2",
    description: "Voorkeuren Stagebedrijf",
    component: "Step1",
    required: true,
  },
  {
    title: "Stap 3",
    description: "Persoonlijkheid",
    component: "Step1",
    required: true,
  }
];

export default {
  components: {Step1, NButton, NSpace},
  methods: {
    validateCurrentStep () {
      return this.$refs.stepRef.handleValidateClick()
          .then(() => {
            return true
          })
          .catch(() => {
            return false
          })
    },
    onPreviousButtonClick () {
      if(this.currentStep > 0) {
        this.currentStep--
      }
    },
    onNextButtonClick () {
      this.validateCurrentStep()
          .then(isValid => {
            if(!isValid) {
              return
            }
            if(this.currentStep < this.steps.length -1) {
              this.currentStep++
            }
            return isValid
          })
    },
    onCompleteButtonClick () {
      console.log("Verstuurd!")
    }
  },
  data() {
    return {
      currentStep: 0,
      steps,
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
    max-width: 550px;
  }
}

</style>