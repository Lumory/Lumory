<template>
  <n-space class="steps-container" vertical>
    <div class="wrapper option-1 option-1-1">
      <ol class="c-stepper">
        <li class="c-stepper__item">
          <a @click="step=1">
            <h3 class="c-stepper__title">Step 1</h3>
            <p class="c-stepper__desc">You can add a description</p>
          </a>
        </li>
        <li class="c-stepper__item">
          <a @click="step=2">
            <h3 class="c-stepper__title">Step 2</h3>
            <p class="c-stepper__desc">Or do without.</p>
          </a>
        </li>
        <li class="c-stepper__item">
          <a @click="step=3">
            <h3 class="c-stepper__title">Step 3</h3>
          </a>
        </li>
      </ol>
    </div>

  <!-- Steps content -->
    <div v-if="step === 1">
      <step/>
      step 1
    </div>
    <div v-if="step === 2">
      <h1>Step 2</h1>
    </div>
    <div v-if="step === 3">
      <h1>Step 3</h1>
    </div>

  <!-- Steps controls -->
    <n-button type="primary" class="stepper-next-button" @click="step++">Volgende stap</n-button>
  </n-space>
</template>

<script>
import Step from "./Step";
import { NButton, NSpace } from "naive-ui"
export default {
  components: {Step, NButton, NSpace},
  data() {
    return {
      step: 1
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