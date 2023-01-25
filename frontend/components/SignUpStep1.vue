<template>
  <n-space vertical align="center">
    <h1>Waar ben je naar op zoek?</h1>
    <n-space align="center" vertical>
      <n-radio-group v-model:value="value" name="radiogroup">
        <n-space style="gap: 8px 50px;" justify="center" align="center">
          <n-radio-button value="w" @click="onClickButton('student')">
            <n-space class="radio-button" align="start" vertical>
              <n-icon size="24">
                <person-filled />
              </n-icon>
              <p class="radio-button__title">Stage</p>
              <p class="radio-button__subtitle">Ik ben een student op zoek naar een stage</p>
            </n-space>
          </n-radio-button>
          <n-radio-button value="w2" @click="onClickButton('internshipCompany')">
            <n-space class="radio-button" align="start" vertical>
              <n-icon size="24">
                <groups-filled />
              </n-icon>
              <p class="radio-button__title">Stagiairen</p>
              <p class="radio-button__subtitle">Ik ben een stagebedrijf op zoek naar stagiairen</p>
            </n-space>
          </n-radio-button>
        </n-space>
      </n-radio-group>
      <p class="errorMessage" v-if="errorMessage">{{ errorMessage }}</p>
    </n-space>
  </n-space>
</template>

<script>
import { GroupsFilled, PersonFilled} from '@vicons/material'
import {NSpace, NRadioGroup, NRadioButton, NRadio, NButton, NIcon} from 'naive-ui'
import { defineComponent, ref } from 'vue'

export default defineComponent({
  components: {
    NSpace,
    NRadioGroup,
    NRadioButton,
    NRadio,
    NButton,
    NIcon,
    GroupsFilled,
    PersonFilled
  },
  data() {
    return {
      value: ref(null),
      errorMessage: ref('')
    }
  },
  setup(props, context) {
    const userTypeSetRef = ref(false)
    const onClickButton = (val) => {
      userTypeSetRef.value = true
      context.emit('userTypeSelected', val)
    }
    function handleValidateClick() {
      if(!userTypeSetRef.value) {
        this.errorMessage = 'Selecteer een account type.'
        console.log(this.errorMessage)
        throw new TypeError("Please select your user type")
      }
      return Promise.resolve(userTypeSetRef.value)
    }
    return {
      onClickButton,
      handleValidateClick
    }
  }
})
</script>

<style scoped>
h1 {
  text-align: center;
}
.n-radio-group .n-radio-button {
  width: 250px;
  height: 200px;
  transition: all 250ms ease;
  will-change: transition;
  display: flex;
  flex-direction: column;
  align-items: flex-start;
  padding: 25px;
  gap: 13px;
  cursor: pointer;
  position: relative;
  border-radius: 15px;
  border: none;
  font-family: "Roboto";
  font-style: normal;
  box-shadow: 0px 2px 2px rgba(0, 0, 0, 0.05);
  background: #fff;
}
.radio-button__title {
  font-weight: 700;
  font-size: 32px;
  line-height: 38px;
}
.radio-button__subtitle {
  font-weight: 400;
  font-size: 16px;
  line-height: 19px;
  color: var(--color-subtitle)
}
.n-radio-group .n-radio-button:hover, .n-radio-group .n-radio-button:not(.n-radio-button--disabled):hover:not(.n-radio-button--checked) {
  color: #333;
}
.n-radio-group .n-radio-button.n-radio-button--checked {
  background: var(--color-primary);
}

p {
  text-align: left;
  white-space: normal;
  font-family: "Roboto";
}
.errorMessage {
  color: red;
}
.steps-container .n-steps .n-step-content .n-step-content-header {
  display: none !important;
}
@media (min-width: 640px) {
  .n-steps {
    flex-direction: row;
  }
  .n-radio-group {
    margin: 0 auto;
    width: 550px;
    display: block;
  }
  .stepper-next-button {
    width: 550px;
  }
}
</style>