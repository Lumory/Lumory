<template>
  <n-space class="steps-container" align="center" vertical>
    <n-image
        class="lumory-logo"
        src="/assets/img/Logo-horizontal.svg"
        height="50"
    />
    <n-steps
        @update:current="current"
        v-model:current="current"
    >
      <n-step title="Wie ben je?">
        d
      </n-step>
      <n-step title="Persoonlijke informatie">
        s
      </n-step>
      <n-step title="Stageprofiel">
        a
      </n-step>
    </n-steps>
  </n-space>
  <n-space vertical align="center">
    <h1>Waar ben je naar op zoek?</h1>
    <n-space align="center" vertical>
      <n-radio-group v-model:value="value" name="radiogroup">
        <n-space style="gap: 8px 50px;" justify="center" align="center">
          <n-radio-button value="w">
            <n-space class="radio-button" align="start" vertical>
              <n-icon size="24">
                <groups-filled />
              </n-icon>
              <p>Stage</p>
              <p>Ik ben een student op zoek naar een stage</p>
            </n-space>
          </n-radio-button>
          <n-radio-button value="w2">
            <n-space class="radio-button" align="start" vertical>
              <n-icon size="24">
                <person-filled />
              </n-icon>
              <p>Stagiairen</p>
              <p>Ik ben een stagebedrijf op zoek naar stagiairen</p>
            </n-space>
          </n-radio-button>
        </n-space>
      </n-radio-group>
      <n-button type="primary" class="stepper-next-button">Hallo</n-button>
    </n-space>
  </n-space>
</template>

<script>
import { GroupsFilled, PersonFilled} from '@vicons/material'
import {NSpace, NSteps, NStep, NGrid, NRadioGroup, NRadioButton, NRadio, NButton, NIcon, NImage} from 'naive-ui'
import { defineComponent, ref } from 'vue'

export default defineComponent({
  setup() {
    const currentRef = ref<Number | undefined>(1)
    return{
        current: currentRef
    }
  },
  components: {
    NSpace,
    NSteps,
    NStep,
    NGrid,
    NRadioGroup,
    NRadioButton,
    NRadio,
    NButton,
    NIcon,
    NImage,
    GroupsFilled,
    PersonFilled
  }
})
</script>

<style scoped>
  h1 {
    text-align: center;
  }
  .lumory-logo {
    margin: 50px 0;
  }
  .n-steps {
    margin-left: 28px;
    flex-direction: column;
  }
  .steps-container {
    margin: 0 auto;
  }
  .n-radio-group {
    margin: 0 auto;
    width: 100%;
    display: block;
  }
  .n-radio-group .n-radio-button {
    width: 250px;
    height: 200px;
    padding: 25px;
    transition: all 250ms ease;
    will-change: transition;
    display: inline-block;
    text-align: center;
    cursor: pointer;
    position: relative;
    font-weight: 900;
    border-radius: 15px;
    border: 3px solid #d9d9d9;
    font-family: "Roboto";
  }
  .n-radio-group .n-radio-button.n-radio-button--checked {
    background: #d9d9d9;
  }
  .stepper-next-button {
    margin-top: 25px;
    width: 250px;
    height: 50px;
    border-radius: 5px;
  }
  p {
    text-align: left;
    white-space: normal;
    font-family: "Roboto";
  }
  .steps-container .n-steps .n-step-content .n-step-content-header {
    display: none !important;
  }
  @media (min-width: 640px) {
    h1 {
      text-align: left;
    }
    .n-steps {
      flex-direction: row;
    }
    .n-radio-group {
      margin: 0 auto;
      width: 550px;
      display: block;
    }
    .n-radio-group .n-radio-button {
      width: 250px;
      height: 200px;
      padding: 25px;
      transition: all 250ms ease;
      will-change: transition;
      display: inline-block;
      text-align: center;
      cursor: pointer;
      position: relative;
      font-weight: 900;
      border-radius: 15px;
      border: 3px solid #d9d9d9;
      font-family: "Roboto";
    }
    .stepper-next-button {
      width: 550px;
    }
  }
</style>