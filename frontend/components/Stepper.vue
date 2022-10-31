<template>
  <n-space class="steps-container" vertical justify="start">
    <div class="wrapper option-1 option-1-1">
      <ol class="c-stepper">
        <li class="c-stepper__item" v-for="(step, index) in steps">
          <a @click="currentStep=index">
            <h3 class="c-stepper__title">{{ step.title }}</h3>
            <p class="c-stepper__desc">{{ step.description }}</p>
          </a>
        </li>
      </ol>
    </div>

  <!-- Steps content -->
    <component :is="steps[currentStep].component"></component>

  <!-- Steps controls -->
    <n-button type="primary" class="stepper-next-button" size="large" :disabled="!currentStep < steps.length -1" @click="currentStep < steps.length && currentStep++">
      Volgende stap</n-button>
  </n-space>
</template>

<script>
import Step1 from "./SignUpStep1";
import Step2 from "./SignUpStep2";
import { NButton, NSpace } from "naive-ui"

const steps = [
  {
    title: "Stap 1",
    description: "Je kunt een beschrijving toevoegen",
    component: "Step1",
    required: true,
  },
  {
    title: "Stap 2",
    description: "Of niet.",
    component: "step2",
    required: true,
  }
];
let currentStep = 0;
let hasNextStep = currentStep < steps.length -1;


export default {
  components: {Step1, Step2, NButton, NSpace},
  data() {
    return {
      currentStep,
      steps,
      hasNextStep
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
   background-color: #FEBF00;
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

h1 {
  text-align: center;
}
.steps-container {
  width: 100%;
  margin: 0 auto;
}

.stepper-next-button {
  width: 100%;
  margin: 0 auto;
}

@media (min-width: 640px) {
  .steps-container {
    max-width: 550px;
  }
}

</style>